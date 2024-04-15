using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace TestTask
{
 

    public partial class Form1 : Form
    {
        SqlConnection sqlConnection = null;
        string folderName = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionAddress"].ConnectionString);

                sqlConnection.Open();

                // Проверка существования таблиц и их создание при необходимости.
                if (!TableExists(sqlConnection, "Organizations"))
                {
                    string createOrganizationsTableQuery =
                        "CREATE TABLE Organizations (" +
                        "ID INT PRIMARY KEY IDENTITY," +
                        "Name NVARCHAR(100)," +
                        "INN NVARCHAR(20)," +
                        "LegalAddress NVARCHAR(200)," +
                        "ActualAddress NVARCHAR(200)" +
                        ")";
                    SqlCommand createOrganizationsTableCommand = new SqlCommand(createOrganizationsTableQuery, sqlConnection);
                    createOrganizationsTableCommand.ExecuteNonQuery();
                }

                if (!TableExists(sqlConnection, "Employees"))
                {
                    string createEmployeesTableQuery =
                        "CREATE TABLE Employees (" +
                        "ID INT PRIMARY KEY IDENTITY," +
                        "LastName NVARCHAR(50)," +
                        "FirstName NVARCHAR(50)," +
                        "MiddleName NVARCHAR(50)," +
                        "BirthDate DATE," +
                        "PassportSeries NVARCHAR(10)," +
                        "PassportNumber NVARCHAR(20)," +
                        ")";
                    SqlCommand createEmployeesTableCommand = new SqlCommand(createEmployeesTableQuery, sqlConnection);
                    createEmployeesTableCommand.ExecuteNonQuery();
                }

            sqlConnection.Close();

        }

        
        

        //Добавление сотрудников.
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Employees (LastName, FirstName, MiddleName, BirthDate, PassportSeries, PassportNumber) VALUES (@LastName, @FirstName, @MiddleName, @BirthDate, @PassportSeries, @PassportNumber)", sqlConnection);
                command.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                command.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                command.Parameters.AddWithValue("@MiddleName", MiddleNameTextBox.Text);
                command.Parameters.AddWithValue("@BirthDate", BirthDateDateTimePicker.Value);
                command.Parameters.AddWithValue("@PassportSeries", PassportSeriesTextBox.Text);
                command.Parameters.AddWithValue("@PassportNumber", PassportNumberTextBox.Text);command.ExecuteNonQuery();
                sqlConnection.Close();
        }

        //Добавление организаций.
        private void AddOrganizationButton_Click_1(object sender, EventArgs e)
        {
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Organizations (Name, INN, LegalAddress, ActualAddress) VALUES (@Name, @INN, @LegalAddress, @ActualAddress)", sqlConnection);
                command.Parameters.AddWithValue("@Name", OrganizationNameTextBox.Text);
                command.Parameters.AddWithValue("@INN", INNTextBox.Text);
                command.Parameters.AddWithValue("@LegalAddress", LegalAddressTextBox.Text);
                command.Parameters.AddWithValue("@ActualAddress", ActualAddressTextBox.Text);
                command.ExecuteNonQuery();
                sqlConnection.Close();
        }

        // Функция для проверки существования таблиц
        static bool TableExists(SqlConnection connection, string tableName)
        {
            using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tableName", connection))
            {
                command.Parameters.AddWithValue("@tableName", tableName);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return (count > 0);
            }
        }

        private void ClearTableButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            ClearTable(sqlConnection, "Employees");
            ClearTable(sqlConnection, "Organizations");

            sqlConnection.Close();

        }

        // Функция для удаления данных из таблицы
        static void ClearTable(SqlConnection connection, string tableName)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM " + tableName, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        // Импорт данных из csv-файла
        private void ImportDataButton_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            ImportCSVToTable("Organizations", folderName + "/Organizations.csv");
            ImportCSVToTable("Employees", folderName + "/Employees.csv");
            sqlConnection.Close();
        }

        // Экспорт данных в csv-файл
        private void ExportDataButton_Click(object sender, EventArgs e)
        {
            ExportTableToCSV(sqlConnection, "Organizations", folderName + "/Organizations.csv");
            ExportTableToCSV(sqlConnection, "Employees", folderName + "/Employees.csv");

        }

        // Функция для экспорта данных из таблицы в CSV файл
        static void ExportTableToCSV(SqlConnection connection, string tableName, string csvFilePath)
        {
            connection.Open();
            string query = "SELECT * FROM " + tableName;
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            using (StreamWriter sw = new StreamWriter(csvFilePath))
            {
                // Запись заголовков столбцов
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    sw.Write(dataTable.Columns[i].ColumnName);
                    if (i < dataTable.Columns.Count - 1)
                    {
                        sw.Write(";");
                    }
                }
                sw.Write(sw.NewLine);

                // Запись данных
                foreach (DataRow row in dataTable.Rows)
                {
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        if (!Convert.IsDBNull(row[i]))
                        {
                            sw.Write(row[i].ToString());
                        }
                        if (i < dataTable.Columns.Count - 1)
                        {
                            sw.Write(";");
                        }
                    }
                    sw.Write(sw.NewLine);
                }
            }
            connection.Close();

        }


        // Функция для импорта данных.
        static void ImportCSVToTable(string tableName, string csvFilePath)
        {
            using (var reader = new StreamReader(csvFilePath))
            {
                using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionAddress"].ConnectionString))
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        using (var bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                        {
                            bulkCopy.DestinationTableName = tableName;
                            string[] headers = reader.ReadLine().Split(';'); // Чтение заголовков столбцов

                            // Создание столбцов для DataTable
                            DataTable dataTable = new DataTable();
                            foreach (var header in headers)
                            {
                                dataTable.Columns.Add(new DataColumn(header, typeof(string)));
                            }

                            // Чтение данных из CSV файла и вставка в базу данных
                            while (!reader.EndOfStream)
                            {
                                string[] rows = reader.ReadLine().Split(';');
                                DataRow dataRow = dataTable.NewRow();
                                for (int i = 0; i < headers.Length; i++)
                                {
                                    dataRow[i] = rows[i];
                                }
                                dataTable.Rows.Add(dataRow);
                            }

                            bulkCopy.WriteToServer(dataTable);
                        }
                        transaction.Commit();
                    }
                }
            }
        }

        private void PathSelectButton_Click(object sender, EventArgs e)
        {
            // показать диалог выбора папки
            DialogResult result = folderBrowserDialog1.ShowDialog();

            // если папка выбрана и нажата клавиша `OK` - значит можно получить путь к папке
            if (result == DialogResult.OK)
            {
                // запишем в нашу переменную путь к папке
                folderName = folderBrowserDialog1.SelectedPath;
                Console.WriteLine(folderName);
            }
        }
    }
}

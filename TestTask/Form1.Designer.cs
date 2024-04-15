namespace TestTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OrganizationNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddOrganizationButton = new System.Windows.Forms.Button();
            this.ActualAddressTextBox = new System.Windows.Forms.TextBox();
            this.ActualAddressLabel = new System.Windows.Forms.Label();
            this.LegalAddressTextBox = new System.Windows.Forms.TextBox();
            this.LegalAddressLabel = new System.Windows.Forms.Label();
            this.INNLabel = new System.Windows.Forms.Label();
            this.INNTextBox = new System.Windows.Forms.TextBox();
            this.OrganizationNameLabel = new System.Windows.Forms.Label();
            this.OrganizationGroupLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddEmployeeButton = new System.Windows.Forms.Button();
            this.BirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PassportSeriesLabel = new System.Windows.Forms.Label();
            this.PassportNumberTextBox = new System.Windows.Forms.TextBox();
            this.PassportSeriesTextBox = new System.Windows.Forms.TextBox();
            this.PassportNumberLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.MiddleNameLabel = new System.Windows.Forms.Label();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.ClearTableButton = new System.Windows.Forms.Button();
            this.ExportDataButton = new System.Windows.Forms.Button();
            this.ImportDataButton = new System.Windows.Forms.Button();
            this.PathSelectButton = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrganizationNameTextBox
            // 
            this.OrganizationNameTextBox.Location = new System.Drawing.Point(8, 97);
            this.OrganizationNameTextBox.Name = "OrganizationNameTextBox";
            this.OrganizationNameTextBox.Size = new System.Drawing.Size(165, 20);
            this.OrganizationNameTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddOrganizationButton);
            this.panel1.Controls.Add(this.ActualAddressTextBox);
            this.panel1.Controls.Add(this.ActualAddressLabel);
            this.panel1.Controls.Add(this.LegalAddressTextBox);
            this.panel1.Controls.Add(this.LegalAddressLabel);
            this.panel1.Controls.Add(this.INNLabel);
            this.panel1.Controls.Add(this.INNTextBox);
            this.panel1.Controls.Add(this.OrganizationNameLabel);
            this.panel1.Controls.Add(this.OrganizationGroupLabel);
            this.panel1.Controls.Add(this.OrganizationNameTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 426);
            this.panel1.TabIndex = 1;
            // 
            // AddOrganizationButton
            // 
            this.AddOrganizationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrganizationButton.Location = new System.Drawing.Point(3, 294);
            this.AddOrganizationButton.Name = "AddOrganizationButton";
            this.AddOrganizationButton.Size = new System.Drawing.Size(329, 129);
            this.AddOrganizationButton.TabIndex = 9;
            this.AddOrganizationButton.Text = "Добавить организацию";
            this.AddOrganizationButton.UseVisualStyleBackColor = true;
            this.AddOrganizationButton.Click += new System.EventHandler(this.AddOrganizationButton_Click_1);
            // 
            // ActualAddressTextBox
            // 
            this.ActualAddressTextBox.Location = new System.Drawing.Point(8, 238);
            this.ActualAddressTextBox.Name = "ActualAddressTextBox";
            this.ActualAddressTextBox.Size = new System.Drawing.Size(165, 20);
            this.ActualAddressTextBox.TabIndex = 8;
            // 
            // ActualAddressLabel
            // 
            this.ActualAddressLabel.AutoSize = true;
            this.ActualAddressLabel.Location = new System.Drawing.Point(8, 222);
            this.ActualAddressLabel.Name = "ActualAddressLabel";
            this.ActualAddressLabel.Size = new System.Drawing.Size(109, 13);
            this.ActualAddressLabel.TabIndex = 7;
            this.ActualAddressLabel.Text = "Фактический адрес";
            // 
            // LegalAddressTextBox
            // 
            this.LegalAddressTextBox.Location = new System.Drawing.Point(8, 191);
            this.LegalAddressTextBox.Name = "LegalAddressTextBox";
            this.LegalAddressTextBox.Size = new System.Drawing.Size(165, 20);
            this.LegalAddressTextBox.TabIndex = 6;
            // 
            // LegalAddressLabel
            // 
            this.LegalAddressLabel.AutoSize = true;
            this.LegalAddressLabel.Location = new System.Drawing.Point(8, 175);
            this.LegalAddressLabel.Name = "LegalAddressLabel";
            this.LegalAddressLabel.Size = new System.Drawing.Size(108, 13);
            this.LegalAddressLabel.TabIndex = 5;
            this.LegalAddressLabel.Text = "Юридический адрес";
            // 
            // INNLabel
            // 
            this.INNLabel.AutoSize = true;
            this.INNLabel.Location = new System.Drawing.Point(8, 128);
            this.INNLabel.Name = "INNLabel";
            this.INNLabel.Size = new System.Drawing.Size(31, 13);
            this.INNLabel.TabIndex = 4;
            this.INNLabel.Text = "ИНН";
            // 
            // INNTextBox
            // 
            this.INNTextBox.Location = new System.Drawing.Point(8, 144);
            this.INNTextBox.Name = "INNTextBox";
            this.INNTextBox.Size = new System.Drawing.Size(165, 20);
            this.INNTextBox.TabIndex = 3;
            // 
            // OrganizationNameLabel
            // 
            this.OrganizationNameLabel.AutoSize = true;
            this.OrganizationNameLabel.Location = new System.Drawing.Point(8, 80);
            this.OrganizationNameLabel.Name = "OrganizationNameLabel";
            this.OrganizationNameLabel.Size = new System.Drawing.Size(151, 13);
            this.OrganizationNameLabel.TabIndex = 2;
            this.OrganizationNameLabel.Text = "Наименование организации";
            // 
            // OrganizationGroupLabel
            // 
            this.OrganizationGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrganizationGroupLabel.Location = new System.Drawing.Point(3, 20);
            this.OrganizationGroupLabel.Name = "OrganizationGroupLabel";
            this.OrganizationGroupLabel.Size = new System.Drawing.Size(329, 35);
            this.OrganizationGroupLabel.TabIndex = 1;
            this.OrganizationGroupLabel.Text = "Добавление организации.";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddEmployeeButton);
            this.panel2.Controls.Add(this.BirthDateDateTimePicker);
            this.panel2.Controls.Add(this.PassportSeriesLabel);
            this.panel2.Controls.Add(this.PassportNumberTextBox);
            this.panel2.Controls.Add(this.PassportSeriesTextBox);
            this.panel2.Controls.Add(this.PassportNumberLabel);
            this.panel2.Controls.Add(this.BirthDateLabel);
            this.panel2.Controls.Add(this.MiddleNameLabel);
            this.panel2.Controls.Add(this.MiddleNameTextBox);
            this.panel2.Controls.Add(this.FirstNameLabel);
            this.panel2.Controls.Add(this.FirstNameTextBox);
            this.panel2.Controls.Add(this.LastNameLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LastNameTextBox);
            this.panel2.Location = new System.Drawing.Point(367, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 426);
            this.panel2.TabIndex = 2;
            // 
            // AddEmployeeButton
            // 
            this.AddEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddEmployeeButton.Location = new System.Drawing.Point(3, 294);
            this.AddEmployeeButton.Name = "AddEmployeeButton";
            this.AddEmployeeButton.Size = new System.Drawing.Size(329, 129);
            this.AddEmployeeButton.TabIndex = 10;
            this.AddEmployeeButton.Text = "Добавить сотрудника";
            this.AddEmployeeButton.UseVisualStyleBackColor = true;
            this.AddEmployeeButton.Click += new System.EventHandler(this.AddEmployeeButton_Click);
            // 
            // BirthDateDateTimePicker
            // 
            this.BirthDateDateTimePicker.Location = new System.Drawing.Point(8, 122);
            this.BirthDateDateTimePicker.Name = "BirthDateDateTimePicker";
            this.BirthDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.BirthDateDateTimePicker.TabIndex = 19;
            // 
            // PassportSeriesLabel
            // 
            this.PassportSeriesLabel.AutoSize = true;
            this.PassportSeriesLabel.Location = new System.Drawing.Point(8, 151);
            this.PassportSeriesLabel.Name = "PassportSeriesLabel";
            this.PassportSeriesLabel.Size = new System.Drawing.Size(88, 13);
            this.PassportSeriesLabel.TabIndex = 18;
            this.PassportSeriesLabel.Text = "Серия паспорта";
            // 
            // PassportNumberTextBox
            // 
            this.PassportNumberTextBox.Location = new System.Drawing.Point(8, 217);
            this.PassportNumberTextBox.Name = "PassportNumberTextBox";
            this.PassportNumberTextBox.Size = new System.Drawing.Size(165, 20);
            this.PassportNumberTextBox.TabIndex = 11;
            // 
            // PassportSeriesTextBox
            // 
            this.PassportSeriesTextBox.Location = new System.Drawing.Point(7, 170);
            this.PassportSeriesTextBox.Name = "PassportSeriesTextBox";
            this.PassportSeriesTextBox.Size = new System.Drawing.Size(165, 20);
            this.PassportSeriesTextBox.TabIndex = 17;
            // 
            // PassportNumberLabel
            // 
            this.PassportNumberLabel.AutoSize = true;
            this.PassportNumberLabel.Location = new System.Drawing.Point(8, 201);
            this.PassportNumberLabel.Name = "PassportNumberLabel";
            this.PassportNumberLabel.Size = new System.Drawing.Size(91, 13);
            this.PassportNumberLabel.TabIndex = 10;
            this.PassportNumberLabel.Text = "Номер паспорта";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(8, 104);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(86, 13);
            this.BirthDateLabel.TabIndex = 16;
            this.BirthDateLabel.Text = "Дата рождения";
            // 
            // MiddleNameLabel
            // 
            this.MiddleNameLabel.AutoSize = true;
            this.MiddleNameLabel.Location = new System.Drawing.Point(217, 55);
            this.MiddleNameLabel.Name = "MiddleNameLabel";
            this.MiddleNameLabel.Size = new System.Drawing.Size(54, 13);
            this.MiddleNameLabel.TabIndex = 14;
            this.MiddleNameLabel.Text = "Отчество";
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(210, 72);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.MiddleNameTextBox.TabIndex = 13;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(127, 56);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(29, 13);
            this.FirstNameLabel.TabIndex = 12;
            this.FirstNameLabel.Text = "Имя";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(123, 72);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(81, 20);
            this.FirstNameTextBox.TabIndex = 11;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(5, 55);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(56, 13);
            this.LastNameLabel.TabIndex = 10;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "Добавление сотрудника.";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(3, 72);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(114, 20);
            this.LastNameTextBox.TabIndex = 0;
            // 
            // ClearTableButton
            // 
            this.ClearTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearTableButton.Location = new System.Drawing.Point(730, 343);
            this.ClearTableButton.Name = "ClearTableButton";
            this.ClearTableButton.Size = new System.Drawing.Size(321, 93);
            this.ClearTableButton.TabIndex = 3;
            this.ClearTableButton.Text = "Очистить данные";
            this.ClearTableButton.UseVisualStyleBackColor = true;
            this.ClearTableButton.Click += new System.EventHandler(this.ClearTableButton_Click);
            // 
            // ExportDataButton
            // 
            this.ExportDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportDataButton.Location = new System.Drawing.Point(730, 244);
            this.ExportDataButton.Name = "ExportDataButton";
            this.ExportDataButton.Size = new System.Drawing.Size(321, 93);
            this.ExportDataButton.TabIndex = 4;
            this.ExportDataButton.Text = "Экспорт данных";
            this.ExportDataButton.UseVisualStyleBackColor = true;
            this.ExportDataButton.Click += new System.EventHandler(this.ExportDataButton_Click);
            // 
            // ImportDataButton
            // 
            this.ImportDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ImportDataButton.Location = new System.Drawing.Point(730, 145);
            this.ImportDataButton.Name = "ImportDataButton";
            this.ImportDataButton.Size = new System.Drawing.Size(321, 93);
            this.ImportDataButton.TabIndex = 5;
            this.ImportDataButton.Text = "Импорт данных";
            this.ImportDataButton.UseVisualStyleBackColor = true;
            this.ImportDataButton.Click += new System.EventHandler(this.ImportDataButton_Click);
            // 
            // PathSelectButton
            // 
            this.PathSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathSelectButton.Location = new System.Drawing.Point(730, 41);
            this.PathSelectButton.Name = "PathSelectButton";
            this.PathSelectButton.Size = new System.Drawing.Size(321, 93);
            this.PathSelectButton.TabIndex = 6;
            this.PathSelectButton.Text = "Выбрать путь";
            this.PathSelectButton.UseVisualStyleBackColor = true;
            this.PathSelectButton.Click += new System.EventHandler(this.PathSelectButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 448);
            this.Controls.Add(this.PathSelectButton);
            this.Controls.Add(this.ImportDataButton);
            this.Controls.Add(this.ExportDataButton);
            this.Controls.Add(this.ClearTableButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OrganizationNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label OrganizationGroupLabel;
        private System.Windows.Forms.Label OrganizationNameLabel;
        private System.Windows.Forms.Label INNLabel;
        private System.Windows.Forms.TextBox INNTextBox;
        private System.Windows.Forms.TextBox LegalAddressTextBox;
        private System.Windows.Forms.Label LegalAddressLabel;
        private System.Windows.Forms.TextBox ActualAddressTextBox;
        private System.Windows.Forms.Label ActualAddressLabel;
        private System.Windows.Forms.Button AddOrganizationButton;
        private System.Windows.Forms.Label PassportSeriesLabel;
        private System.Windows.Forms.TextBox PassportSeriesTextBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label MiddleNameLabel;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker BirthDateDateTimePicker;
        private System.Windows.Forms.TextBox PassportNumberTextBox;
        private System.Windows.Forms.Label PassportNumberLabel;
        private System.Windows.Forms.Button ClearTableButton;
        private System.Windows.Forms.Button AddEmployeeButton;
        private System.Windows.Forms.Button ExportDataButton;
        private System.Windows.Forms.Button ImportDataButton;
        private System.Windows.Forms.Button PathSelectButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}


namespace WindowsFormApp {
    partial class AddNewCoach {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewCoach));
            this.addTrainingButton = new System.Windows.Forms.Button();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTypeOfEducation = new System.Windows.Forms.ComboBox();
            this.labelTypeOfEducation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTrainingButton
            // 
            this.addTrainingButton.Location = new System.Drawing.Point(15, 249);
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.Size = new System.Drawing.Size(252, 23);
            this.addTrainingButton.TabIndex = 33;
            this.addTrainingButton.Text = "Добавить";
            this.addTrainingButton.UseVisualStyleBackColor = true;
            this.addTrainingButton.Click += new System.EventHandler(this.addTrainingButton_Click);
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(122, 90);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(142, 20);
            this.datePickerBirthday.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Дата рождения:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(122, 64);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(142, 20);
            this.textBoxMiddleName.TabIndex = 30;
            this.textBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiddleName_KeyPress);
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(9, 64);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.labelMiddleName.TabIndex = 29;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 38);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 28;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(9, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 27;
            this.nameLabel.Text = "Имя:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(122, 116);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ShortcutsEnabled = false;
            this.phoneTextBox.Size = new System.Drawing.Size(142, 20);
            this.phoneTextBox.TabIndex = 26;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(9, 116);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 13);
            this.phoneLabel.TabIndex = 25;
            this.phoneLabel.Text = "Телефон:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(122, 12);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(142, 20);
            this.surnameTextBox.TabIndex = 24;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(9, 15);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(59, 13);
            this.surnameLabel.TabIndex = 23;
            this.surnameLabel.Text = "Фамилия:";
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(122, 142);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.ShortcutsEnabled = false;
            this.textBoxExperience.Size = new System.Drawing.Size(142, 20);
            this.textBoxExperience.TabIndex = 35;
            this.textBoxExperience.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxExperience_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Опыт:";
            // 
            // comboBoxTypeOfEducation
            // 
            this.comboBoxTypeOfEducation.FormattingEnabled = true;
            this.comboBoxTypeOfEducation.Items.AddRange(new object[] {
            "отсутствует",
            "среднее",
            "колледж",
            "высшее"});
            this.comboBoxTypeOfEducation.Location = new System.Drawing.Point(122, 168);
            this.comboBoxTypeOfEducation.Name = "comboBoxTypeOfEducation";
            this.comboBoxTypeOfEducation.Size = new System.Drawing.Size(142, 21);
            this.comboBoxTypeOfEducation.TabIndex = 37;
            // 
            // labelTypeOfEducation
            // 
            this.labelTypeOfEducation.AutoSize = true;
            this.labelTypeOfEducation.Location = new System.Drawing.Point(9, 168);
            this.labelTypeOfEducation.Name = "labelTypeOfEducation";
            this.labelTypeOfEducation.Size = new System.Drawing.Size(78, 13);
            this.labelTypeOfEducation.TabIndex = 36;
            this.labelTypeOfEducation.Text = "Образование:";
            // 
            // AddNewCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 284);
            this.Controls.Add(this.comboBoxTypeOfEducation);
            this.Controls.Add(this.labelTypeOfEducation);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTrainingButton);
            this.Controls.Add(this.datePickerBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMiddleName);
            this.Controls.Add(this.labelMiddleName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewCoach";
            this.Text = "Добавление тренера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTrainingButton;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTypeOfEducation;
        private System.Windows.Forms.Label labelTypeOfEducation;
    }
}
namespace WindowsFormApp {
    partial class AddNewClient {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewClient));
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.addTrainingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(122, 114);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.ShortcutsEnabled = false;
            this.phoneTextBox.Size = new System.Drawing.Size(142, 20);
            this.phoneTextBox.TabIndex = 14;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(9, 117);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(55, 13);
            this.phoneLabel.TabIndex = 13;
            this.phoneLabel.Text = "Телефон:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(122, 10);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(142, 20);
            this.surnameTextBox.TabIndex = 12;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(9, 13);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(59, 13);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Фамилия:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(122, 36);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 20);
            this.textBoxName.TabIndex = 16;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Имя:";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(122, 62);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(142, 20);
            this.textBoxMiddleName.TabIndex = 18;
            this.textBoxMiddleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxMiddleName_KeyPress);
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(12, 65);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
            this.labelMiddleName.TabIndex = 17;
            this.labelMiddleName.Text = "Отчество:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Дата рождения:";
            // 
            // datePickerBirthday
            // 
            this.datePickerBirthday.Location = new System.Drawing.Point(122, 88);
            this.datePickerBirthday.Name = "datePickerBirthday";
            this.datePickerBirthday.Size = new System.Drawing.Size(142, 20);
            this.datePickerBirthday.TabIndex = 21;
            // 
            // addTrainingButton
            // 
            this.addTrainingButton.Location = new System.Drawing.Point(12, 140);
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.Size = new System.Drawing.Size(252, 23);
            this.addTrainingButton.TabIndex = 22;
            this.addTrainingButton.Text = "Добавить";
            this.addTrainingButton.UseVisualStyleBackColor = true;
            this.addTrainingButton.Click += new System.EventHandler(this.addTrainingButton_Click);
            // 
            // AddNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 169);
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
            this.Name = "AddNewClient";
            this.Text = "Добавление клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerBirthday;
        private System.Windows.Forms.Button addTrainingButton;
    }
}
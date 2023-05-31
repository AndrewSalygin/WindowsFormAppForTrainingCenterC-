namespace WindowsFormApp {
    partial class DeleteClientFromTraining {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteClientFromTraining));
            this.phoneTextBoxCoach = new System.Windows.Forms.TextBox();
            this.phoneLabelCoach = new System.Windows.Forms.Label();
            this.surnameTextBoxCoach = new System.Windows.Forms.TextBox();
            this.surnameLabelCoach = new System.Windows.Forms.Label();
            this.gymTextBox = new System.Windows.Forms.TextBox();
            this.gymKeyLabel = new System.Windows.Forms.Label();
            this.phoneTextBoxClient = new System.Windows.Forms.TextBox();
            this.phoneLabelClient = new System.Windows.Forms.Label();
            this.surnameTextBoxClient = new System.Windows.Forms.TextBox();
            this.surnameLabelClient = new System.Windows.Forms.Label();
            this.deleteTrainingButton = new System.Windows.Forms.Button();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phoneTextBoxCoach
            // 
            this.phoneTextBoxCoach.Location = new System.Drawing.Point(122, 118);
            this.phoneTextBoxCoach.Name = "phoneTextBoxCoach";
            this.phoneTextBoxCoach.ShortcutsEnabled = false;
            this.phoneTextBoxCoach.Size = new System.Drawing.Size(142, 20);
            this.phoneTextBoxCoach.TabIndex = 40;
            this.phoneTextBoxCoach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBoxCoach_KeyPress);
            // 
            // phoneLabelCoach
            // 
            this.phoneLabelCoach.AutoSize = true;
            this.phoneLabelCoach.Location = new System.Drawing.Point(9, 118);
            this.phoneLabelCoach.Name = "phoneLabelCoach";
            this.phoneLabelCoach.Size = new System.Drawing.Size(99, 13);
            this.phoneLabelCoach.TabIndex = 39;
            this.phoneLabelCoach.Text = "Телефон тренера:";
            // 
            // surnameTextBoxCoach
            // 
            this.surnameTextBoxCoach.Location = new System.Drawing.Point(122, 92);
            this.surnameTextBoxCoach.Name = "surnameTextBoxCoach";
            this.surnameTextBoxCoach.Size = new System.Drawing.Size(142, 20);
            this.surnameTextBoxCoach.TabIndex = 38;
            this.surnameTextBoxCoach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBoxCoach_KeyPress);
            // 
            // surnameLabelCoach
            // 
            this.surnameLabelCoach.AutoSize = true;
            this.surnameLabelCoach.Location = new System.Drawing.Point(9, 95);
            this.surnameLabelCoach.Name = "surnameLabelCoach";
            this.surnameLabelCoach.Size = new System.Drawing.Size(103, 13);
            this.surnameLabelCoach.TabIndex = 37;
            this.surnameLabelCoach.Text = "Фамилия тренера:";
            // 
            // gymTextBox
            // 
            this.gymTextBox.Location = new System.Drawing.Point(122, 63);
            this.gymTextBox.Name = "gymTextBox";
            this.gymTextBox.ShortcutsEnabled = false;
            this.gymTextBox.Size = new System.Drawing.Size(142, 20);
            this.gymTextBox.TabIndex = 36;
            this.gymTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gymTextBox_KeyPress);
            // 
            // gymKeyLabel
            // 
            this.gymKeyLabel.AutoSize = true;
            this.gymKeyLabel.Location = new System.Drawing.Point(9, 66);
            this.gymKeyLabel.Name = "gymKeyLabel";
            this.gymKeyLabel.Size = new System.Drawing.Size(71, 13);
            this.gymKeyLabel.TabIndex = 35;
            this.gymKeyLabel.Text = "Номер зала:";
            // 
            // phoneTextBoxClient
            // 
            this.phoneTextBoxClient.Location = new System.Drawing.Point(122, 37);
            this.phoneTextBoxClient.Name = "phoneTextBoxClient";
            this.phoneTextBoxClient.ShortcutsEnabled = false;
            this.phoneTextBoxClient.Size = new System.Drawing.Size(142, 20);
            this.phoneTextBoxClient.TabIndex = 34;
            this.phoneTextBoxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBoxClient_KeyPress);
            // 
            // phoneLabelClient
            // 
            this.phoneLabelClient.AutoSize = true;
            this.phoneLabelClient.Location = new System.Drawing.Point(9, 40);
            this.phoneLabelClient.Name = "phoneLabelClient";
            this.phoneLabelClient.Size = new System.Drawing.Size(99, 13);
            this.phoneLabelClient.TabIndex = 33;
            this.phoneLabelClient.Text = "Телефон клиента:";
            // 
            // surnameTextBoxClient
            // 
            this.surnameTextBoxClient.Location = new System.Drawing.Point(122, 11);
            this.surnameTextBoxClient.Name = "surnameTextBoxClient";
            this.surnameTextBoxClient.Size = new System.Drawing.Size(142, 20);
            this.surnameTextBoxClient.TabIndex = 32;
            this.surnameTextBoxClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBoxClient_KeyPress);
            // 
            // surnameLabelClient
            // 
            this.surnameLabelClient.AutoSize = true;
            this.surnameLabelClient.Location = new System.Drawing.Point(9, 14);
            this.surnameLabelClient.Name = "surnameLabelClient";
            this.surnameLabelClient.Size = new System.Drawing.Size(103, 13);
            this.surnameLabelClient.TabIndex = 31;
            this.surnameLabelClient.Text = "Фамилия клиента:";
            // 
            // deleteTrainingButton
            // 
            this.deleteTrainingButton.Location = new System.Drawing.Point(12, 206);
            this.deleteTrainingButton.Name = "deleteTrainingButton";
            this.deleteTrainingButton.Size = new System.Drawing.Size(252, 23);
            this.deleteTrainingButton.TabIndex = 45;
            this.deleteTrainingButton.Text = "Удалить";
            this.deleteTrainingButton.UseVisualStyleBackColor = true;
            this.deleteTrainingButton.Click += new System.EventHandler(this.deleteTrainingButton_Click);
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(122, 180);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(142, 20);
            this.timePicker.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Время:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(122, 148);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(142, 20);
            this.datePicker.TabIndex = 42;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(9, 148);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 41;
            this.dateLabel.Text = "Дата:";
            // 
            // DeleteClientFromTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 235);
            this.Controls.Add(this.deleteTrainingButton);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.phoneTextBoxCoach);
            this.Controls.Add(this.phoneLabelCoach);
            this.Controls.Add(this.surnameTextBoxCoach);
            this.Controls.Add(this.surnameLabelCoach);
            this.Controls.Add(this.gymTextBox);
            this.Controls.Add(this.gymKeyLabel);
            this.Controls.Add(this.phoneTextBoxClient);
            this.Controls.Add(this.phoneLabelClient);
            this.Controls.Add(this.surnameTextBoxClient);
            this.Controls.Add(this.surnameLabelClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteClientFromTraining";
            this.Text = "Удаление клиента из тренировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox phoneTextBoxCoach;
        private System.Windows.Forms.Label phoneLabelCoach;
        private System.Windows.Forms.TextBox surnameTextBoxCoach;
        private System.Windows.Forms.Label surnameLabelCoach;
        private System.Windows.Forms.TextBox gymTextBox;
        private System.Windows.Forms.Label gymKeyLabel;
        private System.Windows.Forms.TextBox phoneTextBoxClient;
        private System.Windows.Forms.Label phoneLabelClient;
        private System.Windows.Forms.TextBox surnameTextBoxClient;
        private System.Windows.Forms.Label surnameLabelClient;
        private System.Windows.Forms.Button deleteTrainingButton;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLabel;
    }
}
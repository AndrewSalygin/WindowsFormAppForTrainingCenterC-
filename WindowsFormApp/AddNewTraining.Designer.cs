namespace WindowsFormApp
{
    partial class AddNewTraining
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewTraining));
            this.gymKeyLabel = new System.Windows.Forms.Label();
            this.surnameCoachLabel = new System.Windows.Forms.Label();
            this.phoneCoachLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.gymTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.addTrainingButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // gymKeyLabel
            // 
            this.gymKeyLabel.AutoSize = true;
            this.gymKeyLabel.Location = new System.Drawing.Point(13, 20);
            this.gymKeyLabel.Name = "gymKeyLabel";
            this.gymKeyLabel.Size = new System.Drawing.Size(71, 13);
            this.gymKeyLabel.TabIndex = 0;
            this.gymKeyLabel.Text = "Номер зала:";
            // 
            // surnameCoachLabel
            // 
            this.surnameCoachLabel.AutoSize = true;
            this.surnameCoachLabel.Location = new System.Drawing.Point(13, 49);
            this.surnameCoachLabel.Name = "surnameCoachLabel";
            this.surnameCoachLabel.Size = new System.Drawing.Size(103, 13);
            this.surnameCoachLabel.TabIndex = 1;
            this.surnameCoachLabel.Text = "Фамилия тренера:";
            // 
            // phoneCoachLabel
            // 
            this.phoneCoachLabel.AutoSize = true;
            this.phoneCoachLabel.Location = new System.Drawing.Point(13, 77);
            this.phoneCoachLabel.Name = "phoneCoachLabel";
            this.phoneCoachLabel.Size = new System.Drawing.Size(99, 13);
            this.phoneCoachLabel.TabIndex = 2;
            this.phoneCoachLabel.Text = "Телефон тренера:";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(13, 103);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Дата:";
            // 
            // gymTextBox
            // 
            this.gymTextBox.Location = new System.Drawing.Point(126, 17);
            this.gymTextBox.Name = "gymTextBox";
            this.gymTextBox.ShortcutsEnabled = false;
            this.gymTextBox.Size = new System.Drawing.Size(142, 20);
            this.gymTextBox.TabIndex = 5;
            this.gymTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gymTextBox_KeyPress);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(126, 46);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(142, 20);
            this.surnameTextBox.TabIndex = 6;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBox_KeyPress);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(126, 74);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(142, 20);
            this.phoneTextBox.TabIndex = 7;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(126, 103);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(142, 20);
            this.datePicker.TabIndex = 10;
            // 
            // addTrainingButton
            // 
            this.addTrainingButton.Location = new System.Drawing.Point(16, 161);
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.Size = new System.Drawing.Size(252, 23);
            this.addTrainingButton.TabIndex = 11;
            this.addTrainingButton.Text = "Добавить";
            this.addTrainingButton.UseVisualStyleBackColor = true;
            this.addTrainingButton.Click += new System.EventHandler(this.addTrainingButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Время:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(126, 135);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(142, 20);
            this.timePicker.TabIndex = 13;
            // 
            // AddNewTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 194);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addTrainingButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.gymTextBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.phoneCoachLabel);
            this.Controls.Add(this.surnameCoachLabel);
            this.Controls.Add(this.gymKeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewTraining";
            this.Text = "Добавление тренировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gymKeyLabel;
        private System.Windows.Forms.Label surnameCoachLabel;
        private System.Windows.Forms.Label phoneCoachLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox gymTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button addTrainingButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker timePicker;
    }
}
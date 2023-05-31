namespace WindowsFormApp
{
    partial class DeleteTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteTraining));
            this.gymTextBox = new System.Windows.Forms.TextBox();
            this.gymKeyLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteTrainingButton = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gymTextBox
            // 
            this.gymTextBox.Location = new System.Drawing.Point(125, 16);
            this.gymTextBox.Name = "gymTextBox";
            this.gymTextBox.ShortcutsEnabled = false;
            this.gymTextBox.Size = new System.Drawing.Size(142, 20);
            this.gymTextBox.TabIndex = 7;
            this.gymTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gymTextBox_KeyPress);
            // 
            // gymKeyLabel
            // 
            this.gymKeyLabel.AutoSize = true;
            this.gymKeyLabel.Location = new System.Drawing.Point(12, 19);
            this.gymKeyLabel.Name = "gymKeyLabel";
            this.gymKeyLabel.Size = new System.Drawing.Size(71, 13);
            this.gymKeyLabel.TabIndex = 6;
            this.gymKeyLabel.Text = "Номер зала:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(125, 68);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(142, 20);
            this.timePicker.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Время:";
            // 
            // deleteTrainingButton
            // 
            this.deleteTrainingButton.Location = new System.Drawing.Point(15, 94);
            this.deleteTrainingButton.Name = "deleteTrainingButton";
            this.deleteTrainingButton.Size = new System.Drawing.Size(252, 23);
            this.deleteTrainingButton.TabIndex = 16;
            this.deleteTrainingButton.Text = "Удалить";
            this.deleteTrainingButton.UseVisualStyleBackColor = true;
            this.deleteTrainingButton.Click += new System.EventHandler(this.deleteTrainingButton_Click);
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(125, 42);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(142, 20);
            this.datePicker.TabIndex = 15;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 48);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 14;
            this.dateLabel.Text = "Дата:";
            // 
            // DeleteTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 128);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteTrainingButton);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.gymTextBox);
            this.Controls.Add(this.gymKeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeleteTraining";
            this.Text = "Удаление тренировки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gymTextBox;
        private System.Windows.Forms.Label gymKeyLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteTrainingButton;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLabel;
    }
}
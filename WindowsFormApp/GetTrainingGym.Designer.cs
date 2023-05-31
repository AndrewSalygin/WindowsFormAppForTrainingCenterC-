namespace WindowsFormApp {
    partial class GetTrainingGym {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetTrainingGym));
            this.addTrainingButton = new System.Windows.Forms.Button();
            this.gymTextBox = new System.Windows.Forms.TextBox();
            this.gymKeyLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addTrainingButton
            // 
            this.addTrainingButton.Location = new System.Drawing.Point(12, 101);
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.Size = new System.Drawing.Size(255, 23);
            this.addTrainingButton.TabIndex = 13;
            this.addTrainingButton.Text = "Найти";
            this.addTrainingButton.UseVisualStyleBackColor = true;
            this.addTrainingButton.Click += new System.EventHandler(this.addTrainingButton_Click);
            // 
            // gymTextBox
            // 
            this.gymTextBox.Location = new System.Drawing.Point(125, 12);
            this.gymTextBox.Name = "gymTextBox";
            this.gymTextBox.ShortcutsEnabled = false;
            this.gymTextBox.Size = new System.Drawing.Size(142, 20);
            this.gymTextBox.TabIndex = 15;
            this.gymTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gymTextBox_KeyPress);
            // 
            // gymKeyLabel
            // 
            this.gymKeyLabel.AutoSize = true;
            this.gymKeyLabel.Location = new System.Drawing.Point(12, 15);
            this.gymKeyLabel.Name = "gymKeyLabel";
            this.gymKeyLabel.Size = new System.Drawing.Size(71, 13);
            this.gymKeyLabel.TabIndex = 14;
            this.gymKeyLabel.Text = "Номер зала:";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(125, 74);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(142, 20);
            this.timePicker.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Время:";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(125, 42);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(142, 20);
            this.datePicker.TabIndex = 17;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 42);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Дата:";
            // 
            // GetTrainingGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 136);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.gymTextBox);
            this.Controls.Add(this.gymKeyLabel);
            this.Controls.Add(this.addTrainingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GetTrainingGym";
            this.Text = "Найти занятие";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addTrainingButton;
        private System.Windows.Forms.TextBox gymTextBox;
        private System.Windows.Forms.Label gymKeyLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label dateLabel;
    }
}
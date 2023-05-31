namespace WindowsFormApp {
    partial class AddNewGym {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewGym));
            this.gymTextBox = new System.Windows.Forms.TextBox();
            this.gymKeyLabel = new System.Windows.Forms.Label();
            this.labelTypeGym = new System.Windows.Forms.Label();
            this.addTrainingButton = new System.Windows.Forms.Button();
            this.comboBoxTypeGym = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // gymTextBox
            // 
            this.gymTextBox.Location = new System.Drawing.Point(125, 12);
            this.gymTextBox.Name = "gymTextBox";
            this.gymTextBox.ShortcutsEnabled = false;
            this.gymTextBox.Size = new System.Drawing.Size(142, 20);
            this.gymTextBox.TabIndex = 7;
            this.gymTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gymTextBox_KeyPress);
            // 
            // gymKeyLabel
            // 
            this.gymKeyLabel.AutoSize = true;
            this.gymKeyLabel.Location = new System.Drawing.Point(12, 15);
            this.gymKeyLabel.Name = "gymKeyLabel";
            this.gymKeyLabel.Size = new System.Drawing.Size(71, 13);
            this.gymKeyLabel.TabIndex = 6;
            this.gymKeyLabel.Text = "Номер зала:";
            // 
            // labelTypeGym
            // 
            this.labelTypeGym.AutoSize = true;
            this.labelTypeGym.Location = new System.Drawing.Point(12, 41);
            this.labelTypeGym.Name = "labelTypeGym";
            this.labelTypeGym.Size = new System.Drawing.Size(56, 13);
            this.labelTypeGym.TabIndex = 8;
            this.labelTypeGym.Text = "Тип зала:";
            // 
            // addTrainingButton
            // 
            this.addTrainingButton.Location = new System.Drawing.Point(15, 131);
            this.addTrainingButton.Name = "addTrainingButton";
            this.addTrainingButton.Size = new System.Drawing.Size(255, 23);
            this.addTrainingButton.TabIndex = 12;
            this.addTrainingButton.Text = "Добавить";
            this.addTrainingButton.UseVisualStyleBackColor = true;
            this.addTrainingButton.Click += new System.EventHandler(this.addTrainingButton_Click);
            // 
            // comboBoxTypeGym
            // 
            this.comboBoxTypeGym.FormattingEnabled = true;
            this.comboBoxTypeGym.Items.AddRange(new object[] {
            "обычный",
            "кардио",
            "гимнастический",
            "силовой"});
            this.comboBoxTypeGym.Location = new System.Drawing.Point(125, 41);
            this.comboBoxTypeGym.Name = "comboBoxTypeGym";
            this.comboBoxTypeGym.Size = new System.Drawing.Size(142, 21);
            this.comboBoxTypeGym.TabIndex = 14;
            // 
            // AddNewGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 162);
            this.Controls.Add(this.comboBoxTypeGym);
            this.Controls.Add(this.addTrainingButton);
            this.Controls.Add(this.labelTypeGym);
            this.Controls.Add(this.gymTextBox);
            this.Controls.Add(this.gymKeyLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewGym";
            this.Text = "Добавление зала";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gymTextBox;
        private System.Windows.Forms.Label gymKeyLabel;
        private System.Windows.Forms.Label labelTypeGym;
        private System.Windows.Forms.Button addTrainingButton;
        private System.Windows.Forms.ComboBox comboBoxTypeGym;
    }
}
using FitnessCenterConsole.BLL;
using FitnessCenterConsole.DAL;
using FitnessCenterConsole.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormApp {
    public partial class AddNewClient : Form {
        private IProgramLogic _database;
        public AddNewClient(ref IProgramLogic database) {
            InitializeComponent();
            Database = database;
        }
        public IProgramLogic Database { get => _database; set => _database = value; }

        private void addTrainingButton_Click(object sender, EventArgs e) {
            try {
                DateTime date = datePickerBirthday.Value.Date;
                if (phoneTextBox.Text != "" && surnameTextBox.Text != "" && textBoxName.Text != "" 
                    && textBoxMiddleName.Text != "") {
                    Database.AddNewClient(surnameTextBox.Text, textBoxName.Text,
                    textBoxMiddleName.Text, date, phoneTextBox.Text);
                    MessageBox.Show("Клиент успешно добавлен.", "Добавление клиента", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    throw new Exception("Все поля должны быть заполнены.");
                }
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Добавление клиента", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBoxMiddleName_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

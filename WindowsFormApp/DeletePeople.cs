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

namespace WindowsFormApp {
    public partial class DeletePeople : Form {
        private IProgramLogic _database;
        private bool _isClient;

        public DeletePeople(ref IProgramLogic database, bool isClient) {
            InitializeComponent();
            Database = database;
            IsClient = isClient;
        }
        public IProgramLogic Database { get => _database; set => _database = value; }
        public bool IsClient { get => _isClient; set => _isClient = value; }

        private void deleteButton_Click(object sender, EventArgs e) {
            try {
                if (phoneTextBox.Text == "" || surnameTextBox.Text == "") {
                    throw new Exception("Все поля должны быть заполнены.");
                }
                if (phoneTextBox.Text.Length != 11) {
                    throw new Exception("Номер телефона должен состоять из 11 цифр.");
                } 

                if (IsClient) {
                    Database.DeleteClient(surnameTextBox.Text, phoneTextBox.Text);
                } else {
                    Database.DeleteCoach(surnameTextBox.Text, phoneTextBox.Text);
                }

                MessageBox.Show("Информация о человеке удалена.", "Удаление информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Удаление информации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

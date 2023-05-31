using FitnessCenterConsole.BLL;
using FitnessCenterConsole.DAL;
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
    public partial class AddClientToTraining : Form {
        private IProgramLogic _database;
        public AddClientToTraining(ref IProgramLogic database) {
            InitializeComponent();
            Database = database;
        }

        public IProgramLogic Database { get => _database; set => _database = value; }

        private void phoneTextBoxClient_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gymTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void phoneTextBoxCoach_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addTrainingButton_Click(object sender, EventArgs e) {
            try {
                TimeSpan time = timePicker.Value.TimeOfDay;
                DateTime date = datePicker.Value.Date;
                DateTime dateTime = date + time;
                if (phoneTextBoxClient.Text != "" && surnameTextBoxClient.Text != "") {
                    if (gymTextBox.Text != "") {
                        if (phoneTextBoxClient.Text.Length != 11) {
                            throw new Exception("Номер телефона клиента должен состоять из 11 цифр.");
                        }
                        Database.AddClientToTraining(surnameTextBoxClient.Text,
                            phoneTextBoxClient.Text, int.Parse(gymTextBox.Text), dateTime);
                    } else if (phoneTextBoxCoach.Text != "" && surnameTextBoxCoach.Text != "") {
                        if (phoneTextBoxCoach.Text.Length != 11) {
                            throw new Exception("Номер телефона тренера должен состоять из 11 цифр.");
                        }
                        Database.AddClientToTraining(surnameTextBoxClient.Text,
                            phoneTextBoxClient.Text, surnameTextBoxCoach.Text, phoneTextBoxCoach.Text, dateTime);
                    } else {
                        throw new Exception("Должна быть заполнена информация о зале или тренере.");
                    }
                    Close();
                } else {
                    throw new Exception("Должна быть заполнена информация о клиенте.");
                }
                MessageBox.Show("Клиент успешно добавлен в тренировку.", "Добавление клиента в тренировку", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Добавление клиента в тренировку", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void surnameTextBoxClient_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void surnameTextBoxCoach_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

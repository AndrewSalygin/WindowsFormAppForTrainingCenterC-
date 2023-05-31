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
    public partial class FindTrainingPeople : Form {
        private IProgramLogic _database;
        private bool _isClient;
        private string _result;

        public FindTrainingPeople(ref IProgramLogic database, bool isClient) {
            InitializeComponent();
            Database = database;
            IsClient = isClient;
            Result = "";
        }
        public IProgramLogic Database { get => _database; set => _database = value; }
        public bool IsClient { get => _isClient; set => _isClient = value; }
        public string Result { get => _result; set => _result = value; }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void findButton_Click(object sender, EventArgs e) {
            try {
                TimeSpan time = timePicker.Value.TimeOfDay;
                DateTime date = datePicker.Value.Date;
                DateTime dateTime = date + time;
                if (phoneTextBox.Text != "" && surnameTextBox.Text != "") {
                    if (phoneTextBox.Text.Length != 11) {
                        throw new Exception("Номер телефона должен состоять из 11 цифр.");
                    }
                    if (IsClient) {
                        Result = Database.FindTrainingClient(surnameTextBox.Text, phoneTextBox.Text, dateTime);
                    } else {
                        Result = Database.FindTrainingCoach(surnameTextBox.Text, phoneTextBox.Text, dateTime);
                    }
                    if (Result == "Таких записей нет.") {
                        throw new Exception("Таких записей нет.");
                    }
                    Close();
                } else {
                    throw new Exception("Должна быть заполнена вся информация.");
                }
                MessageBox.Show("Информация успешно найдена.", "Поиск информации о тренировке", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Поиск информации о тренировке", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}

using FitnessCenterConsole.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormApp
{
    public partial class AddNewTraining : Form
    {
        private IProgramLogic _database;

        public AddNewTraining(ref IProgramLogic database)
        {
            InitializeComponent();
            Database = database;
        }

        public IProgramLogic Database { get => _database; set => _database = value; }

        private void addTrainingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gymTextBox.Text != "")
                {
                    TimeSpan time = timePicker.Value.TimeOfDay;
                    DateTime date = datePicker.Value.Date;
                    DateTime dateTime = date + time;
                    if (phoneTextBox.Text != "" && surnameTextBox.Text != "")
                    {
                        if (phoneTextBox.Text.Length != 11) {
                            throw new Exception("Номер телефона должен состоять из 11 цифр.");
                        }
                        Database.AddNewTraining(int.Parse(gymTextBox.Text), surnameTextBox.Text,
                        phoneTextBox.Text, dateTime);
                        Close();
                    } else if ((phoneTextBox.Text != "" && surnameTextBox.Text == "") || (phoneTextBox.Text == "" && surnameTextBox.Text != ""))
                    {
                        throw new Exception("Добавьте или уберите информацию о тренере.");
                    } else
                    {
                        Database.AddNewTraining(int.Parse(gymTextBox.Text), dateTime);
                        Close();
                    }
                } else
                {
                    throw new Exception("Введите номер зала");
                }
                MessageBox.Show("Тренировка успешно добавлена.", "Создание тренировки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Добавление тренировки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gymTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void surnameTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

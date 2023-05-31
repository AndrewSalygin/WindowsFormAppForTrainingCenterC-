using FitnessCenterConsole.BLL;
using FitnessCenterConsole.DAL;
using FitnessCenterConsole.Entities;
using System;
using System.Windows.Forms;

namespace WindowsFormApp {
    public partial class AddNewCoach : Form {
        private IProgramLogic _database;
        public AddNewCoach(ref IProgramLogic database) {
            InitializeComponent();
            Database = database;
            comboBoxTypeOfEducation.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeOfEducation.SelectedItem = "отсутствует";
        }

        public IProgramLogic Database { get => _database; set => _database = value; }

        private void textBoxExperience_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addTrainingButton_Click(object sender, EventArgs e) {
            try {
                DateTime date = datePickerBirthday.Value.Date;
                Education tmp = Education.None;
                if (phoneTextBox.Text != "" && surnameTextBox.Text != "" && textBoxName.Text != ""
                    && textBoxMiddleName.Text != "" && textBoxExperience.Text != "") {
                    switch (comboBoxTypeOfEducation.Text) {
                        case "отсутствует": tmp = Education.None; break;
                        case "среднее": tmp = Education.Secondary; break;
                        case "колледж": tmp = Education.College; break;
                        case "высшее": tmp = Education.Higher; break;
                    }
                    Database.AddNewCoach(surnameTextBox.Text, textBoxName.Text,
                    textBoxMiddleName.Text, int.Parse(textBoxExperience.Text), tmp, date, phoneTextBox.Text);
                    MessageBox.Show("Тренер успешно добавлен.", "Добавление тренера", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    throw new Exception("Все поля должны быть заполнены.");
                }
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Добавление тренера", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
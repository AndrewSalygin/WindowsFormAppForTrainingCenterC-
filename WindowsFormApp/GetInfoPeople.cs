using FitnessCenterConsole.BLL;
using FitnessCenterConsole.DAL;
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
    public partial class GetInfoPeople : Form
    {
        private IProgramLogic _database;
        private string _surname;
        private string _phoneNumber;
        private string _result;
        private bool _isClient;

        public GetInfoPeople(ref IProgramLogic database, bool isClient)
        {
            InitializeComponent();
            Database = database;
            Result = "";
            IsClient = isClient;
        }

        public IProgramLogic Database { get => _database; set => _database = value; }
        public string Result { get => _result; set => _result = value; }
        public bool IsClient { get => _isClient; set => _isClient = value; }

        private void findButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (phoneTextBox.Text == "" || surnameTextBox.Text == "") {
                    throw new Exception("Все поля должны быть заполнены.");
                }

                string errorOrValue;
                if (IsClient) {
                    errorOrValue = Database.GetInfoClient(surnameTextBox.Text, phoneTextBox.Text);
                } else {
                    errorOrValue = Database.GetInfoCoach(surnameTextBox.Text, phoneTextBox.Text);
                }

                if (errorOrValue == $"Ошибка: клиента {surnameTextBox.Text} не найдено в базе.") {
                    throw new Exception(errorOrValue);
                } else {
                    Result = errorOrValue;
                }
                MessageBox.Show("Информация успешно найдена.", "Поиск информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Поиск информации", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

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
    public partial class GetTrainingGym : Form {
        private IProgramLogic _database;
        private string _result;
        public GetTrainingGym(ref IProgramLogic database) {
            InitializeComponent();
            Result = "";
            Database = database;
        }

        public IProgramLogic Database { get => _database; set => _database = value; }
        public string Result { get => _result; set => _result = value; }

        private void addTrainingButton_Click(object sender, EventArgs e) {
            try {
                if (gymTextBox.Text != "") {
                    TimeSpan time = timePicker.Value.TimeOfDay;
                    DateTime date = datePicker.Value.Date;
                    DateTime dateTime = date + time;
                    
                    string errorOrValue = Database.FindTrainingGym(int.Parse(gymTextBox.Text), dateTime);
                    if (errorOrValue == "Таких записей нет.") {
                        throw new Exception(errorOrValue);
                    } else {
                        Result = errorOrValue;
                    }
                    MessageBox.Show("Тренировка успешно найдена.", "Поиск тренировки", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                } else {
                    throw new Exception("Введите номер зала");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Поиск тренировки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gymTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

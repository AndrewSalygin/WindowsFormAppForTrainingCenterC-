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
    public partial class AddNewGym : Form {
        private IProgramLogic _database;
        public AddNewGym(ref IProgramLogic database) {
            InitializeComponent();
            Database = database;
            comboBoxTypeGym.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypeGym.SelectedItem = "обычный";
        }

        public IProgramLogic Database { get => _database; set => _database = value; }

        private void addTrainingButton_Click(object sender, EventArgs e) {
            try {
                TypeOfGym tmp = TypeOfGym.Common;
                 if (gymTextBox.Text != "") {
                    switch (comboBoxTypeGym.Text) {
                        case "обычный": tmp = TypeOfGym.Common; break;
                        case "кардио": tmp = TypeOfGym.Сardio; break;
                        case "гимнастический": tmp = TypeOfGym.Gymnastics; break;
                        case "силовой": tmp = TypeOfGym.Strength; break;
                    }
                    Database.AddNewGym(int.Parse(gymTextBox.Text), tmp);
                    Close();                     
                 } else {
                     throw new Exception("Все поля должны быть заполнены.");
                 }
                 MessageBox.Show("Тренировочный зал успешно добавлен.", "Добавление тренировочного зала", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Добавление тренировочного зала", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gymTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

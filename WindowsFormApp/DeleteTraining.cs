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

namespace WindowsFormApp
{
    public partial class DeleteTraining : Form
    {
        private IProgramLogic _database;
        public DeleteTraining(ref IProgramLogic database)
        {
            InitializeComponent();
            Database = database;
        }
        public IProgramLogic Database { get => _database; set => _database = value; }

        private void deleteTrainingButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (gymTextBox.Text != "")
                {
                    TimeSpan time = timePicker.Value.TimeOfDay;
                    DateTime date = datePicker.Value.Date;
                    DateTime dateTime = date + time;
                
                    Database.DeleteTraining(int.Parse(gymTextBox.Text), dateTime);
                    Close();
                } else {
                    throw new Exception("Введите номер зала.");
                }
                MessageBox.Show("Тренировка успешно удалена.", "Удаление тренировки", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Удаление тренировки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gymTextBox_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}

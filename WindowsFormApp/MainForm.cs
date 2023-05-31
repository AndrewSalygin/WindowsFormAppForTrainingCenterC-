using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessCenterConsole.BLL;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FitnessCenterConsole.Common;
using System.IO;
using System.Diagnostics;
using Microsoft.VisualBasic;
using FitnessCenterConsole.DAL;
using static System.Net.Mime.MediaTypeNames;
using FitnessCenterConsole.Entities;

namespace WindowsFormApp
{
    public partial class MainForm : Form
    {
        IProgramLogic database;
        SaveFileDialog sfd;
        OpenFileDialog ofd;
        bool isSchedule;
        bool allClients;
        bool allGyms;
        bool allCoaches;

        public MainForm() {
            InitializeComponent();
            database = DependencyResolver.ProgramLogic;
            messageBoxClients.ScrollBars = ScrollBars.Both;
            messageBoxCoachesTab.ScrollBars = ScrollBars.Both;
            messageBoxSchedule.ScrollBars = ScrollBars.Both;
            messageBoxGym.ScrollBars = ScrollBars.Both;
            sfd = new SaveFileDialog();
            sfd.FileName = "untitled.json";
            sfd.Filter = "Text (*.json)|*.json";
            ofd = new OpenFileDialog();
            ofd.FileName = "untitled.json";
            ofd.Filter = "Text (*.json)|*.json";
            isSchedule = false;
            allClients = false;
            allGyms = false;
            allCoaches = false;
        }
        private void Tabs_SizeChanged(object sender, EventArgs e) {
            messageBoxClients.Size = new Size(ClientRectangle.Width - 30, ClientRectangle.Height - 65);
            messageBoxGym.Size = new Size(ClientRectangle.Width - 30, ClientRectangle.Height - 65);
            messageBoxSchedule.Size = new Size(ClientRectangle.Width - 30, ClientRectangle.Height - 65);
            messageBoxCoachesTab.Size = new Size(ClientRectangle.Width - 30, ClientRectangle.Height - 65);
            tabs.ClientSize = new Size(ClientRectangle.Width - 25, ClientRectangle.Height - 45);
        }
        private void ShowError(string message, string header) {
            MessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void createBase_Click(object sender, EventArgs e) {
            database = DependencyResolver.createNewDatabase();
            messageBoxClients.Text = "";
            messageBoxGym.Text = "";
            messageBoxSchedule.Text = "";
            messageBoxCoachesTab.Text = "";
            MessageBox.Show("База успешно создана.", "Создание базы", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void openBase_Click(object sender, EventArgs e) {
            try {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    database = DependencyResolver.setParameters(ofd.FileName);
                    messageBoxClients.Text = "";
                    messageBoxGym.Text = "";
                    messageBoxSchedule.Text = "";
                    messageBoxCoachesTab.Text = "";
                    MessageBox.Show("База успешно открыта.", "Открытие базы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                ShowError("Файл невозможно открыть", "Открытие базы");
            }
        }

        // сохранить
        private void saveButton_Click(object sender, EventArgs e) {
            try {
                if (ofd.FileName != "untitled.json") {
                    database.saveDatabase(ofd.FileName);
                    MessageBox.Show("База успешно сохранена.", "Сохранение базы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (sfd.FileName == "untitled.json") {
                    saveBase_Click(sender, e);
                } else {
                    database.saveDatabase(sfd.FileName);
                    MessageBox.Show("База успешно сохранена.", "Сохранение базы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                ShowError("Файл невозможно сохранить", "Сохранение базы");
            }
        }

        // сохранить как
        private void saveBase_Click(object sender, EventArgs e) {
            try {
                if (sfd.ShowDialog() == DialogResult.OK) {
                    database.saveDatabase(sfd.FileName);
                    MessageBox.Show("База успешно сохранена.", "Сохранение базы", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    ShowError("Укажите имя файла.", "Сохранение базы");
                }
            } catch (Exception ex) {
                ShowError("Файл невозможно сохранить", "Сохранение базы");  
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            MainForm_FormClosing(sender, e);
        }

        private void MainForm_FormClosing(object sender, EventArgs e) {
            if (MessageBox.Show("Вы хотите сохранить состояние базы?", "Закрыть приложение", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                saveButton_Click(sender, e);
            }
        }

        private void addTraining_Click(object sender, EventArgs e) {
            AddNewTraining form;
            form = new AddNewTraining(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void deleteTraining_Click(object sender, EventArgs e) {
            DeleteTraining form;
            form = new DeleteTraining(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void clearSchedule_Click(object sender, EventArgs e) {
            database.clearSchedule();
            MessageBox.Show("Расписание успешно очищено.", "Очищение расписания", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tabs_SelectedIndexChanged(sender, e);
        }

        private void GetInfoGym_Click(object sender, EventArgs e) {
            try
            {
                string numberString = Interaction.InputBox("Введите номер зала:", "Получение расписания", "Номер зала");
                int number;
                if (numberString == "") {
                    return;
                } else {
                    number = int.Parse(numberString);
                }
                string errorOrValue = database.GetInfoGym(number);

                if (errorOrValue == $"Ошибка: зала номер {number} не найдено в базе.")
                {
                    throw new Exception(errorOrValue);
                } else
                {
                    messageBoxGym.Text = errorOrValue;
                    allGyms = false;
                    MessageBox.Show("Информация успешно найдена.", "Поиск информации", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex)
            {
                ShowError(ex.Message, "Получение расписания");
            }
        }

        private void GetInfoClient_Click(object sender, EventArgs e) {
            GetInfoPeople form;
            form = new GetInfoPeople(ref database, true);
            form.ShowDialog();
            messageBoxClients.Text = form.Result;
            allClients = false;
            tabs_SelectedIndexChanged(sender, e);
        }

        private void GetInfoCoach_Click(object sender, EventArgs e) {
            GetInfoPeople form;
            form = new GetInfoPeople(ref database, false);
            form.ShowDialog();
            messageBoxCoachesTab.Text = form.Result;
            allCoaches = false;
            tabs_SelectedIndexChanged(sender, e);
        }

        private void addNewGym_Click(object sender, EventArgs e) {
            AddNewGym form;
            form = new AddNewGym(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }


        private void deleteGym_Click(object sender, EventArgs e) {
            try {
                string numberString = Interaction.InputBox("Введите номер зала:", "Удаление зала", "Номер зала");
                int number;
                if (numberString == "") {
                    return;
                } else {
                    number = int.Parse(numberString);
                }
                database.DeleteGym(number);
                tabs_SelectedIndexChanged(sender, e);
                MessageBox.Show("Зал успешно удалён.", "Удаление зала", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex) {
                ShowError(ex.Message, "Удаление зала");
            }
        }

        private void getTrainingGym_Click(object sender, EventArgs e) {
            GetTrainingGym form;
            form = new GetTrainingGym(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
            messageBoxSchedule.Text = form.Result;
        }

        private void addNewClient_Click(object sender, EventArgs e) {
            AddNewClient form;
            form = new AddNewClient(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void addNewCoach_Click(object sender, EventArgs e) {
            AddNewCoach form;
            form = new AddNewCoach(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void deleteClient_Click(object sender, EventArgs e) {
            DeletePeople form;
            form = new DeletePeople(ref database, true);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void deleteCoach_Click(object sender, EventArgs e) {
            DeletePeople form;
            form = new DeletePeople(ref database, false);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void addClientToTraining_Click(object sender, EventArgs e) {
            AddClientToTraining form;
            form = new AddClientToTraining(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void deleteClientFromTraining_Click(object sender, EventArgs e) {
            DeleteClientFromTraining form;
            form = new DeleteClientFromTraining(ref database);
            form.ShowDialog();
            tabs_SelectedIndexChanged(sender, e);
        }

        private void findTrainingClient_Click(object sender, EventArgs e) {
            FindTrainingPeople form;
            form = new FindTrainingPeople(ref database, true);
            form.ShowDialog();
            messageBoxSchedule.Text = form.Result;
            tabs_SelectedIndexChanged(sender, e);
        }

        private void getTrainingCoach_Click(object sender, EventArgs e) {
            FindTrainingPeople form;
            form = new FindTrainingPeople(ref database, false);
            form.ShowDialog();
            messageBoxSchedule.Text = form.Result;
            tabs_SelectedIndexChanged(sender, e);
        }

        private void findClientBySurname_Click(object sender, EventArgs e) {
            try {
                string surname = Interaction.InputBox("Введите фамилию клиента:", "Поиск клиента по фамилии", "Фамилия");
                if (surname == "") {
                    return;
                }
                string errorOrValue = database.FindClientsBySurname(surname);

                if (errorOrValue == $"Клиентов с фамилией {surname} в базе не найдено.") {
                    throw new Exception(errorOrValue);
                } else {
                    messageBoxClients.Text = errorOrValue;
                    allClients = false;
                    MessageBox.Show("Информация успешно найдена.", "Поиск клиента по фамилии", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                ShowError(ex.Message, "Поиск клиента по фамилии");
            }
        }

        private void findCoachBySurname_Click(object sender, EventArgs e) {
            try {
                string surname = Interaction.InputBox("Введите фамилию тренера:", "Поиск тренера по фамилии", "Фамилия");
                if (surname == "") {
                    return;
                }
                string errorOrValue = database.FindCoachesBySurname(surname);

                if (errorOrValue == $"Тренеров с фамилией {surname} в базе не найдено.") {
                    throw new Exception(errorOrValue);
                } else {
                    messageBoxCoachesTab.Text = errorOrValue;
                    allCoaches = false;
                    MessageBox.Show("Информация успешно найдена.", "Поиск тренера по фамилии", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                ShowError(ex.Message, "Поиск тренера по фамилии");
            }
        }

        private void findClientByPhone_Click(object sender, EventArgs e) {
            try {
                string phone = Interaction.InputBox("Введите номер телефона клиента:", "Поиск клиента по номеру телефона", "Номер телефона");
                if (phone == "") {
                    return;
                }
                string errorOrValue = database.FindClientsByPhone(phone);

                if (errorOrValue == $"Клиентов с номером телефона {phone} в базе не найдено.") {
                    throw new Exception(errorOrValue);
                } else {
                    messageBoxClients.Text = errorOrValue;
                    allClients = false;
                    MessageBox.Show("Информация успешно найдена.", "Поиск клиента по номеру телефона", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                ShowError(ex.Message, "Поиск клиента по номеру телефона");
            }
        }

        private void findCoachByPhone_Click(object sender, EventArgs e) {
            try {
                string phone = Interaction.InputBox("Введите номер телефона тренера:", "Поиск тренера по номеру телефона", "Номер телефона");
                if (phone == "") {
                    return;
                }
                string errorOrValue = database.FindCoachesByPhone(phone);

                if (errorOrValue == $"Тренеров с номером телефона {phone} в базе не найдено.") {
                    throw new Exception(errorOrValue);
                } else {
                    messageBoxCoachesTab.Text = errorOrValue;
                    allCoaches = false;
                    MessageBox.Show("Информация успешно найдена.", "Поиск тренера по номеру телефона", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } catch (Exception ex) {
                ShowError(ex.Message, "Поиск тренера по номеру телефона");
            }
        }

        private void getAllTrainings_Click(object sender, EventArgs e) {
            string result = database.GetAllTrainings();
            if (result == "Список всех тренировок:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine) {
                ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                return;
            }
            messageBoxSchedule.Text = result;
            isSchedule = true;
            tabs_SelectedIndexChanged(sender, e);
            MessageBox.Show("Информация успешно найдена.", "Вывод всей информации о тренировках", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void getAllGyms_Click(object sender, EventArgs e) {
            string result = database.GetAllGyms();
            if (result == "Список всех залов:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine) {
                ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                return;
            }
            messageBoxGym.Text = result;
            allGyms = true;
            tabs_SelectedIndexChanged(sender, e);
            MessageBox.Show("Информация успешно найдена.", "Вывод всей информации о залах", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void getAllClients_Click(object sender, EventArgs e) {
            string result = database.GetAllClients();
            if (result == "Список всех клиентов:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine) {
                ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                return;
            }
            messageBoxClients.Text = result;
            allClients = true;
            tabs_SelectedIndexChanged(sender, e);
            MessageBox.Show("Информация успешно найдена.", "Вывод всей информации о клиентах", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void getAllCoaches_Click(object sender, EventArgs e) {
            string result = database.GetAllCoaches();
            if (result == "Список всех тренеров:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine) {
                ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                return;
            }
            messageBoxCoachesTab.Text = result;
            allCoaches = true;
            tabs_SelectedIndexChanged(sender, e);
            MessageBox.Show("Информация успешно найдена.", "Вывод всей информации о ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e) {
            switch (tabs.SelectedIndex) {
                case 0: 
                    if (isSchedule) {
                        string result = database.GetAllTrainings();
                        if (result == "Список всех тренировок:" + Environment.NewLine +
                                        "-----------------------" + Environment.NewLine + Environment.NewLine) {
                            ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                            return;
                        }
                        messageBoxSchedule.Text = result;
                    }
                    break;
                case 1:
                    if (allGyms) {
                        string result = database.GetAllGyms();
                        if (result == "Список всех залов:" + Environment.NewLine +
                                        "-----------------------" + Environment.NewLine + Environment.NewLine) {
                            ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                            return;
                        }
                        messageBoxGym.Text = result;
                    }
                    break;
                case 2:
                    if (allClients) {
                        string result = database.GetAllClients();
                        if (result == "Список всех клиентов:" + Environment.NewLine +
                                        "-----------------------" + Environment.NewLine + Environment.NewLine) {
                            ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                            return;
                        }
                        messageBoxClients.Text = result;
                    }
                    break;
                case 3:
                    if (allCoaches) {
                        string result = database.GetAllCoaches();
                        if (result == "Список всех тренеров:" + Environment.NewLine +
                                        "-----------------------" + Environment.NewLine + Environment.NewLine) {
                            ShowError("Информации в базе не найдено.", "Поиск тренера по номеру телефона");
                            return;
                        }
                        messageBoxCoachesTab.Text = result;
                    }
                    break;
            }
        }
    }
}
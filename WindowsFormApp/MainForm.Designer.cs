using System.Windows.Forms;

namespace WindowsFormApp
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabs = new System.Windows.Forms.TabControl();
            this.schedulePage = new System.Windows.Forms.TabPage();
            this.messageBoxSchedule = new System.Windows.Forms.TextBox();
            this.gymsPage = new System.Windows.Forms.TabPage();
            this.messageBoxGym = new System.Windows.Forms.TextBox();
            this.clientsPage = new System.Windows.Forms.TabPage();
            this.messageBoxClients = new System.Windows.Forms.TextBox();
            this.coahesPage = new System.Windows.Forms.TabPage();
            this.messageBoxCoachesTab = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createBase = new System.Windows.Forms.ToolStripMenuItem();
            this.openBase = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBase = new System.Windows.Forms.ToolStripMenuItem();
            this.exit = new System.Windows.Forms.ToolStripMenuItem();
            this.действияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.clearSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllTrainings = new System.Windows.Forms.ToolStripMenuItem();
            this.залыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewGym = new System.Windows.Forms.ToolStripMenuItem();
            this.GetInfoGym = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteGym = new System.Windows.Forms.ToolStripMenuItem();
            this.getTrainingGym = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllGyms = new System.Windows.Forms.ToolStripMenuItem();
            this.клиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClient = new System.Windows.Forms.ToolStripMenuItem();
            this.GetInfoClient = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientFromTraining = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClient = new System.Windows.Forms.ToolStripMenuItem();
            this.findTrainingClient = new System.Windows.Forms.ToolStripMenuItem();
            this.findClient = new System.Windows.Forms.ToolStripMenuItem();
            this.findClientByPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.findClientBySurname = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllClients = new System.Windows.Forms.ToolStripMenuItem();
            this.тренерыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCoach = new System.Windows.Forms.ToolStripMenuItem();
            this.GetInfoCoach = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCoach = new System.Windows.Forms.ToolStripMenuItem();
            this.getTrainingCoach = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиТренераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findCoachByPhone = new System.Windows.Forms.ToolStripMenuItem();
            this.findCoachBySurname = new System.Windows.Forms.ToolStripMenuItem();
            this.getAllCoaches = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ggergToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabs.SuspendLayout();
            this.schedulePage.SuspendLayout();
            this.gymsPage.SuspendLayout();
            this.clientsPage.SuspendLayout();
            this.coahesPage.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.schedulePage);
            this.tabs.Controls.Add(this.gymsPage);
            this.tabs.Controls.Add(this.clientsPage);
            this.tabs.Controls.Add(this.coahesPage);
            this.tabs.Location = new System.Drawing.Point(12, 27);
            this.tabs.Multiline = true;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(776, 411);
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // schedulePage
            // 
            this.schedulePage.Controls.Add(this.messageBoxSchedule);
            this.schedulePage.Location = new System.Drawing.Point(4, 22);
            this.schedulePage.Name = "schedulePage";
            this.schedulePage.Padding = new System.Windows.Forms.Padding(3);
            this.schedulePage.Size = new System.Drawing.Size(768, 385);
            this.schedulePage.TabIndex = 0;
            this.schedulePage.Text = "Расписание";
            this.schedulePage.UseVisualStyleBackColor = true;
            // 
            // messageBoxSchedule
            // 
            this.messageBoxSchedule.AcceptsReturn = true;
            this.messageBoxSchedule.Location = new System.Drawing.Point(0, 0);
            this.messageBoxSchedule.Multiline = true;
            this.messageBoxSchedule.Name = "messageBoxSchedule";
            this.messageBoxSchedule.ReadOnly = true;
            this.messageBoxSchedule.Size = new System.Drawing.Size(768, 385);
            this.messageBoxSchedule.TabIndex = 0;
            // 
            // gymsPage
            // 
            this.gymsPage.Controls.Add(this.messageBoxGym);
            this.gymsPage.Location = new System.Drawing.Point(4, 22);
            this.gymsPage.Name = "gymsPage";
            this.gymsPage.Padding = new System.Windows.Forms.Padding(3);
            this.gymsPage.Size = new System.Drawing.Size(768, 385);
            this.gymsPage.TabIndex = 1;
            this.gymsPage.Text = "Залы";
            this.gymsPage.UseVisualStyleBackColor = true;
            // 
            // messageBoxGym
            // 
            this.messageBoxGym.Location = new System.Drawing.Point(0, 0);
            this.messageBoxGym.Multiline = true;
            this.messageBoxGym.Name = "messageBoxGym";
            this.messageBoxGym.ReadOnly = true;
            this.messageBoxGym.Size = new System.Drawing.Size(768, 385);
            this.messageBoxGym.TabIndex = 0;
            // 
            // clientsPage
            // 
            this.clientsPage.Controls.Add(this.messageBoxClients);
            this.clientsPage.Location = new System.Drawing.Point(4, 22);
            this.clientsPage.Name = "clientsPage";
            this.clientsPage.Size = new System.Drawing.Size(768, 385);
            this.clientsPage.TabIndex = 2;
            this.clientsPage.Text = "Клиенты";
            this.clientsPage.UseVisualStyleBackColor = true;
            // 
            // messageBoxClients
            // 
            this.messageBoxClients.Location = new System.Drawing.Point(0, 0);
            this.messageBoxClients.Multiline = true;
            this.messageBoxClients.Name = "messageBoxClients";
            this.messageBoxClients.ReadOnly = true;
            this.messageBoxClients.Size = new System.Drawing.Size(768, 385);
            this.messageBoxClients.TabIndex = 0;
            // 
            // coahesPage
            // 
            this.coahesPage.Controls.Add(this.messageBoxCoachesTab);
            this.coahesPage.Location = new System.Drawing.Point(4, 22);
            this.coahesPage.Name = "coahesPage";
            this.coahesPage.Size = new System.Drawing.Size(768, 385);
            this.coahesPage.TabIndex = 3;
            this.coahesPage.Text = "Тренеры";
            this.coahesPage.UseVisualStyleBackColor = true;
            // 
            // messageBoxCoachesTab
            // 
            this.messageBoxCoachesTab.Location = new System.Drawing.Point(0, 0);
            this.messageBoxCoachesTab.Multiline = true;
            this.messageBoxCoachesTab.Name = "messageBoxCoachesTab";
            this.messageBoxCoachesTab.ReadOnly = true;
            this.messageBoxCoachesTab.Size = new System.Drawing.Size(768, 385);
            this.messageBoxCoachesTab.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.действияToolStripMenuItem,
            this.залыToolStripMenuItem,
            this.клиентыToolStripMenuItem,
            this.тренерыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createBase,
            this.openBase,
            this.saveButton,
            this.saveBase,
            this.exit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createBase
            // 
            this.createBase.Name = "createBase";
            this.createBase.Size = new System.Drawing.Size(154, 22);
            this.createBase.Text = "Создать базу";
            this.createBase.Click += new System.EventHandler(this.createBase_Click);
            // 
            // openBase
            // 
            this.openBase.Name = "openBase";
            this.openBase.Size = new System.Drawing.Size(154, 22);
            this.openBase.Text = "Открыть базу";
            this.openBase.Click += new System.EventHandler(this.openBase_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 22);
            this.saveButton.Text = "Сохранить";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveBase
            // 
            this.saveBase.Name = "saveBase";
            this.saveBase.Size = new System.Drawing.Size(154, 22);
            this.saveBase.Text = "Сохранить как";
            this.saveBase.Click += new System.EventHandler(this.saveBase_Click);
            // 
            // exit
            // 
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(154, 22);
            this.exit.Text = "Выход";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // действияToolStripMenuItem
            // 
            this.действияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTraining,
            this.deleteTraining,
            this.clearSchedule,
            this.getAllTrainings});
            this.действияToolStripMenuItem.Name = "действияToolStripMenuItem";
            this.действияToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.действияToolStripMenuItem.Text = "Расписание";
            // 
            // addTraining
            // 
            this.addTraining.Name = "addTraining";
            this.addTraining.Size = new System.Drawing.Size(230, 22);
            this.addTraining.Text = "Добавить тренеровку";
            this.addTraining.Click += new System.EventHandler(this.addTraining_Click);
            // 
            // deleteTraining
            // 
            this.deleteTraining.Name = "deleteTraining";
            this.deleteTraining.Size = new System.Drawing.Size(230, 22);
            this.deleteTraining.Text = "Удалить тренеровку";
            this.deleteTraining.Click += new System.EventHandler(this.deleteTraining_Click);
            // 
            // clearSchedule
            // 
            this.clearSchedule.Name = "clearSchedule";
            this.clearSchedule.Size = new System.Drawing.Size(230, 22);
            this.clearSchedule.Text = "Очистить расписание";
            this.clearSchedule.Click += new System.EventHandler(this.clearSchedule_Click);
            // 
            // getAllTrainings
            // 
            this.getAllTrainings.Name = "getAllTrainings";
            this.getAllTrainings.Size = new System.Drawing.Size(230, 22);
            this.getAllTrainings.Text = "Посмотреть все тренировки";
            this.getAllTrainings.Click += new System.EventHandler(this.getAllTrainings_Click);
            // 
            // залыToolStripMenuItem
            // 
            this.залыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewGym,
            this.GetInfoGym,
            this.deleteGym,
            this.getTrainingGym,
            this.getAllGyms});
            this.залыToolStripMenuItem.Name = "залыToolStripMenuItem";
            this.залыToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.залыToolStripMenuItem.Text = "Залы";
            // 
            // addNewGym
            // 
            this.addNewGym.Name = "addNewGym";
            this.addNewGym.Size = new System.Drawing.Size(244, 22);
            this.addNewGym.Text = "Добавить новый зал";
            this.addNewGym.Click += new System.EventHandler(this.addNewGym_Click);
            // 
            // GetInfoGym
            // 
            this.GetInfoGym.Name = "GetInfoGym";
            this.GetInfoGym.Size = new System.Drawing.Size(244, 22);
            this.GetInfoGym.Text = "Получить информацию о зале";
            this.GetInfoGym.Click += new System.EventHandler(this.GetInfoGym_Click);
            // 
            // deleteGym
            // 
            this.deleteGym.Name = "deleteGym";
            this.deleteGym.Size = new System.Drawing.Size(244, 22);
            this.deleteGym.Text = "Удалить зал";
            this.deleteGym.Click += new System.EventHandler(this.deleteGym_Click);
            // 
            // getTrainingGym
            // 
            this.getTrainingGym.Name = "getTrainingGym";
            this.getTrainingGym.Size = new System.Drawing.Size(244, 22);
            this.getTrainingGym.Text = "Найти тренеровку";
            this.getTrainingGym.Click += new System.EventHandler(this.getTrainingGym_Click);
            // 
            // getAllGyms
            // 
            this.getAllGyms.Name = "getAllGyms";
            this.getAllGyms.Size = new System.Drawing.Size(244, 22);
            this.getAllGyms.Text = "Посмотреть все залы";
            this.getAllGyms.Click += new System.EventHandler(this.getAllGyms_Click);
            // 
            // клиентыToolStripMenuItem
            // 
            this.клиентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewClient,
            this.GetInfoClient,
            this.addClientToTraining,
            this.deleteClientFromTraining,
            this.deleteClient,
            this.findTrainingClient,
            this.findClient,
            this.getAllClients});
            this.клиентыToolStripMenuItem.Name = "клиентыToolStripMenuItem";
            this.клиентыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.клиентыToolStripMenuItem.Text = "Клиенты";
            // 
            // addNewClient
            // 
            this.addNewClient.Name = "addNewClient";
            this.addNewClient.Size = new System.Drawing.Size(264, 22);
            this.addNewClient.Text = "Добавить нового клиента";
            this.addNewClient.Click += new System.EventHandler(this.addNewClient_Click);
            // 
            // GetInfoClient
            // 
            this.GetInfoClient.Name = "GetInfoClient";
            this.GetInfoClient.Size = new System.Drawing.Size(264, 22);
            this.GetInfoClient.Text = "Получить информацию о клиенте";
            this.GetInfoClient.Click += new System.EventHandler(this.GetInfoClient_Click);
            // 
            // addClientToTraining
            // 
            this.addClientToTraining.Name = "addClientToTraining";
            this.addClientToTraining.Size = new System.Drawing.Size(264, 22);
            this.addClientToTraining.Text = "Добавить клиента в тренеровку";
            this.addClientToTraining.Click += new System.EventHandler(this.addClientToTraining_Click);
            // 
            // deleteClientFromTraining
            // 
            this.deleteClientFromTraining.Name = "deleteClientFromTraining";
            this.deleteClientFromTraining.Size = new System.Drawing.Size(264, 22);
            this.deleteClientFromTraining.Text = "Удалить клиента из тренеровки";
            this.deleteClientFromTraining.Click += new System.EventHandler(this.deleteClientFromTraining_Click);
            // 
            // deleteClient
            // 
            this.deleteClient.Name = "deleteClient";
            this.deleteClient.Size = new System.Drawing.Size(264, 22);
            this.deleteClient.Text = "Удалить клиента";
            this.deleteClient.Click += new System.EventHandler(this.deleteClient_Click);
            // 
            // findTrainingClient
            // 
            this.findTrainingClient.Name = "findTrainingClient";
            this.findTrainingClient.Size = new System.Drawing.Size(264, 22);
            this.findTrainingClient.Text = "Найти тренеровку";
            this.findTrainingClient.Click += new System.EventHandler(this.findTrainingClient_Click);
            // 
            // findClient
            // 
            this.findClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findClientByPhone,
            this.findClientBySurname});
            this.findClient.Name = "findClient";
            this.findClient.Size = new System.Drawing.Size(264, 22);
            this.findClient.Text = "Найти клиента";
            // 
            // findClientByPhone
            // 
            this.findClientByPhone.Name = "findClientByPhone";
            this.findClientByPhone.Size = new System.Drawing.Size(191, 22);
            this.findClientByPhone.Text = "По номеру телефона";
            this.findClientByPhone.Click += new System.EventHandler(this.findClientByPhone_Click);
            // 
            // findClientBySurname
            // 
            this.findClientBySurname.Name = "findClientBySurname";
            this.findClientBySurname.Size = new System.Drawing.Size(191, 22);
            this.findClientBySurname.Text = "По фамилии";
            this.findClientBySurname.Click += new System.EventHandler(this.findClientBySurname_Click);
            // 
            // getAllClients
            // 
            this.getAllClients.Name = "getAllClients";
            this.getAllClients.Size = new System.Drawing.Size(264, 22);
            this.getAllClients.Text = "Посмотреть всех клиентов";
            this.getAllClients.Click += new System.EventHandler(this.getAllClients_Click);
            // 
            // тренерыToolStripMenuItem
            // 
            this.тренерыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCoach,
            this.GetInfoCoach,
            this.deleteCoach,
            this.getTrainingCoach,
            this.найтиТренераToolStripMenuItem,
            this.getAllCoaches});
            this.тренерыToolStripMenuItem.Name = "тренерыToolStripMenuItem";
            this.тренерыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.тренерыToolStripMenuItem.Text = "Тренеры";
            // 
            // addNewCoach
            // 
            this.addNewCoach.Name = "addNewCoach";
            this.addNewCoach.Size = new System.Drawing.Size(264, 22);
            this.addNewCoach.Text = "Добавить нового тренера";
            this.addNewCoach.Click += new System.EventHandler(this.addNewCoach_Click);
            // 
            // GetInfoCoach
            // 
            this.GetInfoCoach.Name = "GetInfoCoach";
            this.GetInfoCoach.Size = new System.Drawing.Size(264, 22);
            this.GetInfoCoach.Text = "Получить информацию о тренере";
            this.GetInfoCoach.Click += new System.EventHandler(this.GetInfoCoach_Click);
            // 
            // deleteCoach
            // 
            this.deleteCoach.Name = "deleteCoach";
            this.deleteCoach.Size = new System.Drawing.Size(264, 22);
            this.deleteCoach.Text = "Удалить тренера";
            this.deleteCoach.Click += new System.EventHandler(this.deleteCoach_Click);
            // 
            // getTrainingCoach
            // 
            this.getTrainingCoach.Name = "getTrainingCoach";
            this.getTrainingCoach.Size = new System.Drawing.Size(264, 22);
            this.getTrainingCoach.Text = "Найти тренеровку";
            this.getTrainingCoach.Click += new System.EventHandler(this.getTrainingCoach_Click);
            // 
            // найтиТренераToolStripMenuItem
            // 
            this.найтиТренераToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findCoachByPhone,
            this.findCoachBySurname});
            this.найтиТренераToolStripMenuItem.Name = "найтиТренераToolStripMenuItem";
            this.найтиТренераToolStripMenuItem.Size = new System.Drawing.Size(264, 22);
            this.найтиТренераToolStripMenuItem.Text = "Найти тренера";
            // 
            // findCoachByPhone
            // 
            this.findCoachByPhone.Name = "findCoachByPhone";
            this.findCoachByPhone.Size = new System.Drawing.Size(146, 22);
            this.findCoachByPhone.Text = "По телефону";
            this.findCoachByPhone.Click += new System.EventHandler(this.findCoachByPhone_Click);
            // 
            // findCoachBySurname
            // 
            this.findCoachBySurname.Name = "findCoachBySurname";
            this.findCoachBySurname.Size = new System.Drawing.Size(146, 22);
            this.findCoachBySurname.Text = "По фамилии";
            this.findCoachBySurname.Click += new System.EventHandler(this.findCoachBySurname_Click);
            // 
            // getAllCoaches
            // 
            this.getAllCoaches.Name = "getAllCoaches";
            this.getAllCoaches.Size = new System.Drawing.Size(264, 22);
            this.getAllCoaches.Text = "Посмотреть всех тренеров";
            this.getAllCoaches.Click += new System.EventHandler(this.getAllCoaches_Click);
            // 
            // gToolStripMenuItem
            // 
            this.gToolStripMenuItem.Name = "gToolStripMenuItem";
            this.gToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.gToolStripMenuItem.Text = "G";
            // 
            // ggergToolStripMenuItem
            // 
            this.ggergToolStripMenuItem.Name = "ggergToolStripMenuItem";
            this.ggergToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Gym Planner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.SizeChanged += new System.EventHandler(this.Tabs_SizeChanged);
            this.tabs.ResumeLayout(false);
            this.schedulePage.ResumeLayout(false);
            this.schedulePage.PerformLayout();
            this.gymsPage.ResumeLayout(false);
            this.gymsPage.PerformLayout();
            this.clientsPage.ResumeLayout(false);
            this.clientsPage.PerformLayout();
            this.coahesPage.ResumeLayout(false);
            this.coahesPage.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage schedulePage;
        private System.Windows.Forms.TabPage gymsPage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.TabPage clientsPage;
        private System.Windows.Forms.TabPage coahesPage;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ggergToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem действияToolStripMenuItem;
        private ToolStripMenuItem залыToolStripMenuItem;
        private ToolStripMenuItem клиентыToolStripMenuItem;
        private ToolStripMenuItem тренерыToolStripMenuItem;
        private ToolStripMenuItem GetInfoGym;
        private ToolStripMenuItem addNewGym;
        private ToolStripMenuItem addNewClient;
        private ToolStripMenuItem GetInfoClient;
        private ToolStripMenuItem addNewCoach;
        private ToolStripMenuItem deleteGym;
        private ToolStripMenuItem getTrainingGym;
        private ToolStripMenuItem addClientToTraining;
        private ToolStripMenuItem deleteClientFromTraining;
        private ToolStripMenuItem deleteClient;
        private ToolStripMenuItem findTrainingClient;
        private ToolStripMenuItem GetInfoCoach;
        private ToolStripMenuItem deleteCoach;
        private ToolStripMenuItem getTrainingCoach;
        private TextBox messageBoxSchedule;
        private TextBox messageBoxGym;
        private TextBox messageBoxClients;
        private TextBox messageBoxCoachesTab;
        private ToolStripMenuItem createBase;
        private ToolStripMenuItem openBase;
        private ToolStripMenuItem saveBase;
        private ToolStripMenuItem exit;
        private ToolStripMenuItem addTraining;
        private ToolStripMenuItem deleteTraining;
        private ToolStripMenuItem findClient;
        private ToolStripMenuItem findClientByPhone;
        private ToolStripMenuItem findClientBySurname;
        private ToolStripMenuItem найтиТренераToolStripMenuItem;
        private ToolStripMenuItem findCoachByPhone;
        private ToolStripMenuItem findCoachBySurname;
        private ToolStripMenuItem clearSchedule;
        private ToolStripMenuItem getAllTrainings;
        private ToolStripMenuItem getAllGyms;
        private ToolStripMenuItem getAllClients;
        private ToolStripMenuItem getAllCoaches;
        private ToolStripMenuItem saveButton;
    }
}


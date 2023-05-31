using System;
using System.Collections.Generic;
using FitnessCenterConsole.Entities;

namespace FitnessCenterConsole.DAL {
    public interface IDatabase {
        bool AddNewCoach(string surname, string name, string middleName, int experience,
            Education education, DateTime birthday, string phoneNumber);
        bool AddNewClient(string surname, string name, string middleName,
            DateTime birthday, string phoneNumber);
        bool AddNewGym(int numberOfGym, TypeOfGym typeOfGym);
        bool AddClientToTraining(string surnameClient, string phoneNumberClient,
            string surnameCoach, string phoneNumberCoach, DateTime dateTime);
        bool AddClientToTraining(string surnameClient, string phoneNumberClient, 
            int numberOfGym, DateTime dateTime);
        bool DeleteClientFromTraining(string surnameClient, string phoneNumberClient,
            string surnameCoach, string phoneNumberCoach, DateTime dateTime);

        bool DeleteClientFromTraining(string surnameClient, string phoneNumberClient,
            int numberOfGym, DateTime dateTime);
        bool AddNewTraining(int gymKey, string surnameCoach, string phoneNumberCoach,
            HashSet<string> clientKeys, DateTime dateTime);
        bool AddNewTraining(int gymKey, string surnameCoach,
            string phoneNumberCoach, DateTime dateTime);
        bool DeleteTraining(int gymKey, DateTime dateTime);
        string GetInfoCoach(string surname, string phoneNumber);
        string GetInfoGym(int numberOfGym);
        string GetInfoClient(string surname, string phoneNumber);
        bool DeleteCoach(string surname, string phoneNumber);
        bool DeleteClient(string surname, string phoneNumber);
        bool DeleteGym(int numberOfGym);
        string FindTrainingCoach(string surname, string phoneNumber, DateTime dateTime);
        string FindTrainingClient(string surname, string phoneNumber, DateTime dateTime);
        string FindTrainingGym(int numberOfGym, DateTime dateTime);
        bool AddNewTraining(int gymKey, DateTime surnameCoach);
        void clearSchedule();
        string FindCoachesBySurname(string surname);
        string FindCoachesByPhone(string phone);
        string FindClientsBySurname(string surname);
        string FindClientsByPhone(string phone);
        string GetAllTrainings();
        string GetAllClients();

        string GetAllCoaches();

        string GetAllGyms();
        void saveDatabase(string file);
        IDatabase setDatabase(string file);
    }
}

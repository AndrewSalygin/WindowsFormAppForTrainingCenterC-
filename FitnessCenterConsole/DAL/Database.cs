using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using FitnessCenterConsole.BLL;
using FitnessCenterConsole.Common;
using FitnessCenterConsole.ConsolePL;
using FitnessCenterConsole.Entities;

namespace FitnessCenterConsole.DAL {
    internal class Database : IDatabase {
        private Dictionary<string, Coach> _coaches;
        private Dictionary<string, Client> _clients;
        private Dictionary<int, Gym> _gyms;
        private Schedule _schedule;

        public Dictionary<string, Coach> Coaches {
            get => _coaches;
            set => _coaches = value;
        }

        public Dictionary<string, Client> Clients {
            get => _clients;
            set => _clients = value;
        }

        public Dictionary<int, Gym> Gyms {
            get => _gyms;
            set => _gyms = value;
        }

        public Schedule Schedule {
            get => _schedule;
            set => _schedule = value;
        }

        // конструктор для новой базы
        internal Database() {
            _coaches = new Dictionary<string, Coach>();
            _clients = new Dictionary<string, Client>();
            _gyms = new Dictionary<int, Gym>();
            _schedule = new Schedule();
        }

        [JsonConstructor]
        // конструктор для json
        public Database(Dictionary<string, Coach> coaches, Dictionary<string, Client> clients,
            Dictionary<int, Gym> gyms, Schedule schedule) {
            _coaches = coaches;
            _clients = clients;
            _gyms = gyms;
            _schedule = schedule;
        }

        // добавление сущностей
        public bool AddNewCoach(string surname, string name, string middleName, int experience,
            Education education, DateTime birthday, string phoneNumber) {
            Coach temp;
            temp = new Coach(surname, name, middleName, experience, education, birthday,
                phoneNumber);

            try {
                foreach (var coach in Coaches) {
                    if (coach.Key.Split('_')[1] == phoneNumber) {
                        throw new ArgumentException();
                    }
                }
                Coaches.Add(surname + '_' + phoneNumber, temp);
            } catch (ArgumentException ex) {
                throw new Exception($"Ошибка: добавление тренера {surname} с уже существующим номером в базе.");
            }

            return true;
        }

        public bool AddNewClient(string surname, string name, string middleName, DateTime birthday,
            string phoneNumber) {
            Client temp;
            temp = new Client(surname, name, middleName, birthday, phoneNumber);

            try {
                foreach (var client in Clients) {
                    if (client.Key.Split('_')[1] == phoneNumber) {
                        throw new ArgumentException();
                    }
                }
                Clients.Add(surname + '_' + phoneNumber, temp);
            } catch (ArgumentException ex) {
                throw new Exception($"Ошибка: добавление клиента {surname} с уже существующим номером в базе.");
            }

            return true;
        }

        public bool AddNewGym(int numberOfGym, TypeOfGym typeOfGym) {
            Gym temp;
            temp = new Gym(numberOfGym, typeOfGym);

            try {
                Gyms.Add(numberOfGym, temp);
            } catch (ArgumentException ex) {
                throw new Exception($"Ошибка: добавление зала номер {numberOfGym} с уже существующим номером в базе.");
            }

            return true;
        }

        // добавление клиентов в занятие
        public bool AddClientToTraining(string surnameClient, string phoneNumberClient,
            string surnameCoach, string phoneNumberCoach, DateTime dateTime) {
            string searchElementCoach = surnameCoach + "_" + phoneNumberCoach;
            Schedule.Training training = Schedule.GetTrainingCoach(searchElementCoach, dateTime);
            string searchElementClient = surnameClient + "_" + phoneNumberClient;
            // если тренеровка, в которую необходимо добавить клиента существует
            if (training != null) {
                // если пользователь есть в базе
                if (Clients.ContainsKey(searchElementClient)) {
                    if (training.ClientKeys.Contains(searchElementClient)) {
                        throw new WrongValueException($"Ошибка: клиент {surnameClient} уже записан на это занятие");
                    }

                    DateTime smallerBorderTime = dateTime.AddHours(-1);
                    DateTime largeBorderTime = dateTime.AddHours(1);

                    // проверка: клиент не записан на занятие в промежуток времени нового занятия
                    foreach (Schedule.Training localTraining in Schedule.Trainings) {
                        if (training != localTraining) {
                            if (localTraining.ClientKeys.Contains(searchElementClient) &&
                                localTraining.DateTime > smallerBorderTime &&
                                largeBorderTime > localTraining.DateTime) {
                                throw new WrongValueException(
                                    $"Ошибка: клиент {surnameClient} уже записан на другое занятие в это время.");
                            }
                        }
                    }

                    training.ClientKeys.Add(searchElementClient);
                    training.CountOfClients++;
                    return true;
                } else {
                    throw new WrongValueException($"Ошибка: клиент {surnameClient} не найден в базе.");
                }
            } else {
                throw new WrongValueException("Ошибка: данной тренировки не найдено в базе.");
            }
        }

        public bool AddClientToTraining(string surnameClient, string phoneNumberClient, int numberOfGym, DateTime dateTime) {
            Schedule.Training training = Schedule.GetTrainingGym(numberOfGym, dateTime);
            string searchElementClient = surnameClient + "_" + phoneNumberClient;
            // если тренеровка, в которую необходимо добавить клиента существует
            if (training != null) {
                // если пользователь есть в базе
                if (Clients.ContainsKey(searchElementClient)) {
                    if (training.ClientKeys.Contains(searchElementClient)) {
                        throw new WrongValueException($"Ошибка: клиент {surnameClient} уже записан на это занятие");
                    }

                    DateTime smallerBorderTime = dateTime.AddHours(-1);
                    DateTime largeBorderTime = dateTime.AddHours(1);

                    // проверка: клиент не записан на занятие в промежуток времени нового занятия
                    foreach (Schedule.Training localTraining in Schedule.Trainings) {
                        if (training != localTraining) {
                            if (localTraining.ClientKeys.Contains(searchElementClient) &&
                                localTraining.DateTime > smallerBorderTime &&
                                largeBorderTime > localTraining.DateTime) {
                                throw new WrongValueException(
                                    $"Ошибка: клиент {surnameClient} уже записан на другое занятие в это время.");
                            }
                        }
                    }

                    training.ClientKeys.Add(searchElementClient);
                    training.CountOfClients++;
                    return true;
                } else {
                    throw new WrongValueException($"Ошибка: клиент {surnameClient} не найден в базе.");
                }
            } else {
                throw new WrongValueException("Ошибка: данной тренировки не найдено в базе.");
            }
        }

        // удаление клиентов из занятия
        public bool DeleteClientFromTraining(string surnameClient, string phoneNumberClient,
            string surnameCoach, string phoneNumberCoach, DateTime dateTime) {
            string searchElementCoach = surnameCoach + "_" + phoneNumberCoach;
            Schedule.Training training = Schedule.GetTrainingCoach(searchElementCoach, dateTime);
            string searchElementClient = surnameClient + "_" + phoneNumberClient;
            // если тренеровка, в которую необходимо добавить клиента существует
            if (training != null) {
                // если пользователь есть в базе
                if (Clients.ContainsKey(searchElementClient)) {
                    // если выбранная тренировка содержит пользователя
                    if (training.ClientKeys.Contains(searchElementClient)) {
                        training.ClientKeys.Remove(searchElementClient);
                        training.CountOfClients--;
                        return true;
                    }

                    throw new WrongValueException($"Ошибка: клиент {surnameClient} не записан на это занятие");
                } else {
                    throw new WrongValueException($"Ошибка: клиент {surnameClient} не найден в базе.");
                }
            } else {
                throw new WrongValueException("Ошибка: данной тренировки не найдено в базе.");
            }
        }

        public bool DeleteClientFromTraining(string surnameClient, string phoneNumberClient, int numberOfGym, DateTime dateTime) {
            Schedule.Training training = Schedule.GetTrainingGym(numberOfGym, dateTime);
            string searchElementClient = surnameClient + "_" + phoneNumberClient;
            // если тренеровка, в которую необходимо добавить клиента существует
            if (training != null) {
                // если пользователь есть в базе
                if (Clients.ContainsKey(searchElementClient)) {
                    // если выбранная тренировка содержит пользователя
                    if (training.ClientKeys.Contains(searchElementClient)) {
                        training.ClientKeys.Remove(searchElementClient);
                        training.CountOfClients--;
                        return true;
                    }

                    throw new WrongValueException($"Ошибка: клиент {surnameClient} не записан на это занятие");
                } else {
                    throw new WrongValueException($"Ошибка: клиент {surnameClient} не найден в базе.");
                }
            } else {
                throw new WrongValueException("Ошибка: данной тренировки не найдено в базе.");
            }
        }

        // обертка для класса Schedule
        // реализуем полиморфизм, так как информация на этапе планирования расписания может отсутствовать
        public bool AddNewTraining(int gymKey, string surnameCoach, string phoneNumberCoach, HashSet<string> clientKeys,
            DateTime dateTime) {
            string coachKey = surnameCoach + "_" + phoneNumberCoach;
            // если указанный зал существует
            if (GetGymByNumber(gymKey) != null)
            {
                // если указанный тренер существует
                if (GetCoachByKey(coachKey) != null)
                {
                    // если все клиенты в базе существуют
                    foreach (string client in clientKeys)
                    {
                        if (GetClientByKey(client) == null)
                        {
                            throw new WrongValueException(
                                $"Ошибка: клиент {client.Split('_')[0]} не найден в базе.");
                        }
                    }

                    return Schedule.AddTraining(gymKey, coachKey, clientKeys, dateTime);
                }
                throw new WrongValueException($"Ошибка: тренер {coachKey.Split('_')[0]} в базе не найден.");
            }
            throw new WrongValueException($"Ошибка: зал номер {gymKey} в базе не найден.");
        }

        public bool AddNewTraining(int gymKey, string surnameCoach, string phoneNumberCoach, DateTime dateTime) {
            string coachKey = surnameCoach + "_" + phoneNumberCoach;
            if (GetGymByNumber(gymKey) != null) {
                if (GetCoachByKey(coachKey) != null) {
                    return Schedule.AddTraining(gymKey, coachKey, dateTime);
                }
                throw new WrongValueException($"Ошибка: тренер {coachKey.Split('_')[0]} в базе не найден.");
            }
            throw new WrongValueException($"Ошибка: зал номер {gymKey} в базе не найден.");
        }

        public bool AddNewTraining(int gymKey, DateTime dateTime) {
                if (GetGymByNumber(gymKey) != null) {
                    return Schedule.AddTraining(gymKey, dateTime);
                }
                throw new WrongValueException($"Ошибка: зал номер {gymKey} в базе не найден.");
        }

        public bool DeleteTraining(int gymKey, DateTime dateTime) {
            return Schedule.DeleteTraining(gymKey, dateTime);
        }

        // вывод полной информации о сущностях с актуальным
        public string GetInfoCoach(string surname, string phoneNumber) {
            string searchElement = surname + "_" + phoneNumber;
            Coach temp = GetCoachByKey(searchElement);
            Schedule localSchedule = new Schedule(Schedule.GetInfo(temp));
            return temp != null
                ? Environment.NewLine + "Найдено:" +
                  Environment.NewLine + "--------------------" + Environment.NewLine +
                  temp.ToString() +
                  localSchedule.stringScheduleCoach()
                : $"Ошибка: тренера {searchElement.Split('_')[0]} не найдено в базе.";
        }

        public string GetInfoGym(int numberOfGym) {
            Gym temp = GetGymByNumber(numberOfGym);
            Schedule localSchedule = new Schedule(Schedule.GetInfo(temp));
            return temp != null
                ? Environment.NewLine + "Найдено:" + Environment.NewLine +
                  "--------------------" + Environment.NewLine +
                  temp.ToString() +
                  localSchedule.ToString()
                : $"Ошибка: зала номер {numberOfGym} не найдено в базе.";
        }

        public string GetInfoClient(string surname, string phoneNumber) {
            string searchElement = surname + "_" + phoneNumber;
            Client temp = GetClientByKey(searchElement);
            Schedule localSchedule = new Schedule(Schedule.GetInfo(temp));
            return temp != null
                ? Environment.NewLine + "Найдено:" +
                  Environment.NewLine + "--------------------" + Environment.NewLine +
                  temp.ToString() +
                  localSchedule.stringScheduleClient()
                : $"Ошибка: клиента {searchElement.Split('_')[0]} не найдено в базе.";
        }

        // получение экземпляра класса
        private Client GetClientByKey(string searchElement) {
            // получает null, если не найден
            Client result;
            Clients.TryGetValue(searchElement, out result);
            return result;
        }

        private Coach GetCoachByKey(string searchElement) {
            Coach result;
            Coaches.TryGetValue(searchElement, out result);
            return result;
        }

        private Gym GetGymByNumber(int number) {
            Gym result;
            Gyms.TryGetValue(number, out result);
            return result;
        }

        // удаление сущностей
        public bool DeleteCoach(string surname, string phoneNumber) {
            string temp = surname + "_" + phoneNumber;
            if (!Coaches.Remove(temp)) {
                throw new WrongValueException($"Ошибка: тренера {temp.Split('_')[0]} не найдено в базе.");
            }

            return true;
        }

        public bool DeleteClient(string surname, string phoneNumber) {
            string temp = surname + "_" + phoneNumber;
            bool client = Clients.ContainsKey(temp);
            if (!Clients.Remove(temp)) {
                throw new WrongValueException($"Ошибка: клиента {temp.Split('_')[0]} не найдено в базе.");
            }

            return true;
        }

        public bool DeleteGym(int numberOfGym) {
            if (!Gyms.Remove(numberOfGym)) {
                throw new WrongValueException($"Ошибка: зала номер {numberOfGym} не найдено в базе.");
            }

            return true;
        }

        // поиск по дате и времени для клиента/тренера, занятость зала
        public string FindTrainingCoach(string surname, string phoneNumber, DateTime dateTime) {
            string searchElement = surname + "_" + phoneNumber;
            Schedule.Training training = Schedule.GetTrainingCoach(searchElement, dateTime);
            if (training != null) {
                return training.stringForCoach();
            }

            return "Таких записей нет.";
        }

        public string FindTrainingClient(string surname, string phoneNumber, DateTime dateTime) {
            string searchElement = surname + "_" + phoneNumber;
            Schedule.Training training = Schedule.GetTrainingClient(searchElement, dateTime);
            if (training != null) {
                return training.stringForClient();
            }

            return "Таких записей нет.";
        }

        public string FindTrainingGym(int numberOfGym, DateTime dateTime) {
            Schedule.Training training = Schedule.GetTrainingGym(numberOfGym, dateTime);
            if (training != null) {
                return training.ToString();
            }

            return "Таких записей нет.";
        }

        public void clearSchedule() {
            Schedule = new Schedule();
        }

        private List<Client> GetClientsBySurname(string surname) {
            List<Client> clients = new List<Client>();
            
            foreach (var client in Clients) {
                if (client.Key.Split('_')[0] == surname) {
                    clients.Add(client.Value);
                }
            }
            
            return clients;
        }

        private List<Client> GetClientsByPhone(string phone) {
            List<Client> clients = new List<Client>();

            foreach (var client in Clients) {
                if (client.Key.Split('_')[1] == phone) {
                    clients.Add(client.Value);
                }
            }

            return clients;
        }

        private List<Coach> GetCoachesBySurname(string surname) {
            List<Coach> coaches = new List<Coach>();

            foreach (var coach in Coaches) {
                if (coach.Key.Split('_')[0] == surname) {
                    coaches.Add(coach.Value);
                }
            }
            
            return coaches;
        }

        private List<Coach> GetCoachesByPhone(string phone) {
            List<Coach> coaches = new List<Coach>();

            foreach (var coach in Coaches) {
                if (coach.Key.Split('_')[1] == phone) {
                    coaches.Add(coach.Value);
                }
            }

            return coaches;
        }

        public string FindCoachesBySurname(string surname) {
            List<Coach> coaches = GetCoachesBySurname(surname);
            if (coaches.Count == 0) {
                throw new Exception($"Тренеров с фамилией {surname} в базе не найдено.");
            }

            string result = $"Найденные тренеры с фамилией {surname}:" + Environment.NewLine +
                            "----------------------------" + Environment.NewLine;

            foreach (Coach coach in coaches) {
                result += coach.Name + ' ' + coach.MiddleName + ' ' + coach.PhoneNumber;
            } 
            
            return result;
        }

        public string FindCoachesByPhone(string phone) {
            List<Coach> coaches = GetCoachesByPhone(phone);
            if (coaches.Count == 0) {
                throw new Exception($"Тренеров с номером {phone} в базе не найдено.");
            }

            string result = $"Найденные тренеры с номером {phone}:" + Environment.NewLine +
                            "----------------------------" + Environment.NewLine;

            foreach (Coach coach in coaches) {
                result += coach.Name + ' ' + coach.MiddleName + ' ' + coach.PhoneNumber;
            }

            return result;
        }

        public string FindClientsBySurname(string surname) {
            List<Client> clients = GetClientsBySurname(surname);
            if (clients.Count == 0) {
                throw new Exception($"Клиентов с фамилией {surname} в базе не найдено.");
            }

            string result = $"Найденные клиенты с фамилией {surname}:" + Environment.NewLine +
                            "----------------------------" + Environment.NewLine;

            foreach (Client client in clients) {
                result += client.Name + ' ' + client.MiddleName + ' ' + client.PhoneNumber + Environment.NewLine;
            }

            return result;
        }

        public string FindClientsByPhone(string phone) {
            List<Client> clients = GetClientsByPhone(phone);
            if (clients.Count == 0) {
                throw new Exception($"Клиентов с номером {phone} в базе не найдено.");
            }

            string result = $"Найденные клиенты с номером {phone}:" + Environment.NewLine +
                            "----------------------------" + Environment.NewLine;

            foreach (Client client in clients) {
                result += client.Name + ' ' + client.MiddleName + ' ' + client.PhoneNumber + Environment.NewLine;
            }

            return result;
        }

        public string GetAllTrainings() {
            string result = "Список всех тренировок:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine;
            foreach (Schedule.Training training in Schedule.Trainings) {
                result += training + Environment.NewLine;
            }
            
            return result;
        }

        public string GetAllClients() {
            string result = "Список всех клиентов:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine;
            foreach (var client in Clients) {
                result += client.Value + Environment.NewLine;
            }

            return result;
        }

        public string GetAllCoaches() {
            string result = "Список всех тренеров:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine;
            foreach (var coach in Coaches) {
                result += coach.Value + Environment.NewLine;
            }

            return result;
        }

        public string GetAllGyms() {
            string result = "Список всех залов:" + Environment.NewLine +
                            "-----------------------" + Environment.NewLine + Environment.NewLine;
            foreach (var gym in Gyms) {
                result += gym.Value + Environment.NewLine;
            }

            return result;
        }

        public void saveDatabase(string file) {
            using (FileStream fs = new FileStream($"{file}", FileMode.Create)) {
                JsonSerializer.SerializeAsync<Database>(fs, this).Wait();
            }
        }

        public IDatabase setDatabase(string file) {
            try {
                return JsonFileReader.Read<Database>($"{file}");
            } catch (Exception ex) {
                throw new Exception("Файл невозможно открыть.");
            }
        }
    }
}
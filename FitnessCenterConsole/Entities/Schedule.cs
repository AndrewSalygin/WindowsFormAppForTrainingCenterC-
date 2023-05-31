using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using FitnessCenterConsole.Common;

namespace FitnessCenterConsole.Entities {
    public class Schedule {
        public class Training : IComparable<Training> {
            private DateTime _dateTime;
            private int _gymKey;
            private string _coachKey;
            private HashSet<string> _clientKeys;
            private int _countOfClients;

            [JsonConstructor]
            public Training(int gymKey, DateTime dateTime, string coachKey = null, HashSet<string> clientKeys = null) {
                DateTime = dateTime;
                GymKey = gymKey;
                if (coachKey == null) {
                    CoachKey = "отсутствует" + '_' + "отсутствует";
                } else {
                    CoachKey = coachKey;
                }
                
                if (clientKeys != null) {
                    if (clientKeys.Count <= 0)
                        throw new WrongValueException("Ошибка: количество клиентов должно быть больше 0.");
                    else
                        CountOfClients = clientKeys.Count();
                    ClientKeys = clientKeys;
                } else {
                    ClientKeys = new HashSet<string>();
                }
            }

            public override string ToString() {
                string result = Environment.NewLine + "--------------------" + Environment.NewLine +
                                $"Дата: {DateTime.ToShortDateString()}" + Environment.NewLine +
                                $"Время: {DateTime.ToLongTimeString()}" + Environment.NewLine +
                                $"Тренер: {CoachKey.Split('_')[0]}" + Environment.NewLine +
                                $"Номер зала: {GymKey}" + Environment.NewLine +
                                $"Количество клиентов: {CountOfClients}" + Environment.NewLine + Environment.NewLine +
                                $"Клиенты:" + Environment.NewLine;
                foreach (string client in ClientKeys) {
                    result += $"{client.Split('_')[0]}" + Environment.NewLine;
                }
                result += "--------------------" + Environment.NewLine + Environment.NewLine;
                return result;
            }

            public string stringForClient() {
                string result = Environment.NewLine + "--------------------" + Environment.NewLine +
                                $"Дата: {DateTime.ToShortDateString()}" + Environment.NewLine +
                                $"Время: {DateTime.ToLongTimeString()}" + Environment.NewLine +
                                $"Номер зала: {GymKey}" + Environment.NewLine +
                                $"Тренер: {CoachKey.Split('_')[0]}" + Environment.NewLine;
                result += "--------------------" + Environment.NewLine + Environment.NewLine;
                return result;
            }

            public string stringForCoach() {
                string result = Environment.NewLine + "--------------------" + Environment.NewLine +
                                $"Дата: {DateTime.ToShortDateString()}" + Environment.NewLine +
                                $"Время: {DateTime.ToLongTimeString()}" + Environment.NewLine +
                                $"Номер зала: {GymKey}" + Environment.NewLine +
                                $"Количество клиентов: {CountOfClients}" + Environment.NewLine + Environment.NewLine +
                                $"Клиенты:" + Environment.NewLine;
                foreach (string client in ClientKeys) {
                    result += $"{client.Split('_')[0]}" + Environment.NewLine;
                }
                result += "--------------------" + Environment.NewLine + Environment.NewLine;
                return result;
            }

            public int CompareTo(Training training) {
                return DateTime.CompareTo(training.DateTime);
            }

            public DateTime DateTime { get => _dateTime; set => _dateTime = value; }
            public int GymKey { get => _gymKey; set => _gymKey = value; }
            public string CoachKey { get => _coachKey; set => _coachKey = value; }
            public HashSet<string> ClientKeys { get => _clientKeys; set => _clientKeys = value; }
            public int CountOfClients { get => _countOfClients; set => _countOfClients = value; }
        }

        private SortedSet<Training> _trainings;

        public SortedSet<Training> Trainings { get => _trainings; set => _trainings = value; }

        internal Schedule() {
            Trainings = new SortedSet<Training>();
        }

        [JsonConstructor]
        public Schedule(SortedSet<Training> trainings) {

            Trainings = trainings;
        }

        public override string ToString() {
            string result = Environment.NewLine + "Расписание занятий:" + Environment.NewLine + Environment.NewLine;

            int count = 1;
            foreach (Training elem in Trainings) {
                result += $"Запись номер {count}: " + elem.ToString();
                count++;
            }
            return result;
        }

        public string stringScheduleClient() {
            string result = Environment.NewLine + "Расписание занятий:" + Environment.NewLine + Environment.NewLine;

            int count = 1;
            foreach (Training elem in Trainings) {
                result += $"Запись номер {count}: " + Environment.NewLine + elem.stringForClient();
                count++;
            }
            return result;
        }

        public string stringScheduleCoach() {
            string result = Environment.NewLine + "Расписание занятий:" + Environment.NewLine + Environment.NewLine;

            int count = 1;
            foreach (Training elem in Trainings) {
                result += $"Запись номер {count}: " + Environment.NewLine + elem.stringForCoach();
                count++;
            }
            return result;
        }
        
        internal bool AddTraining(int gymKey, string coachKey, HashSet<string> clientKeys, DateTime dateTime) {
            Training temp;
            DateTime largeBorderTime = dateTime.AddHours(1);
            DateTime smallerBorderTime;
            try {
                smallerBorderTime = dateTime.AddHours(-1);
            } catch (ArgumentOutOfRangeException ex) {
                throw new Exception("Ошибка: указано невозможное время.");
            }
            
            // проверка условий для новой тренировки
            foreach (Training training in Trainings) {
                if (smallerBorderTime < training.DateTime && training.DateTime < largeBorderTime) {
                    if (training.CoachKey.Split('_')[1] == coachKey.Split('_')[1]) {
                        throw new WrongValueException($"Ошибка: тренер {coachKey.Split('_')[0]} уже проводит тренеровку в данное время.");
                    }
                    if (gymKey == training.GymKey) {
                        throw new WrongValueException($"Ошибка: зал номер {gymKey} уже занят в данное время.");
                    }
                    foreach (string client in clientKeys) {
                        if (training.ClientKeys.Contains(client)) {
                            throw new WrongValueException($"Ошибка: клиент {client.Split('_')[0]} уже записан на другую тренировку в это время.");
                        }
                    }
                }
            }
            temp = new Training(gymKey, dateTime, coachKey, clientKeys);

            Trainings.Add(temp);
            return true;
        }

        internal bool AddTraining(int gymKey, string coachKey, DateTime dateTime) {
            Training temp;
            DateTime largeBorderTime = dateTime.AddHours(1);
            DateTime smallerBorderTime;
            try {
                smallerBorderTime = dateTime.AddHours(-1);
            } catch (ArgumentOutOfRangeException ex) {
                throw new Exception("Ошибка: указано невозможное время.");
            }

            // проверка условий для новой тренировки
            foreach (Training training in Trainings) {
                if (smallerBorderTime < training.DateTime && training.DateTime < largeBorderTime) {
                    if (training.CoachKey.Split('_')[1] == coachKey.Split('_')[1]) {
                        throw new WrongValueException($"Ошибка: тренер {coachKey.Split('_')[0]} уже проводит тренеровку в данное время.");
                    }
                    if (gymKey == training.GymKey) {
                        throw new WrongValueException($"Ошибка: зал номер {gymKey} уже занят в данное время.");
                    }
                }
            }
            temp = new Training(gymKey, dateTime, coachKey);

            Trainings.Add(temp);
            return true;
        }

        internal bool AddTraining(int gymKey, DateTime dateTime) {
            Training temp;
            DateTime largeBorderTime = dateTime.AddHours(1);
            DateTime smallerBorderTime;
            try {
                smallerBorderTime = dateTime.AddHours(-1);
            } catch (ArgumentOutOfRangeException ex) {
                throw new Exception("Ошибка: указано невозможное время.");
            }

            // проверка условий для новой тренировки
            foreach (Training training in Trainings) {
                if (smallerBorderTime < training.DateTime && training.DateTime < largeBorderTime) {
                    if (gymKey == training.GymKey) {
                        throw new WrongValueException($"Ошибка: зал номер {gymKey} уже занят в данное время.");
                    }
                }
            }
            temp = new Training(gymKey, dateTime);

            Trainings.Add(temp);
            return true;
        }

        internal bool DeleteTraining(int gymKey, DateTime dateTime) {
            Training temp = GetTrainingGym(gymKey, dateTime);
            if (temp != null) {
                Trainings.Remove(temp);
            } else {
                throw new WrongValueException($"Ошибка: тренировки в зале номер {gymKey} в это время не найдено в базе.");
            }
            return true;
        }

        internal Training GetTrainingCoach(string searchElement, DateTime dateTime) {
            return Trainings.FirstOrDefault(x => x.CoachKey.Equals(searchElement) &&
                                            x.DateTime <= dateTime &&
                                            x.DateTime.AddHours(1) >= dateTime);
        }

        internal Training GetTrainingClient(string searchElement, DateTime dateTime) {
            foreach (Training training in Trainings) {
                foreach (string client in training.ClientKeys) {
                    if (searchElement.Split('_')[1] == client.Split('_')[1] &&
                        dateTime >= training.DateTime &&
                        dateTime <= training.DateTime.AddHours(1)) {
                        return training;
                    }
                }
            }
            return null;
        }

        internal Training GetTrainingGym(int number, DateTime dateTime) {
            return Trainings.FirstOrDefault(x => x.GymKey.Equals(number) &&
                                            x.DateTime <= dateTime &&
                                            x.DateTime.AddHours(1) >= dateTime);
        }


        // реализация просмотра интересущих нас занятий для каждого типа пользователя

        // для клиента
        internal SortedSet<Training> GetInfo(Client client) {
            if (client != null) {
                SortedSet<Training> trainings = new SortedSet<Training>();
                foreach (Training training in Trainings) {
                    if (training.ClientKeys.Contains(client.Surname + '_' + client.PhoneNumber)) {
                        trainings.Add(training);
                    }
                }
                return trainings;
            }
            return null;
        }

        // для администратора
        internal SortedSet<Training> GetInfo(Gym gym) {
            if (gym != null) {
                SortedSet<Training> trainings = new SortedSet<Training>();
                foreach (Training training in Trainings) {
                    if (training.GymKey == gym.NumberOfGym) {
                        trainings.Add(training);
                    }
                }
                return trainings;
            }
            return null;
        }

        // для тренера
        internal SortedSet<Training> GetInfo(Coach coach) {
            if (coach != null) {
                SortedSet<Training> trainings = new SortedSet<Training>();
                foreach (Training training in Trainings) {
                    if (training.CoachKey.Split('_')[1] == coach.PhoneNumber) {
                        trainings.Add(training);
                    }
                }
                return trainings;
            }
            return null;
        }
    }
}

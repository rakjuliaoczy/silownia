using Silownia.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Silownia.Models
{


    //była próba seeda ale nie udało się dokończyć, tak samo z rejestracja, mial byc osobny przycisk w menu ale zakomentowany zostal, bo niedokonczone
    public class DataSeed
    {
        private DatabaseContext db;

        public DataSeed(DatabaseContext db)
        {
            this.db = db;
        }

        public void Seed()
        {
            if(!db.Clients.Any())
            {
                var clients = new List<Client>()
                {
                    new Client()
                    {
                        ClientId = 8,
                        Name = "Kacper",
                        Surname = "Kos",
                        Email = "kos@interia.pl",
                        PhoneNumber = 457283983
                    },
                     new Client()
                    {
                        ClientId = 9,
                        Name = "Dorota",
                        Surname = "Kosianka",
                        Email = "kosianka@interia.pl",
                        PhoneNumber = 234928374
                    },
                      new Client()
                    {
                        ClientId = 10,
                        Name = "Michał",
                        Surname = "Walek",
                        Email = "walek@interia.pl",
                        PhoneNumber = 349837289
                    }
                };
                db.Clients.AddRange(clients);
                db.SaveChanges();
            }

            if (!db.Gyms.Any())
            {
                var gyms = new List<Gym>()
                {
                    new Gym()
                    {
                        GymId = 1,
                        GymName = GymName.Monkeys,
                        Adress = " Sieprawskiego 20"
                    },
                    new Gym()
                    {
                        GymId = 2,
                        GymName = GymName.ThePowerest,
                        Adress = " Wadowicka 10"
                    },
                    new Gym()
                    {
                        GymId = 3,
                        GymName = GymName.Manilla,
                        Adress = " Długa 6"
                    },
                      new Gym()
                    {
                        GymId = 5,
                        GymName = GymName.Monkeys,
                        Adress = " Wesoła 4"
                    }
                };
                db.Gyms.AddRange(gyms);
                db.SaveChanges();
            }

            if (!db.Classes.Any())
            {
                var classes = new List<Class>()
                {
                    new Class()
                    {
                        ClassId = 3,
                        ClassType = ClassType.Pilates,
                        Coach = "Dominika Węgorz",
                        Price = 100,
                        Duration = 75,
                        ClientId = 3
                    },
                     new Class()
                    {
                        ClassId = 4,
                        ClassType = ClassType.Trampoliny,
                        Coach = "Monika Las",
                        Price = 100,
                        Duration = 75
                    },
                      new Class()
                    {
                        ClassId = 5,
                        ClassType = ClassType.Zumba,
                        Coach = "Katarzyna Nyska",
                        Price = 70,
                        Duration = 60
                    },
                       new Class()
                    {
                        ClassId = 6,
                        ClassType = ClassType.Sztangi,
                        Coach = "Dawid Boniek",
                        Price = 100,
                        Duration = 60
                    },
                        new Class()
                    {
                        ClassId = 7,
                        ClassType = ClassType.Twerk,
                        Coach = "Weronika Maniok",
                        Price = 90,
                        Duration = 75
                    }
                };
                db.Classes.AddRange(classes);
                db.SaveChanges();
            }

            if (!db.Schedules.Any())
            {
                var schedules = new List<Schedule>()
                {
                    new Schedule()
                    {
                        ScheduleId = 4,
                        DateStart = new DateTime(2022, 07, 14, 10, 0, 0),
                        DateFinish = new DateTime(2022, 07, 14, 11, 15, 0),
                        ClassId = 3
                    },
                     new Schedule()
                    {
                        ScheduleId = 5,
                        DateStart = new DateTime(2022, 07, 11, 11, 0, 0),
                        DateFinish = new DateTime(2022, 07, 11, 12, 15, 0),
                        ClassId = 4
                    },
                      new Schedule()
                    {
                        ScheduleId = 6,
                        DateStart = new DateTime(2022, 06, 15, 18, 0, 0),
                        DateFinish = new DateTime(2022, 06, 15, 19, 0, 0),
                        ClassId = 5
                    },
                       new Schedule()
                    {
                        ScheduleId = 7,
                        DateStart = new DateTime(2022, 07, 12, 17, 0, 0),
                        DateFinish = new DateTime(2022, 07, 12, 18, 0, 0),
                        ClassId = 6
                    },
                        new Schedule()
                    {
                        ScheduleId = 8,
                        DateStart = new DateTime(2022, 08, 10, 18, 0, 0),
                        DateFinish = new DateTime(2022, 08, 10, 19, 15, 0),
                        ClassId = 7
                    },
                };
            }
        }
    }
}
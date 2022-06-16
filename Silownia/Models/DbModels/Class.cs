using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Silownia.Models.DbModels
{
    public class Class
    {
        public int ClassId { get; set; }
        public ClassType ClassType { get; set; }
        public string Coach { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }
        public List<Schedule> Schedules = new List<Schedule>();
        public Class() { }

        public Class(int classId, ClassType classType, string coach, int price, int duration, List<Schedule> schedules)
        {
            ClassId = classId;
            ClassType = classType;
            Coach = coach;
            Price = price;
            Duration = duration;
            Schedules = schedules;
        }

        //EF
        public int? ClientId { get; set; }
        public virtual Client Client { get; set; }

        


    }
    public enum ClassType { Yoga, Pilates, Tabata, Zumba, Sztangi, Twerk, Trampoliny }
}
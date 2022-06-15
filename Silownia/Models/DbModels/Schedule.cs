using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Silownia.Models.DbModels
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public Schedule() { }
        public Schedule(int scheduleId, DateTime dateStart, DateTime dateFinish)
        {
            ScheduleId = scheduleId;
            DateStart = dateStart;
            DateFinish = dateFinish;
        }
        public int? ClassId { get; set; }
        public virtual Class Class { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Silownia.Models.DbModels
{
    public class Gym
    {
        public int GymId { get; set; }
        public GymName GymName { get; set; }
        public string Adress { get; set; }
        public Gym() { }

        public Gym(int gymId, GymName gymName, string adress)
        {
            this.GymId = gymId;
            this.GymName = gymName;
            this.Adress = adress;
        }
    }

    public enum GymName { BeFit, SuperSport }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Silownia.Models.DbModels
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public List<Class> Classes { get; set; } = new List<Class>();
        public Client() { }

        public Client(int clientId, string name, string surname, string email, int phoneNumber, List<Class> classes)
        {
            ClientId = clientId;
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
            Classes = classes;
        }
        public int? GymId { get; set; }
        public virtual Gym Gym { get; set; }
    }
}
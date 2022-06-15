using Silownia.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Silownia.Models.Views
{
    public class GymClient
    {
        public int ClientId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Adress { get; set; }
        public GymClient() { }

        public GymClient(int clientId, string name, string surname, string email, int phoneNumber)
        {
            ClientId = clientId;
            Name = name;
            Surname = surname;
            Email = email;
            PhoneNumber = phoneNumber;
        }
    }
}
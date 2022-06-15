using Silownia.Models.DbModels;
using System.Data.Entity;

namespace Silownia.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("SilowniaConnectionString") { }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Gym> Gyms { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using PetShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Data
{
    public class DBContext : DbContext
    {
        private string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=PetShopDB;Trusted_Connection=True";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public DbSet<Animal> Animali { get; set; }
        public DbSet<Client> Clienti { get; set; }
        public DbSet<Angajat> Angajati { get; set; }
    }
}

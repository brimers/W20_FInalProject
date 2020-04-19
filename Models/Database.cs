using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FinalProject_StephenBrimer.Models
{
    public class Database : DbContext
    
    {

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Integrated Security=SSPI;Persist Security Info= False;Initial Catalog=DocAuto;
                Data Source=DESKTOP-7082PM8\STEPHENBRIMERSQL");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookingApplication
{
    class DBContext : DbContext
    {
        public DbSet<Accommodation> Accomodations { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DBContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookingDataBase;Trusted_Connection=True;");
        }
    }
}

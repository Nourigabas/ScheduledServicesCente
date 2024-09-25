using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatabaseContext:DbContext
    {
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ServiceOwner> OwnerServices { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<PlatformManagers> PlatformManagers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("YourConnectionStringHere");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Reservation)
                .WithOne(r => r.Appointment)
                .HasForeignKey<Reservation>(r => r.AppointmentId); 

            base.OnModelCreating(modelBuilder);
        }
    }
    
}

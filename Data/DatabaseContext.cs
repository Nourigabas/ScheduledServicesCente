using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions) : base(dbContextOptions) { }
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
                optionsBuilder.UseSqlServer("ScheduledServicesCenteDBConnection");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>()
                        .HasOne(a => a.Reservation)
                        .WithOne(r => r.Appointment)
                        .HasForeignKey<Reservation>(r => r.AppointmentId);
            modelBuilder.Entity<Service>()
                        .HasOne(s => s.ServiceOwner)
                        .WithMany(o => o.Services)
                        .HasForeignKey(s => s.ServiceOwnerId)
                        .OnDelete(DeleteBehavior.NoAction);
            modelBuilder.Entity<Service>()
                        .HasOne(s => s.Sector)
                        .WithMany(sector => sector.Services)
                        .HasForeignKey(s => s.SectorId)
                        .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Reservation>()
                        .HasOne(r => r.Service)
                        .WithMany(s => s.Reservations)
                        .HasForeignKey(r => r.ServiceId)
                        .OnDelete(DeleteBehavior.Restrict);  









        }
    }

}
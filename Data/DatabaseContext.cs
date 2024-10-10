using Domain.Models;
using Microsoft.EntityFrameworkCore;

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
        public DbSet<CategoryService> CategoryServices { get; set; }

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

            modelBuilder.Entity<Sector>().HasData(
           new Sector
           {
               Id = Guid.Parse("e99f4b48-f6c5-4c0b-91a5-a2d6f7e7c392"),
               Description = "Politics news in Syria",
               TypeSector = "medicine",
               UrlSectorIcon = "www",
               IsAccepted = true,
           });
        }
        public static void CreateInitialTestingDataBase(DatabaseContext DatabaseContext)
        {
            DatabaseContext.Database.EnsureDeleted();
            DatabaseContext.Database.Migrate();
            DatabaseContext.Sectors.AddRange(new List<Sector>
                    {
                        new Sector
                        {
                            Id = Guid.Parse("e99f4b48-f6c5-4c0b-91a5-a2d6f7e7c392"),
                            Description = "Politics news in Syria",
                            UrlSectorIcon="www",

                            IsDeleted=false
                        },
                        new Sector
                        {
                            Id = Guid.Parse("0f11bbca-c9b2-4bfb-8acb-20192869ce38"),
                            Description = "Sports news in Syria",
                            UrlSectorIcon="www",

                            IsDeleted=false
                        }
                    });
            DatabaseContext.SaveChanges();
        }
    }
}
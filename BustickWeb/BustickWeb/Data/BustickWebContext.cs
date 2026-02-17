using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DataAccess;

namespace BustickWeb.Data
{
    public class BustickWebContext : DbContext
    {
        public BustickWebContext (DbContextOptions<BustickWebContext> options)
            : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-QNCVINK\SQLEXPRESS01; Database=BusTick; Trusted_Connection=True; TrustServerCertificate=True;");
        
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DataAccess.AppUser>()
                .HasOne(t => t.Passenger)
                .WithOne(r => r.AppUser)
                .HasForeignKey<Passenger>(p => p.Id);

            modelBuilder.Entity<DataAccess.AppUser>()
                .HasOne(t => t.Operator)
                .WithOne(o => o.AppUser)
                .HasForeignKey<Operator>(o => o.Id);

            modelBuilder.Entity<DataAccess.Trip>().ToTable("Trip", "BusTick");
            modelBuilder.Entity<DataAccess.AppUser>().ToTable("AppUser", "BusTick");
            modelBuilder.Entity<DataAccess.Bus>().ToTable("Bus", "BusTick");
            modelBuilder.Entity<DataAccess.Operator>().ToTable("Operator", "BusTick");
            modelBuilder.Entity<DataAccess.Passenger>().ToTable("Passenger", "BusTick");
            modelBuilder.Entity<DataAccess.Payment>().ToTable("Payment", "BusTick");
            modelBuilder.Entity<DataAccess.Review>().ToTable("Review", "BusTick");
            modelBuilder.Entity<DataAccess.Route>().ToTable("Route", "BusTick");
            modelBuilder.Entity<DataAccess.SeatReservation>().ToTable("SeatReservation", "BusTick");
            modelBuilder.Entity<DataAccess.Ticket>().ToTable("Ticket", "BusTick");
        }
        public DbSet<DataAccess.Trip> Trip { get; set; } = default!;
        public DbSet<DataAccess.Operator> Operators { get; set; } = default!;
        public DbSet<DataAccess.AppUser> AppUser { get; set; }
        public DbSet<DataAccess.Bus> Buses { get; set; } = default!;
        public DbSet<DataAccess.Passenger> Passengers { get; set; } = default!;
        public DbSet<DataAccess.Review> Reviews { get; set; } = default!;
        public DbSet<DataAccess.Ticket> Tickets { get; set; } = default!;
        public DbSet<DataAccess.SeatReservation> SeatReservations { get; set; } = default!;
        public DbSet<DataAccess.Payment> Payments { get; set; } = default!;



    }

}

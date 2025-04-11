using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;



namespace Infrastructure
{
   
        public class PerstigeMotorsContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            public DbSet<Car> Car { get; set; }
            public DbSet<Booking> Bookings { get; set; }
            public DbSet<Payment> Payments { get; set; }
            public DbSet<CarLocation> carLocation { get; set; }       
            public DbSet<Location> location { get; set; }

        public PerstigeMotorsContext(DbContextOptions<PerstigeMotorsContext> options)
          : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            {

            modelBuilder.Entity<Booking>()
           .HasOne(b => b.user) // Booking has a navigation property "User"
           .WithMany(u => u.Book) // User has a collection of "Bookings"
           .HasForeignKey(b => b.UserID) // Foreign key in Booking
           .OnDelete(DeleteBehavior.Cascade); // Deleting a User deletes associated Bookings

            // Configure relationships between CarLocation and Car
            modelBuilder.Entity<Car>()
             .HasOne(c => c.carLocation) // Each Car belongs to one CarLocation
             .WithMany(cl => cl.Icar) // Each CarLocation has many Cars
             .HasForeignKey(c => c.CarLocationID) // Foreign key in Car
             .OnDelete(DeleteBehavior.Restrict); // Prevent deletion of CarLocation if Cars exist

            // Configure relationships between CarLocation and Location
            modelBuilder.Entity<CarLocation>()
                .HasOne(cl => cl.location) // CarLocation has a navigation property "Location"
                .WithMany(l => l.carLocations) // Location has a collection of "CarLocations"
                .HasForeignKey(cl => cl.LocationID) // Foreign key in CarLocation
                .OnDelete(DeleteBehavior.Restrict); // Prevent deletion if related

            // Configure relationships between Booking and Car
            modelBuilder.Entity<Booking>()
                .HasOne(b => b.car) // Booking has a navigation property "Car"
                .WithMany(c => c.IBook) // Car has a collection of "Bookings"
                .HasForeignKey(b => b.CarID) // Foreign key in Booking
                .OnDelete(DeleteBehavior.SetNull); // Setting to null when Car is deleted

            // Configure relationships between Payment and Booking
            modelBuilder.Entity<Payment>()
               .HasOne(p => p.Book) // Payment has one Booking
               .WithOne(b => b.pay) // Booking has one Payment
               .HasForeignKey<Payment>(p => p.BookingID)
               .OnDelete(DeleteBehavior.Cascade); // Deleting a Booking deletes associated Payments
            modelBuilder.Entity<CarImages>()
                .HasOne(u=>u.car)
                .WithMany(i=>i.Images)
                .HasForeignKey(c => c.CarID)
                .OnDelete(DeleteBehavior.SetNull);


        }
    }
    }



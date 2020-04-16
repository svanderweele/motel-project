using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Motel.API.Classes;

namespace Motel.API.Models
{
    public class MotelContext : DbContext
    {

        public MotelContext(DbContextOptions<MotelContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomLayout>().HasMany(e => e.Rooms).WithOne(e => e.RoomLayout).HasForeignKey(e => e.RoomLayoutId);
            modelBuilder.Entity<Room>().HasOne(e => e.RoomLayout);

            modelBuilder.Entity<User>().HasMany(e => e.Reservations).WithOne(e => e.User).HasForeignKey(e => e.UserId);
            modelBuilder.Entity<Reservation>().HasOne(e => e.User);


            modelBuilder.Entity<RoomLayout>().HasData(
                new RoomLayout { Id = 1, Name = "Single" },
                new RoomLayout { Id = 2, Name = "Double" });

            modelBuilder.Entity<Room>().HasData(
                new Room { RoomLayoutId = 1, Id = 1 },
                new Room { RoomLayoutId = 2, Id = 2 }
                );


            byte[] passwordHash, passwordSalt;
            MyPasswordHasher.CreatePasswordHash("password", out passwordHash, out passwordSalt);
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Name = "Simon van der Weele", Email = "simon@example.com", PasswordHash = passwordHash, PasswordSalt = passwordSalt, Ref = Guid.NewGuid() }
            );


            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { Id = 1, NumberOfAdults = 2, NumberOfChildren = 1, ArrivalDate = new DateTime(2020, 08, 08), DepartureDate = new DateTime(2020, 08, 15), UserId = 1, Ref = Guid.NewGuid() },
                new Reservation { Id = 2, NumberOfAdults = 1, NumberOfChildren = 3, ArrivalDate = new DateTime(2020, 12, 03), DepartureDate = new DateTime(2020, 12, 25), UserId = 1, Ref = Guid.NewGuid() },
                new Reservation { Id = 3, NumberOfAdults = 1, NumberOfChildren = 2, ArrivalDate = new DateTime(2020, 06, 02), DepartureDate = new DateTime(2020, 06, 13), UserId = 1, Ref = Guid.NewGuid() }
            );
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSave();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            OnBeforeSave();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void OnBeforeSave()
        {
            ChangeTracker.DetectChanges();

            var entries = ChangeTracker.Entries().Where(e => e.Entity is ISoftDeletes && (
             e.State == EntityState.Added
             || e.State == EntityState.Modified || e.State == EntityState.Deleted));

            foreach (var entityEntry in entries)
            {
                ((ISoftDeletes)entityEntry.Entity).UpdatedAt = DateTime.Now;

                if (entityEntry.State == EntityState.Added)
                {
                    ((ISoftDeletes)entityEntry.Entity).CreatedAt = DateTime.Now;
                    ((ISoftDeletes)entityEntry.Entity).DeletedAt = null;
                }

                if (entityEntry.State == EntityState.Deleted)
                {
                    ((ISoftDeletes)entityEntry.Entity).DeletedAt = DateTime.Now;
                    entityEntry.State = EntityState.Unchanged;
                }
            }

            entries = ChangeTracker.Entries().Where(e => e.Entity is IReferenceable && (
                         e.State == EntityState.Added));

            foreach (var entityEntry in entries)
            {
                ((IReferenceable)entityEntry.Entity).Ref = Guid.NewGuid();
            }
        }


        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomLayout> RoomLayouts { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
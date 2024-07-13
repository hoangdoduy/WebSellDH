using Microsoft.EntityFrameworkCore;
using System.Globalization;
using WebSellDH_BlazorApp.Database.DataModel;

namespace WebSellDH_BlazorApp.Database.Context
{
    public class DatabaseDbContext : DbContext
    {
        public DatabaseDbContext(DbContextOptions<DatabaseDbContext> options) : base(options) { }

        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductLink> ProductLinks { get; set; }

        public DbSet<Price> Prices { get; set; }

        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserAccount>(e =>
            {
                e.HasIndex(x => x.UserName).IsUnique();
                e.Property(x => x.Role).HasDefaultValue(0);
                e.Property(x => x.Display).HasDefaultValue(false);
                e.Property(x => x.Balance).HasDefaultValue(0M).HasPrecision(18, 8);
                e.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                e.Property(x => x.UpdateDate).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<Category>(e =>
            {
                e.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                e.Property(x => x.UpdateDate).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<Product>(e =>
            {
                e.Property(x => x.ProductVersion).HasDefaultValue("1.0.0");
                e.Property(x => x.Display).HasDefaultValue(false);
                e.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                e.Property(x => x.UpdateDate).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<ProductLink>(e =>
            {
                e.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                e.Property(x => x.UpdateDate).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<Price>(e =>
            {
                e.Property(x => x.Balance).HasDefaultValue(0M).HasPrecision(18, 8);
                e.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                e.Property(x => x.UpdateDate).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<Order>(e =>
            {
                e.Property(x => x.Display).HasDefaultValue(false);
                e.Property(x => x.CreateDate).HasDefaultValueSql("getutcdate()");
                e.Property(x => x.UpdateDate).HasDefaultValueSql("getutcdate()");
            });

            modelBuilder.Entity<Order>().HasOne(e => e.Product).WithMany().OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            AddTimestamps();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private DateTime GetDateTimeVietNam()
        {
            DateTime utcTime = DateTime.UtcNow;
            TimeZoneInfo vietnamTimeZone = TimeZoneInfo.FindSystemTimeZoneById("SE Asia Standard Time");
            DateTime vietnamTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, vietnamTimeZone);

            return vietnamTime;
        }

        private void AddTimestamps()
        {
            var entries = ChangeTracker
            .Entries()
            .Where(e => e.Entity is BaseDateEntity && (
                    e.State == EntityState.Added
                    || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                ((BaseDateEntity)entityEntry.Entity).UpdateDate = GetDateTimeVietNam();

                if (entityEntry.State == EntityState.Added)
                {
                    ((BaseDateEntity)entityEntry.Entity).CreateDate = GetDateTimeVietNam();
                }
            }
        }

    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.DataAccess
{
    using ClothingShop.Model;
    using ClothingShop.Model.Entities;
    using Microsoft.EntityFrameworkCore.ChangeTracking;
    using System.Reflection;

    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Attribute> Attributes { get; set; }
        public DbSet<AttributeValue> AttributeValues { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Variant> Variants { get; set; }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasPostgresExtension("uuid-ossp");
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public void Clear()
        {
            ChangeTracker.Clear();
        }

        public async Task<int> SaveChanges(CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return await base.SaveChangesAsync(cancellationToken);
        }

        public override int SaveChanges(bool acceptAllChangesOnSuccess)
        {
            OnBeforeSaving();
            return base.SaveChanges(acceptAllChangesOnSuccess);
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        {
            OnBeforeSaving();
            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        protected virtual void OnBeforeSaving()
        {
            ChangeTracker.DetectChanges();
            SetAuditFields();
        }

        protected virtual void SetAuditFields()
        {
            foreach (EntityEntry item in from e in ChangeTracker.Entries()
                                         where e.State == EntityState.Added
                                         select e)
            {
                if (item.Metadata.FindProperty("Created") != null)
                {
                    PropertyEntry propertyEntry = item.Property("CreatedDate");
                    if (propertyEntry != null)
                    {
                        propertyEntry.CurrentValue = DateTime.UtcNow;
                    }
                }
            }

            foreach (EntityEntry item2 in from e in ChangeTracker.Entries()
                                          where e.State == EntityState.Modified || e.State == EntityState.Added || e.State == EntityState.Deleted
                                          select e)
            {
                if (item2.Metadata.FindProperty("UpdatedDate") != null)
                {
                    PropertyEntry propertyEntry2 = item2.Property("UpdatedDate");
                    if (propertyEntry2 != null)
                    {
                        propertyEntry2.CurrentValue = DateTime.UtcNow;
                    }
                }
            }
        }
    }
}

using EcommerceApp.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace EcommerceApp.Infrastructure.Data
{
    public class VikrantDbContext : IdentityDbContext<IdentityUser>
    {
        public VikrantDbContext(DbContextOptions<VikrantDbContext> options) : base(options)
        {
        }

        #region DbSet

        public DbSet<User> Users { get; set; }
        public DbSet<Addresses> Addresses { get; set; }
        public DbSet<Cities> Cities { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Inventories> Inventories { get; set; }
        public DbSet<Notifications> Notifications { get; set; }
        public DbSet<NotificationSettings> NotificationSettings { get; set; }
        public DbSet<OrderItems> OrderItems { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<PaymentDetails> PaymentDetails { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<ShoppingCartItems> ShoppingCartItems { get; set; }
        public DbSet<Wishlists> Wishlists { get; set; }
        public DbSet<Products> Products { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedRoles(builder);
            builder.Entity<IdentityRole>(options =>
            {
                options.HasKey(r => r.Id);
                options.Property(r => r.Name).IsRequired();
            });
        }

        private static void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
                new IdentityRole() { Name = "Customer", ConcurrencyStamp = "2", NormalizedName = "CUSTOMER" },
                new IdentityRole() { Name = "Seller", ConcurrencyStamp = "3", NormalizedName = "SELLER" }
            );
        }
    }
}

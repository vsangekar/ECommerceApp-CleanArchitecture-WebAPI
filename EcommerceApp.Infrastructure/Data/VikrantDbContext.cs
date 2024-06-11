using EcommerceApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Infrastructure.Data
{
    public class VikrantDbContext : DbContext
    {
        public VikrantDbContext(DbContextOptions<VikrantDbContext> options) : base(options)
        {
            
        }

        #region DbSet

        public DbSet<User> Users { get; set; }
        public DbSet<Roles> Roles{ get; set; }
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
        public DbSet<UserRoles> UserRoles { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed Roles
            modelBuilder.Entity<Roles>().HasData(
                new Roles
                {
                    ID = Guid.NewGuid(),
                    Name = "Admin",
                    Description = "Administrator role with full permissions",
                },
                new Roles
                {
                    ID = Guid.NewGuid(),
                    Name = "Customer",
                    Description = "Customer role with permissions to make purchases",
                },
                new Roles
                {
                    ID = Guid.NewGuid(),
                    Name = "Seller",
                    Description = "Seller who wants to sell the product",
                }
            );

            var adminUserId = Guid.NewGuid();
            var adminRoleId = Guid.NewGuid(); 
            modelBuilder.Entity<UserRoles>().HasData(
                new UserRoles
                {
                    UserID = adminUserId,
                    RoleID = adminRoleId
                }
            );
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    ID = adminUserId,
                    Name = "Admin User",
                    Gender = Gender.Male,
                    Email = "admin@test.com",
                    Username = "admin",
                    Password = "Admin@12345", 
                    CreatedDate = DateTime.UtcNow,  
                }
            );
        }
    }
}

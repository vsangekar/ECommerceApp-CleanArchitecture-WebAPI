using EcommerceApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        #endregion
    }
}

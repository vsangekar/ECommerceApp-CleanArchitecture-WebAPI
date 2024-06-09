
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Infrastructure.Data
{
    public class VikrantDbContextFactory : DesignTimeDbContextFactoryBase<VikrantDbContext>
    {
        protected override VikrantDbContext CreateNewInstance(DbContextOptions<VikrantDbContext> options)
        {
            return new VikrantDbContext(options);
        }
    }
}

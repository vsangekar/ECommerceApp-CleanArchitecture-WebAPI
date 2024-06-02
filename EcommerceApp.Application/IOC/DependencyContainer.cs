using EcommerceApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data;
using System.Data.SqlClient;

namespace EcommerceApp.Application.IOC
{
    public class DependencyContainer
    {
        public static void RegisterEcommerceApiServices(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<VikrantDbContext>(options => options.UseSqlServer(connectionString));

        }
    }
}

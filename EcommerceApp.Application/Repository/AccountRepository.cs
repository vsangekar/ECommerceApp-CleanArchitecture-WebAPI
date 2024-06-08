using EcommerceApp.Application.DTO;
using EcommerceApp.Application.IRepository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Application.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly DbContext _dbContext;

        public AccountRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserDto> ValidateUserCredentialsAsync(string username, string password)
        {
            var parameters = new[]
            {
                new SqlParameter("@Username", username),
                new SqlParameter("@Password", password)
            };

            var user = await _dbContext.Set<UserDto>()
                .FromSqlRaw("EXEC ValidateUserCredentials @Username, @Password", parameters)
                .FirstOrDefaultAsync();

            return user;
        }


        // Other method implementations
    }
}

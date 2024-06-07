using EcommerceApp.Application.Command;
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
    public class UserRepository : IUserRepository
    {
        private readonly DbContext _dbContext;

        public UserRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> AddAsync(CreateUserCommand command)
        {
            var parameters = new[]
            {
                new SqlParameter("@Name", command.Name),
                new SqlParameter("@Gender", command.Gender),
                new SqlParameter("@Description", command.Description),
                new SqlParameter("@Email", command.Email),
                new SqlParameter("@Image", command.Image),
                new SqlParameter("@Username", command.Username),
                new SqlParameter("@PasswordHash", command.PasswordHash),
                new SqlParameter("@DOB", command.DOB ?? (object)DBNull.Value),
                new SqlParameter("@Phone", command.Phone ?? (object)DBNull.Value),
                new SqlParameter("@PhoneWithCountryCode", command.PhoneWithCountryCode ?? (object)DBNull.Value),
                new SqlParameter("@CountryCode", command.CountryCode ?? (object)DBNull.Value),
                new SqlParameter("@Address", command.Address ?? (object)DBNull.Value),
                new SqlParameter("@CountryID", command.CountryID),
                new SqlParameter("@CityID", command.CityID),
            };

            var userId = await _dbContext.Database.ExecuteSqlRawAsync("EXEC CreateUser @Name, @Gender, @Description, @Email, @Image, @Username, @PasswordHash, @DOB, @Phone, @PhoneWithCountryCode, @CountryCode, @Address, @CountryID, @CityID, @CreatedBy, @CreatedDate", parameters);

            return new Guid(userId.ToString());
        }

        public async Task<bool> UpdateAsync(UpdateUserCommand command)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserId", command.UserId),
                new SqlParameter("@Name", command.Name),
                new SqlParameter("@Email", command.Email)
            };

            await _dbContext.Database.ExecuteSqlRawAsync("EXEC UpdateUser @UserId, @Name, @Email", parameters);
            return true;
        }

        public async Task<bool> DeleteAsync(Guid userId)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserId", userId)
            };

            await _dbContext.Database.ExecuteSqlRawAsync("EXEC DeleteUser @UserId", parameters);
            return true;
        }

        public async Task<UserDto> GetByIdAsync(Guid userId)
        {
            var parameters = new[]
            {
                new SqlParameter("@UserId", userId)
            };

            var user = await _dbContext.Set<UserDto>()
                .FromSqlRaw("EXEC GetUserById @UserId", parameters)
                .FirstOrDefaultAsync();

            return user;
        }
    }
}

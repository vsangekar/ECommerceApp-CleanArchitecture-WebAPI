using EcommerceApp.Application.Command.User;
using EcommerceApp.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Application.IRepository
{
    public interface IUserRepository
    {
        Task<Guid> AddAsync(CreateUserCommand command);
        Task<bool> UpdateAsync(UpdateUserCommand command);
        Task<bool> DeleteAsync(Guid userId);
        Task<UserDto> GetByIdAsync(Guid userId);
    }
}

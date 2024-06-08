using EcommerceApp.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Application.IRepository
{
    public interface IAccountRepository
    {
        Task<UserDto> ValidateUserCredentialsAsync(string username, string password);
    }
}

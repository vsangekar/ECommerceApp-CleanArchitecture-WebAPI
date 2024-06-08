using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Application.DTO
{
    public class LoginResponse
    {
        public bool IsAuthenticated { get; set; }
        public string Token { get; set; }
        public string Message { get; set; }
    }
}

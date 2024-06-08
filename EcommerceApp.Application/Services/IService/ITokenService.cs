﻿using EcommerceApp.Application.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Application.Services.IService
{
    public interface ITokenService
    {
        string GenerateToken(UserDto user);
    }
}

using EcommerceApp.Application.Command.Login;
using EcommerceApp.Application.DTO;
using EcommerceApp.Application.IRepository;
using EcommerceApp.Application.Services.IService;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Application.Handler.Account
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponse>
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public LoginCommandHandler(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<LoginResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.ValidateUserCredentialsAsync(request.Username, request.Password);

            if (user == null)
            {
                return new LoginResponse
                {
                    IsAuthenticated = false,
                    Message = "Invalid username or password."
                };
            }

            var token = _tokenService.GenerateToken(user);

            return new LoginResponse
            {
                IsAuthenticated = true,
                Token = token,
                Message = "Login successful."
            };
        }
    }
}

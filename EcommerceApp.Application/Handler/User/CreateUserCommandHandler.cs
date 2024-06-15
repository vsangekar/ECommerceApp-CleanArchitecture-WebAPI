using EcommerceApp.Application.Command.User;
using EcommerceApp.Application.IRepository;
using MediatR;


namespace EcommerceApp.Application.Handler.User
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Guid>
    {
        private readonly IUserRepository _userRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Guid> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var userId = await _userRepository.AddAsync(request);
            return userId;
        }
    }
}

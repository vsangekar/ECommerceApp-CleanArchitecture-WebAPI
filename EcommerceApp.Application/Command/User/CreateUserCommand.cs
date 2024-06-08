using EcommerceApp.Domain.Entities;
using MediatR;

namespace EcommerceApp.Application.Command.User
{
    public class CreateUserCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public DateTime? DOB { get; set; }
        public string Phone { get; set; }
        public string PhoneWithCountryCode { get; set; }
        public string CountryCode { get; set; }
        public string Address { get; set; }
        public long CountryID { get; set; }
        public long CityID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

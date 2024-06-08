using EcommerceApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Application.DTO
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public DateTime? DOB { get; set; }
        public string Phone { get; set; }
        public string PhoneWithCountryCode { get; set; }
        public string CountryCode { get; set; }
        public string Address { get; set; }
        public long CountryID { get; set; }
        public long CityID { get; set; }
        public string CreatedBy { get; set; }
    }
}

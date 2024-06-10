using EcommerceApp.Domain.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EcommerceApp.Domain.Entities
{
    [Table("User", Schema = "EcommerceApp")]
    public partial class User : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        public string Email { get; set; }

        public string Image { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime? DOB { get; set; }

        [Phone]
        [MaxLength(20)]
        public string Phone { get; set; }

        [Phone]
        [MaxLength(20)]
        public string PhoneWithCountryCode { get; set; }

        [MaxLength(5)]
        public string CountryCode { get; set; }

        [MaxLength(200)]
        public string Address { get; set; }

        [Required]
        public Guid CountryID { get; set; }

        [Required]
        public Guid CityID { get; set; }

        [MaxLength(50)]
        public string CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Other
    }
}

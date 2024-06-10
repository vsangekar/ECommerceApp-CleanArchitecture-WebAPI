using EcommerceApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Entities
{
    [Table("Addresses", Schema = "EcommerceApp")]
    public class Addresses : BaseEntity
    {
        [Required]
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Required]
        [MaxLength(200)]
        public string Street { get; set; }

        [MaxLength(200)]
        public string AdditionalDetails { get; set; }

        [Required]
        public Guid CityID { get; set; }

        [ForeignKey("CityID")]
        public Cities City { get; set; }

        [Required]
        public Guid CountryID { get; set; }

        [ForeignKey("CountryID")]
        public Countries Country { get; set; }

        [MaxLength(10)]
        public string PostalCode { get; set; }
    }
}

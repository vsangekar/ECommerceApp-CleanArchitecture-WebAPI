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
    [Table("Orders", Schema = "EcommerceApp")]
    public class Orders : BaseEntity
    {
        [Required]
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Required]
        public DateTime OrderDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string Status { get; set; }

        [MaxLength(500)]
        public string ShippingAddress { get; set; }

        [MaxLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }
    }
}

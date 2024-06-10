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
    [Table("PaymentDetails", Schema = "EcommerceApp")]
    public class PaymentDetails : BaseEntity
    {
        [Required]
        public Guid OrderID { get; set; }

        [ForeignKey("OrderID")]
        public Orders Order { get; set; }

        [Required]
        [MaxLength(100)]
        public string PaymentMethod { get; set; } // e.g., Credit Card, PayPal, etc.

        [Required]
        public decimal Amount { get; set; }

        [Required]
        public DateTime PaymentDate { get; set; }

        [MaxLength(500)]
        public string PaymentStatus { get; set; } // e.g., Paid, Pending, Failed
    }
}

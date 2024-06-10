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
    [Table("OrderItems", Schema = "EcommerceApp")]
    public class OrderItems : BaseEntity
    {
        [Required]
        public Guid OrderID { get; set; }

        [ForeignKey("OrderID")]
        public Orders Order { get; set; }

        [Required]
        public Guid ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Products Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal UnitPrice { get; set; }
    }
}

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
    [Table("ShoppingCartItems", Schema = "EcommerceApp")]
    public class ShoppingCartItems : BaseEntity
    {
        [Required]
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Required]
        public Guid ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Products Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }
    }
}

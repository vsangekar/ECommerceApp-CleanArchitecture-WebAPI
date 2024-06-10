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
    [Table("Inventories", Schema = "EcommerceApp")]
    public class Inventories : BaseEntity
    {
        [Required]
        public Guid ProductID { get; set; }

        [ForeignKey("ProductID")]
        public Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public DateTime LastUpdated { get; set; }
    }
}

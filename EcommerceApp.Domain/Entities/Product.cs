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
    [Table("Products", Schema = "EcommerceApp")]
    public class Products : BaseEntity
    {
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        [Required]
        public Guid CategoryID { get; set; }

        [ForeignKey("CategoryID")]
        public Categories Category { get; set; }

        public string ImageUrl { get; set; }

        [MaxLength(100)]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        public bool IsActive { get; set; }
    }
}

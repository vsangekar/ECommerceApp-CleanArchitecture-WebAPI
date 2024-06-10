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
    [Table("Reviews", Schema = "EcommerceApp")]
    public class Reviews : BaseEntity
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
        public int Rating { get; set; } // e.g., 1 to 5

        [MaxLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }
    }
}

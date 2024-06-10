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
    [Table("Notifications", Schema = "EcommerceApp")]
    public class Notifications : BaseEntity
    {
        [Required]
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Message { get; set; }

        [Required]
        public NotificationType Type { get; set; } // e.g., Order, Promotion, SystemAlert

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? ReadDate { get; set; }

        public bool IsRead { get; set; }
    }

    public enum NotificationType
    {
        Order,
        Promotion,
        SystemAlert
    }
}

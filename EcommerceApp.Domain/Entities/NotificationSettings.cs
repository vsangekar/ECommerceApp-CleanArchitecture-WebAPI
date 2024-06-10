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
    [Table("NotificationSettings", Schema = "EcommerceApp")]
    public class NotificationSettings : BaseEntity
    {
        [Required]
        public Guid UserID { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }

        [Required]
        public bool ReceivePromotions { get; set; }

        [Required]
        public bool ReceiveOrderUpdates { get; set; }

        [Required]
        public bool ReceiveSystemAlerts { get; set; }

        public DateTime? LastUpdated { get; set; }
    }
}

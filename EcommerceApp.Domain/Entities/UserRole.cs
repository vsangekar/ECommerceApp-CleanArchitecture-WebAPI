using EcommerceApp.Domain.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceApp.Domain.Entities
{
    [Table("UserRoles", Schema = "EcommerceApp")]
    public class UserRoles: BaseEntity
    {
        public Guid UserID { get; set; }
        public User User { get; set; }

        public Guid RoleID { get; set; }
        public Roles Role { get; set; }
    }
}

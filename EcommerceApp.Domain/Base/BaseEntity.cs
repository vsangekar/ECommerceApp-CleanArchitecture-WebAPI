using System;
using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Domain.Base
{
    public abstract class BaseEntity
    {
        [Key]
        public Guid ID { get; set; }
    }
}

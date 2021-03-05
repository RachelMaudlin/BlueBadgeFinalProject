using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        [Required]
        public int PaymentId { get; set;  }
        [Required]
        public DateTime OrderDate { get; set; }
      
    }
}

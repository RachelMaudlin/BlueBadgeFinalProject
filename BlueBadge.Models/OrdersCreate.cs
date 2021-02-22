using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    class OrdersCreate
    {
        [Required]
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
    }
}

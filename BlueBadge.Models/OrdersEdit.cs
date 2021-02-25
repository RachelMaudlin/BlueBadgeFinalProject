using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrdersEdit
    {
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
        public int PaymentId { get; set; }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrderItemsEdit
    {
        public int GameId { get; set; }
        public int PaymentId { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset OrderDate { get; set; }
    }
}

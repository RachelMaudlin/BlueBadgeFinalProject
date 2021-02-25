using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrderItemsDetails
    {
        [Display(Name = "Order Number")]
        public Guid OrderId { get; set; }
        
        public int CustomerId { get; set; }
        
        public int GameId { get; set; }
        [Display(Name ="Credit Card")]
        public int PaymentId { get; set; }
        
        public double Price { get; set; }
        
        public int Quantity { get; set; }
        
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset ShipDate { get; set; }
    }
}

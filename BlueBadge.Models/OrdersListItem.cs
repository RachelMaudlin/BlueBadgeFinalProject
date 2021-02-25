using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrdersListItem
    {
        [Display(Name = "Order Number")]
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
        [Display(Name = "Credit Card Number")]
        public int PaymentId { get; set; }
        [Display(Name="Ordered")]
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
    }
}

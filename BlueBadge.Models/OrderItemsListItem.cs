using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrderItemsListItem
    {
        [Display(Name = "Order Number")]
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
        [Display(Name = "Game Identification")]
        public int GameId { get; set; }
        [Display(Name = "Card Number")]
        public int PaymentId { get; set; }
        [Display(Name ="Date Ordered")]
        public DateTimeOffset OrderDate{ get; set; }
        public DateTimeOffset ShipDate { get; set; }
    }
}

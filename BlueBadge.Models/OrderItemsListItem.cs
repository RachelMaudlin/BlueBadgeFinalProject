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
        [Display(Name = "Game Identification")]
        public Guid GameId { get; set; }
        [Display(Name = "Card Number")]
        public Guid PaymentId { get; set; }
        [Display(Name ="Date Ordered")]
        public DateTimeOffset CreatedUtc { get; set; }
    }
}

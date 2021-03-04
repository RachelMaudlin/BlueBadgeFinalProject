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
        [Display(Name ="Item")]

        public int OrderItemId { get; set; }

        [Display(Name = "Order Number")]
        public int  OrderId { get; set; }

        public int GameId { get; set; }

        [Display(Name ="Credit Card")]
        public double Price { get; set; }
        
        public int Quantity { get; set; }
        public DateTimeOffset ShipDate { get; set; }
    }
}

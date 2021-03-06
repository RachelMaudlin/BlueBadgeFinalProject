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
        [Display(Name ="Item")]
        public int OrderItemId { get; set; }
        [Display(Name = "Order Number")]
        public int OrderId { get; set; }
        [Display(Name = "Game Identification")]
        public int GameId { get; set; }
        public int Quantity { get; set; }
        public DateTimeOffset ShipDate { get; set; }
    }
}

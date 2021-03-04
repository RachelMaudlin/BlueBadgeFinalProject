using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public class OrderItems
    {
        [Key]
        public int OrderItemId { get; set; }
        [ForeignKey(nameof(OrderId))]
        public int OrderId { get; set; }
        [Required]
        [ForeignKey(nameof(GameId))]
        public int GameId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTimeOffset ShipDate { get; set; }
    }
}

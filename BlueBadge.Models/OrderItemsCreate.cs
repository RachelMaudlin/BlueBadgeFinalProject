using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrderItemsCreate
    {
        [Required]
        public Guid OrderID { get; set; }
        [Required]
        public Guid GameId { get; set; }
        public Guid PaymentId { get; set; }
        [Required]
        public int Quantity { get; set; }
        public DateTimeOffset CreatedUtc { get; set; }
    }
}

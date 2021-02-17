using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    class OrderItems
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}

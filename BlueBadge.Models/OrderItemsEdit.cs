using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrderItemsEdit
    {
        [Required]
        public int OrderItemId { get; set; }
        [Required]
        public int Quantity { get; set; }

    }
}

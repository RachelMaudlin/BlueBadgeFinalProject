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
        public int OrderId { get; set; }

        [Display(Name="Ordered")]
        public DateTime OrderDate { get; set; }
    }
}

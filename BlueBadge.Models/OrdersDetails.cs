using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Models
{
    public class OrdersDetails
    {
        [Display(Name ="Order Number")]
        public Guid OrderId { get; set; }
        public int CustomerId { get; set; }
        [Display(Name = "Credit Card")]
        public int PaymentId { get; set; }
        [Display(Name ="Order Date")]
        public DateTime OrderDate { get; set; }
        [Display(Name ="ShipDate")]
        public DateTime ShipDate { get; set; }
    }
}

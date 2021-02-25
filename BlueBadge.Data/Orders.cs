﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public class Orders
    {
        [Key]
        public Guid OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int PaymentId { get; set;  }
        [Required]
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }

    }
}

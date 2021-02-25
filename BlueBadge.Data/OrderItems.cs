﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueBadge.Data
{
    public class OrderItems
    {
        [Key]
        public Guid OrderId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public int GameId { get; set; }
        [Required]
        public int PaymentId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTimeOffset OrderDate { get; set; }
        public DateTimeOffset ShipDate { get; set; }
    }
}

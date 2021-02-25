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
        public Guid CustomerId { get; set; }
        [Required]
        public Guid GameId { get; set; }
        [Required]
        public Guid PaymentId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTimeOffset CreatedUtc { get; set; }
        public DateTimeOffset ModifiedUtc { get; set; }
    }
}

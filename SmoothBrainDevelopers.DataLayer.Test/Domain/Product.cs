﻿using System.ComponentModel.DataAnnotations;

namespace SmoothBrainDevelopers.DataLayer.Test.Domain
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}

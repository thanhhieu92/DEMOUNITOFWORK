﻿namespace DEMOUNITOFWORK.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public float Price { get; set;}
        public bool isDiscountApplied { get; set; }
    }
}

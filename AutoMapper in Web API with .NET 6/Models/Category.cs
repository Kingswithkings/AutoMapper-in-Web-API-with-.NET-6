﻿namespace AutoMapper_in_Web_API_with_.NET_6.Models
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}   

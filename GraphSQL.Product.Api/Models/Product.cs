using System;

namespace GraphSQL.Shop.Api.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public decimal Prices { get; set; }
    }
}


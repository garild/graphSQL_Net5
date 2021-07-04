using GraphSQL.Shop.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace GraphSQL.Shop.Api.Services
{
    public class ProductQuery
    {
        public IReadOnlyCollection<Product> Products([FromServices] IProductService productService) => productService.GetProducts();
    }

    public class ProductService : IProductService
    {
        public IReadOnlyCollection<Product> GetProducts()
        {
            var rnd = new Random().Next(50, 150);
            var result = new List<Product>();
            for (int i = 1; i <= 100; i++)
            {
                result.Add(new Product{ Name = $"Product-{i}", Prices = rnd });
            }

            return result;
        }
    }
}

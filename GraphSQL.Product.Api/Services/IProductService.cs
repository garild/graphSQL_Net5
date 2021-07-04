using GraphSQL.Shop.Api.Models;
using System.Collections.Generic;

namespace GraphSQL.Shop.Api.Services
{
    public interface IProductService
    {
        IReadOnlyCollection<Product> GetProducts();
    }
}

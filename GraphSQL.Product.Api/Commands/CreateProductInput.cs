using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphSQL.Shop.Api.Commands
{
    public record CreateProductInput(Guid Id, string name, decimal price);
}
    

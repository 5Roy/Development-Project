using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Web.Models
{
    public interface IProductRepository
    {
        Product GetProducts(string Category);
    }
}

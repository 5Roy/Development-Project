using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Web.Models
{
    public class MockProductRepository : IProductRepository
    {
        private List<Product> _productList;
        public MockProductRepository()
        {
            _productList = new List<Product>()
            {
            new Product(){Id =1, Category="Liquid",Metadata="A17hL",Details="All liquid under 10oz"},
            new Product(){Id =2, Category="Solid",Metadata="A18hL",Details="Solid except hazard materials"},
            new Product(){Id =3, Category="Gas",Metadata="A19hL",Details="hazard materials need more care"},
            };
        }
        public Product GetProducts(string Category)
        {
            return _productList.FirstOrDefault(e => e.Category == Category);
            //throw new NotImplementedException();
        }
    }
}

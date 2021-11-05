using Interview.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Sitecore.FakeDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Web.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //***************************************************************//
        // new implementation to fetch product details based on Category//
        //***************************************************************//
        public JsonResult Details()
        {
            Product model = _productRepository.GetProducts("Liquid");
            return Json(model);

        }

        //// NOTE: Sample Action
        //[HttpGet]
        //public Task<IActionResult> GetAllProducts()
        //{
        //    return Task.FromResult((IActionResult)Ok(new object[] { }));


        //}
    }
}

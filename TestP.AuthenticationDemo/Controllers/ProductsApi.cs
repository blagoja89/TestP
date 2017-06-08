using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestP.AuthenticationDemo.Data;
using TestP.AuthenticationDemo.Models;

namespace TestP.AuthenticationDemo.Controllers
{
    public class ProductsApi : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductsApi(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/products")]
        public IActionResult GetAll()
        {
            var products = _context.Products.ToList();
            return new OkObjectResult(products);

        }

        [HttpGet]
        [Route("/products/startwith/{query}")]
        public IActionResult GetAll([FromRoute]string query)
        {
            var products = _context.Products.Where(p => p.Name.StartsWith(query));
            var list = products.ToList();
            return new OkObjectResult(list);

        }

        [HttpGet]
        [Route("/products/{name}")]
        public IActionResult AddRandom([FromRoute]string name)
        {
            var product = new Product { Name = name };

            _context.Products.Add(product);
            _context.SaveChanges();

            return new OkObjectResult(_context.Products.ToList());
        }
    }
}

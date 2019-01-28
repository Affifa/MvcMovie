
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your product page.";

            return View();
        }
        Product[] products = new Product[]
       {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
       };
        //[HttpGet]
        public IActionResult GetAllProducts()
        { 
            return Ok(products);
        }
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var product = products.Where(c => c.Id == id).FirstOrDefault();// products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
       //[HttpGet("{name}", Name = "GetByName")]
        public IActionResult GetByName(string name)
        {
            var product = products.FirstOrDefault((p) => p.Name == name);/*products.Where(c => c.Name == name).FirstOrDefault();*/// products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}



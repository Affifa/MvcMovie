using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class NewController : Controller
    {
        public IActionResult New()
        {
            //ViewData["Message"] = "Your new page.";

            return View();
        }
    
   
}
}
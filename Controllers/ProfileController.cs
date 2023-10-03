using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFirstApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyFirstApplication.Controllers
{
    public class ProfileController : Controller
    {
        public object Name { get; private set; }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Intro()
        {
            
                Profile profile = new Profile()
                {
                    Name = "Sudarshan Fullel",
                    Address = "kathmandu",
                    Contact = "9809876543",
                    Description = "Learn how to enable support for right-to-left text in Bootstrap across our layout, components, and utilities."

                };


                return View(profile);
            


            
        }
    }
}


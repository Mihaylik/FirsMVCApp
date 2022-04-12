﻿using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HelloView(PersonViewModel person)
        {
            return View("HelloView", person);
        }
    }
}
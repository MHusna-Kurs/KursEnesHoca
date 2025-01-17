﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusBiletCoreApplication.Models;
using BusinessLayer;
using DataAccessLayer.Concrete.EntityFramework;

namespace BusBiletCoreApplication.Controllers
{
    public class HomeController : Controller
    {
        FirmaManager firma = new FirmaManager(new EfFirmaRepository());

        public IActionResult Index()
        {
            var liste = firma.firmaListele();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

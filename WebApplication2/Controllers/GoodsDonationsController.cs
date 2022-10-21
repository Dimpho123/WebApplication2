using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Data.SqlTypes;

namespace WebApplication2.Controllers
{
    public class GoodsDonationsController : Controller
    {

        
        private readonly Connections _dd;

        public GoodsDonationsController(Connections dd)
        {
            _dd = dd;
        }

        
        public IActionResult Goodsd()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Goodsd(Goods g)
        {
            _dd.Add(g);
            _dd.SaveChanges();
            ViewBag.message = "The record" + g.Description_of_each_item + "saved successfully";
            return View();
        }
        [HttpGet]
        public IActionResult GoodsCaptured()
        {
            return View(_dd.Goodsd.ToList());
        }
    }
}

  
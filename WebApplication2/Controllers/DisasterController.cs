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
    public class DisasterController : Controller
    {
        private readonly Connections _dd;

        public DisasterController(Connections dd)
        {
            _dd = dd;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Disasterd()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Disasterd(Disaster di)
        {
            _dd.Add(di);
            //_dd.SaveChanges();
            ViewBag.message = "The record" +  di.Location + "  saved successfully";
            return View();
        }
    }
}

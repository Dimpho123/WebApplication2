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
    public class MoneyDonationsController : Controller
    {
        private readonly Connections _dd;

        public MoneyDonationsController (Connections dd)
        {
            _dd = dd;
        }
        
        public IActionResult Moneyd()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Moneyd(Money m)
        {
            _dd.Add(m);
            _dd.SaveChanges();
            ViewBag.message = "The record" + m.Amount + " saved successfully";
            return View();
        }
        [HttpGet]
        public IActionResult MoneyCaptured()
        {
            return View(_dd.Moneyd.ToList());
        }
    }
}

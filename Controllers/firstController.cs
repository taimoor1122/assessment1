using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using assessment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace assessment1.Controllers
{
    public class firstController : Controller
    {
        private DESIGNContext orm = null;
        public firstController (DESIGNContext _orm)
        {
            orm = _orm;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult homepage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult homepage(Category c)
        {
            orm.Category.Add(c);
            orm.SaveChanges();
            return View();
        }




    }
}
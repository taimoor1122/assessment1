﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace assessment1.Controllers
{
    public class firstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
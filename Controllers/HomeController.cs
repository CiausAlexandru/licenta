﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace identity.Controllers
{
    [Authorize]
    [Route("")]
    [Route("Home")]
    [Route("Home/Index")]
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View((object)"hello");
        }
    }
}

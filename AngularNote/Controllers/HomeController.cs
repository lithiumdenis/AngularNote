﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularNote.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string returnUrl)
        {            
            return View();
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class EducationController : Controller
    {
        // GET: Education
        public ActionResult EducationList()
        {
            return View();
        }
        public ActionResult CreateEducation()
        {
            return View();
        }
    }
}
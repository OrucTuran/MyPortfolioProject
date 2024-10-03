using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPortfolioProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult PartialSpinner()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }
        public PartialViewResult PartialAbout()
        {
            return PartialView();
        }
        public PartialViewResult PartialEducation()
        {
            return PartialView();
        }
        public PartialViewResult PartialExperience()
        {
            return PartialView();
        }
        public PartialViewResult PartialSkills()
        {
            return PartialView();
        }
        public PartialViewResult PartialService()
        {
            return PartialView();
        }
        public PartialViewResult PartialPortfolio()
        {
            return PartialView();
        }
        public PartialViewResult PartialBlog()
        {
            return PartialView();
        }
        public PartialViewResult PartialTestimonial()
        {
            return PartialView();
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
    }
}
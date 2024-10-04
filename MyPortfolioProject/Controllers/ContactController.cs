using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class ContactController : Controller
    {
        //GET: Contact
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult PartialContactSideBar()
        {
            return View();
        }
        public PartialViewResult PartialContactDetail()
        {
            ViewBag.address = context.Profile.Select(x => x.Address).FirstOrDefault();
            ViewBag.description = context.Profile.Select(x => x.Description).FirstOrDefault();
            ViewBag.phoneNumber = context.Profile.Select(x => x.PhoneNumber).FirstOrDefault();
            ViewBag.email = context.Profile.Select(x => x.Email).FirstOrDefault();
            return PartialView();
        }
        public PartialViewResult PartialContactLocation()
        {
            return PartialView();
        }
    }
}
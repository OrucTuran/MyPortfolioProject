using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class InternshipController : Controller
    {
        // GET: Internship
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult InternshipList()
        {
            var values = context.Internship.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateInternship()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateInternship(Internship internship)
        {
            if (ModelState.IsValid)
            {
                context.Internship.Add(internship);
                context.SaveChanges();
                return RedirectToAction(nameof(InternshipList));
            }
            return View(internship);
        }
        public ActionResult DeleteInternship(int id)
        {
            var value = context.Internship.Find(id);
            context.Internship.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(InternshipList));
        }
        [HttpGet]
        public ActionResult UpdateInternship(int id)
        {
            var value = context.Internship.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateInternship(Internship internship)
        {
            var value = context.Internship.Find(internship.InternshipID);
            value.CompanyName = internship.CompanyName;
            value.StartDate = internship.StartDate;
            value.EndDate = internship.EndDate;
            value.Position = internship.Position;
            value.Description = internship.Description;
            value.ReferenceName = internship.ReferenceName;
            value.ReferenceEmail = internship.ReferenceEmail;
            context.SaveChanges();
            return RedirectToAction(nameof(InternshipList));
        }
    }
}
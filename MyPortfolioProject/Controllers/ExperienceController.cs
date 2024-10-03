using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class ExperienceController : Controller
    {
        // GET: Experience
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult ExperienceList()
        {
            var values = context.Experience.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateExperience()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateExperience(Experience experience)
        {
            context.Experience.Add(experience);
            context.SaveChanges();
            return RedirectToAction(nameof(ExperienceList));
        }
        public ActionResult DeleteExperience(int id)
        {
            var value = context.Experience.Find(id);
            context.Experience.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(ExperienceList));
        }
        [HttpGet]
        public ActionResult UpdateExperience(int id)
        {
            var value = context.Experience.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateExperience(Experience experience)
        {
            Experience value = context.Experience.Find(experience.ExperienceID);
            value.Title = experience.Title;
            value.SubTitle = experience.SubTitle;
            value.Description = experience.Description;
            context.SaveChanges();
            return RedirectToAction(nameof(ExperienceList));
        }
    }
}
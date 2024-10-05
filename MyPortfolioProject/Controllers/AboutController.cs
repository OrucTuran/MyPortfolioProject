using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class AboutController : Controller
    {
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();

        public ActionResult Index()
        {
            var values = context.About.Where(x=>x.Status==true).ToList();
            return View(values);
        }

        public ActionResult ChangeAboutStatusToTrue(int id)
        {
            var aboutItems = context.About.ToList(); 
            foreach (var item in aboutItems)
            {
                item.Status = false;
            }

            var aboutToActivate = context.About.Find(id);
            if (aboutToActivate != null)
            {
                aboutToActivate.Status = true; 
                context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        public ActionResult ChangeAboutStatusToFalse(int id)
        {        
            var selectedItem = context.About.Find(id);
            selectedItem.Status = false;

            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public ActionResult DeleteAbout(int id)
        {
            var value = context.About.Find(id);
            context.About.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateAbout(About about)
        {
            about.Status = false;
            context.About.Add(about);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult UpdateAbout(int id)
        {
            var value = context.About.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAbout(About about)
        {
            var value = context.About.Find(about.AboutID);
            value.Title = about.Title;
            value.Description = about.Description;
            value.ImageURL = about.ImageURL;
            value.LeftTitle = about.LeftTitle;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
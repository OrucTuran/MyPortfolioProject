using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class SocialMediaController : Controller
    {
        // GET: SocialMedia
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = context.SocialMedia.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSocialMedia()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSocialMedia(SocialMedia socialMedia)
        {
            context.SocialMedia.Add(socialMedia);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult DeleteSocialMedia(int id)
        {
            var value = context.SocialMedia.Find(id);
            context.SocialMedia.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = context.SocialMedia.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSocialMedia(SocialMedia socialMedia)
        {
            var value = context.SocialMedia.Find(socialMedia.SocialMediaID);
            value.Title = socialMedia.Title;
            value.URL = socialMedia.URL;
            value.Icon = socialMedia.Icon;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
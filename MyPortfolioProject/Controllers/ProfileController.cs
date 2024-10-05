using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class ProfileController : Controller
    {
        // GET: Profile
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            var values = context.Profile.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateProfile()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateProfile(Profile profile)
        {
            context.Profile.Add(profile);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult DeleteProfile(int id)
        {
            var value = context.Profile.Find(id);
            context.Profile.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = context.Profile.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProfile(Profile profile)
        {
            var value = context.Profile.Find(profile.ProfileID);
            value.Description = profile.Description;
            value.Address = profile.Address;
            value.Email = profile.Email;
            value.PhoneNumber = profile.PhoneNumber;
            value.GitHubURL = profile.GitHubURL;
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
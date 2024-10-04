using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class TestimonialController : Controller
    {
        // GET: Testimonial
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult TestimonialList()
        {
            var values = context.Testimonial.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateTestimonial()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateTestimonial(Testimonial testimonial)
        {
            context.Testimonial.Add(testimonial);
            context.SaveChanges();
            return RedirectToAction(nameof(TestimonialList));
        }
        public ActionResult DeleteTestimonial(int id)
        {
            var value = context.Testimonial.Find(id);
            context.Testimonial.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(TestimonialList));
        }
        [HttpGet]
        public ActionResult UpdateTestimonial(int id)
        {
            var value = context.Testimonial.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTestimonial(Testimonial testimonial)
        {
            var value = context.Testimonial.Find(testimonial.TestimonialID);
            value.NameSurname = testimonial.NameSurname;
            value.Address = testimonial.Address;
            value.Description = testimonial.Description;
            value.ImageURL = testimonial.ImageURL;
            context.SaveChanges();
            return RedirectToAction(nameof(TestimonialList));
        }
    }
}
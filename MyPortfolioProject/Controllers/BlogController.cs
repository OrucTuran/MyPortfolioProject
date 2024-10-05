using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult BlogList()
        {
            var values = context.Blog.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateBlog(Blog blog)
        {
            context.Blog.Add(blog);
            context.SaveChanges();
            return RedirectToAction(nameof(BlogList));
        }
        public ActionResult DeleteBlog(int id)
        {
            var value = context.Blog.Find(id);
            context.Blog.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(BlogList));
        }
        [HttpGet]
        public ActionResult UpdateBlog(int id)
        {
            var value = context.Blog.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateBlog(Blog blog)
        {
            var value = context.Blog.Find(blog.BlogID);
            value.Date = blog.Date;
            value.Title = blog.Title;
            value.ByWho = blog.ByWho;
            value.Subject = blog.Subject;
            value.ImageURL = blog.ImageURL;
            context.SaveChanges();
            return RedirectToAction(nameof(BlogList));
        }
    }
}
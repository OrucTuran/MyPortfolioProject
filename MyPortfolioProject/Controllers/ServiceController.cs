using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class ServiceController : Controller
    {
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult ServiceList()
        {
            var values = context.Service.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateService()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateService(Service service)
        {
            context.Service.Add(service);
            context.SaveChanges();
            return RedirectToAction(nameof(ServiceList));
        }
        public ActionResult DeleteService(int id)
        {
            var value = context.Service.Find(id);
            context.Service.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(ServiceList));
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = context.Service.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateService(Service service)
        {
            var value = context.Service.Find(service.ServiceID);
            value.Icon = service.Icon;
            value.Title = service.Title;
            value.Description = service.Description;
            value.SubTitleA = service.SubTitleA;
            value.SubTitleB = service.SubTitleB;
            value.SubTitleC = service.SubTitleC;
            context.SaveChanges();
            return RedirectToAction(nameof(ServiceList));
        }
    }
}
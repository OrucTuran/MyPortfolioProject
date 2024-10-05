using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;
using PagedList.Mvc;
using PagedList;

namespace MyPortfolioProject.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult Inbox(int page = 1)
        {
            var values = context.Contact.ToList().ToPagedList(page, 5);
            return View(values);
        }
        public ActionResult ChangeMessageStatusToTrue(int id)
        {
            var value = context.Contact.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction(nameof(Inbox));
        }
        public ActionResult ChangeMessageStatusToFalse(int id)
        {
            var value = context.Contact.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction(nameof(Inbox));
        }
        public ActionResult ChangeMessageStatus(int id, bool status)
        {
            var value = context.Contact.Find(id);
            value.IsRead = status;
            context.SaveChanges();
            return RedirectToAction(nameof(Inbox));
        }
    }
}
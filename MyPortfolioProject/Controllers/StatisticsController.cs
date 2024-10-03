using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class StatisticsController : Controller
    {
        // GET: Statistics
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult Index()
        {
            ViewBag.totalMessageCount = context.Contact.Count();
            ViewBag.messageIsReadTrueCount = context.Contact.Where(x => x.IsRead == true).Count();
            ViewBag.messageIsReadFalseCount = context.Contact.Where(x => x.IsRead == false).Count();
            ViewBag.totalSkillCount = context.Skill.Count();
            ViewBag.totalSkillRateSumCount = context.Skill.Sum(x => x.Rate);
            ViewBag.totalSkillAverageSumCount = (int)context.Skill.Average(x => x.Rate);

            int maxRate = (int)context.Skill.Max(x => x.Rate);
            ViewBag.MaxRateSkillName = context.Skill.Where(x => x.Rate == maxRate).Select(y => y.SkillName).FirstOrDefault();

            ViewBag.getMessageCountBySubjectReferances = context.Contact.Where(x => x.Subject == "Proje Talebi").Count();
            ViewBag.getMessageCountBySubjectReferancesName = context.Contact.Where(x => x.Subject == "Proje Talebi").Select(y => y.NameSurname).FirstOrDefault();

            ViewBag.getMessageCountByEmailContainEandIsReadTrue = context.Contact.Where(x => x.IsRead == true && x.Email.Contains("e")).Count();
            ViewBag.getSkillNameByRate75 = context.Skill.Where(x => x.Rate == 75).Select(y => y.SkillName).FirstOrDefault();
            return View();

        }
    }
}
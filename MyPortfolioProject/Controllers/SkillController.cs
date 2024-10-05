using MyPortfolioProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList.Mvc;
using PagedList;

namespace MyPortfolioProject.Controllers
{
    public class SkillController : Controller
    {
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult SkillList(int page = 1)
        {
            var values = context.Skill.ToList().ToPagedList(page,5);
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(Skill skill)
        {
            context.Skill.Add(skill);
            context.SaveChanges();
            return RedirectToAction(nameof(SkillList));
        }
        public ActionResult DeleteSkill(int id)
        {
            var value = context.Skill.Find(id);
            context.Skill.Remove(value);
            context.SaveChanges();
            return RedirectToAction(nameof(SkillList));
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = context.Skill.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateSkill(Skill skill)
        {
            var value = context.Skill.Find(skill.SkillID);
            value.SkillName = skill.SkillName;
            value.Rate = skill.Rate;
            context.SaveChanges();
            return RedirectToAction(nameof(SkillList));
        }
    }
}
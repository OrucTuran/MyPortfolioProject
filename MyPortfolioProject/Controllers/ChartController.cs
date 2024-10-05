using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyPortfolioProject.Models;

namespace MyPortfolioProject.Controllers
{
    public class ChartController : Controller
    {
        // GET: Chart
        DbMyPortfolioEntities context = new DbMyPortfolioEntities();
        public ActionResult GetSkills()
        {
            var values = context.Skill.ToList();
            return PartialView(values);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excursion.Models;

namespace Excursion.Controllers
{
    public class AttractionController : Controller
    {
        //
        // GET: /Attraction/

        public ActionResult AttractionManage()
        {
            List<ScenicSpot> scenicSpots;
            using (var db = new ExcursionDbContext())
            {
                var query = from s in db.ScenicSpots
                    select s;
                scenicSpots = query.ToList();
            }
            return View(scenicSpots);
        }

    }
}

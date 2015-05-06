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

        public ActionResult AttractionManage(string page)
        {
            if (page == null)
            {
                page = "1";
            }
            List<ScenicSpot> scenicSpots;
            using (var db = new ExcursionDbContext())
            {
                var query = from s in db.ScenicSpots
                    select s;
                var queryCut = query.OrderBy(s =>s.Id).Skip((int.Parse(page) - 1) * 20).Take(20);
                scenicSpots = queryCut.ToList();
                if (scenicSpots.Count <=0)
                {
                    Response.Redirect("http://localhost:37145/Attraction/AttractionManage?page=" + query.Count() / 20);
                }
            }
            return View(scenicSpots);
        }

    }
}

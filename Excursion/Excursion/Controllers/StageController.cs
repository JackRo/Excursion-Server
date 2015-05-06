using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excursion.Models;

namespace Excursion.Controllers
{
    public class StageController : Controller
    {
        //
        // GET: /Stage/
     
        public ActionResult StageManage(string page)
        {
            if (page == null)
            {
                page = "1";
            }
            List<Stage> stages;
            using (var db = new ExcursionDbContext())
            {
                var query = from s in db.Stages
                    select s;
                var queryCut = query.OrderBy(s => s.Id).Skip((int.Parse(page) - 1) * 20).Take(20);
                stages = queryCut.ToList();
                if (stages.Count <= 0)
                {
                    Response.Redirect("http://localhost:37145/Stage/StageManage?page=" + query.Count() / 20);
                }
            }
            return View(stages);
        }
    }
}

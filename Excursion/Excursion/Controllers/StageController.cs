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

        public ActionResult StageManage()
        {
            List<Stage> stages;
            using (var db = new ExcursionDbContext())
            {
                var query = from s in db.Stages
                    select s;
                stages = query.ToList();
            }
            return View(stages);
        }

    }
}

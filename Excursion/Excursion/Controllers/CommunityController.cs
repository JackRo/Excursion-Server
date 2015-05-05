using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excursion.Models;

namespace Excursion.Controllers
{
    public class CommunityController : Controller
    {
        //
        // GET: /Community/

        public ActionResult CommunityManage()
        {
            List<Note> notes;
            using (var db = new ExcursionDbContext())
            {
                var query = from n in db.Notes
                    select n;
                notes = query.ToList();
            }
            return View(notes);
        }

    }
}

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

        public ActionResult CommunityManage(string page)
        {
            if (page == null)
            {
                page = "1";
            }
            List<Note> notes;
            using (var db = new ExcursionDbContext())
            {
                var query = from n in db.Notes
                    select n;
                var queryCut = query.OrderBy(n => n.Id).Skip((int.Parse(page) - 1)*20).Take(20);
                notes = queryCut.ToList();
                if (notes.Count <= 0)
                {
                    Response.Redirect("http://localhost:37145/Community/CommunityManage?page=" + query.Count() / 20);
                }
            }
            return View(notes);
        }

    }
}

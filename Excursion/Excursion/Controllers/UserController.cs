using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excursion.Models;

namespace Excursion.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult UserManage(string page)
        {
            if (page == null)
            {
                page = "1";
            }
            List<User> users;
            using (var db = new ExcursionDbContext())
            {
                var query = from u in db.Users
                            select u;
                var queryCut = query.OrderBy(u => u.Id).Skip((int.Parse(page) - 1) * 20).Take(20);
                users = queryCut.ToList();
                if (users.Count <= 0)
                {
                    Response.Redirect("http://localhost:37145/User/UserManage?page=" + query.Count() / 20);
                }
            }
            return View(users);
        }

    }
}

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

        public ActionResult UserManage()
        {
            List<User> users;
            using (var db = new ExcursionDbContext())
            {
                var query = from u in db.Users
                            select u;
                users = query.ToList();
            }
            return View(users);
        }

    }
}

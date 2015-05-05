using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excursion.Models;

namespace Excursion.Controllers
{
    public class SystemController : Controller
    {
        //
        // GET: /System/

        public ActionResult SystemManage()
        {
            Admin admin = (Admin) Session["Login"];
            List<Admin> admins = new List<Admin> {admin};
            return View(admins);
        }

    }
}

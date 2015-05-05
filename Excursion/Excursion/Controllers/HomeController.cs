using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Excursion.Models;

namespace Excursion.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        //
        //GET: /Home/Login
        
        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        //POST: /Home/Login

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(Admin admin, string returnUrl)
        {
            using (var db = new ExcursionDbContext())
            {
                var query = from a in db.Admins
                    where a.Username == admin.Username && a.Password == admin.Password
                    select a;
                if (query.Count() == 1)
                {
                    Session["Login"] = admin;                    
                    return View("Index", query.ToList());
                }
                Response.Write("<script language='javascript'>alert('用户名或密码错误，登录失败!')</script>");
            }
            return View(admin);
        }

        private ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}

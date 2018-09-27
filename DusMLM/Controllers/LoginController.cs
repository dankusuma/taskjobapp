using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DusMLM.Models;
namespace DusMLM.Controllers
{
    public class LoginController : Controller
    {
        private jobtaskappEntities db = new jobtaskappEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult DoLogin(LoginViewModel login)
        {

            
            var obj = db.user_member.Where(a=>a.user_id==login.user_id && a.user_password==login.user_password).FirstOrDefault();
            if (obj != null)
            {
                Session["UserID"] = obj.user_id;
                Session["UserLevel"] = obj.user_level;
                Session["UserUpline"] = obj.user_upline;
                return RedirectToAction("Index", "Home");
            }
           
            return RedirectToAction("Index", "Login");
        }
    }
}
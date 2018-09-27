using DusMLM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DusMLM.Controllers
{

    public class RegisterController : Controller
    {
        private jobtaskappEntities db = new jobtaskappEntities();
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DoRegister(RegisterViewModel register)
        {
            
            if (register.user_password != register.user_password_confirm)
            {
                return RedirectToAction("Index", "Login");
            }
            try
            {
                db.ADD_USER_MEMBER(register.user_id, register.user_password, register.user_name, register.user_upline, register.user_id);
            }
            catch (Exception e)
            {
                return Content(e.ToString());
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
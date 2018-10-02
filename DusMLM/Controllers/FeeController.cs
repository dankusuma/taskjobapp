using DusMLM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DusMLM.Controllers
{
    public class FeeController : Controller
    {
        private jobtaskappEntities db = new jobtaskappEntities();
        public ActionResult Index()
        {
            string uid = (string)Session["UserID"];
            FeeViewModel fee = new FeeViewModel();
            fee.FeeUser = db.V_Fee_Per_User.SingleOrDefault(a=>a.trpayment_user_id==uid);
            fee.FeeUserPerJob = db.V_Fee_Per_User_Job.Where(a => a.trpayment_user_id == uid).ToList();
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            return View(fee);
        }
    }
}
using DusMLM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DusMLM.Controllers
{
    public class Level1Controller : Controller
    {
        private jobtaskappEntities db = new jobtaskappEntities();
        // GET: Level1
        public ActionResult Index() 
        {
            string uid = (string)Session["UserID"];
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

           
            string upline =(string) Session["UserUpline"];
            ViewModelLevel1 model=new ViewModelLevel1();
            if (int.Parse(Session["UserLevel"].ToString()) == 1)
            {
                model.Table = db.V_Sisa_Job_Valid_Qty.Where(a => a.trjob_user_id_level1 == uid).ToList();
                model.Downline = db.user_member.Where(a => a.user_upline == uid).ToList();
            }
            else
            {
                model.Table = db.V_Sisa_Job_Valid_Qty.Where(a => a.trjob_user_id_level1 == upline).ToList();
                model.Downline = null;
            }
           
                return View(model);

        }

        [HttpPost]
        public ActionResult Validasi(ValidasiViewModel V)
        {
            string uid = (string)Session["UserID"];
            Int64 idbaru = Int64.Parse(V.job_task_id) + 1;
            V.job_task_id=idbaru.ToString();
            db.ADD_TRRESULT_WI_VALIDATION(V.job_task_id, V.user_id, V.resultqty, V.validqty, uid);
            return RedirectToAction("Index","Level1");
        }
    }
}
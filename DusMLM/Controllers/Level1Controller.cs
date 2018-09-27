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
            string upline =(string) Session["UserUpline"];
            if (int.Parse(Session["UserLevel"].ToString()) == 1)
                return View(db.V_Sisa_Job_Valid_Qty.Where(a=>a.trjob_user_id_level1== uid));
            else
                return View(db.V_Sisa_Job_Valid_Qty.Where(a => a.trjob_user_id_level1 == upline));

        }

        [HttpPost]
        public ActionResult Validasi(ValidasiViewModel V)
        {
            string uid = (string)Session["UserID"];
            db.ADD_TRRESULT_WI_VALIDATION(V.job_task_id, V.user_id, V.resultqty, V.validqty, uid);
            return RedirectToAction("Index","Level1");
        }
    }
}
using DusMLM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DusMLM.Controllers
{
    public class LevelController : Controller
    {
        // GET: Level
        private jobtaskappEntities db = new jobtaskappEntities();
        [HttpGet]
        public ActionResult Index(string job_id)
        {
            if (Session["UserID"] == null)
            {
                return RedirectToAction("Index", "Login");
            }

            string id = job_id;
            var lvlmodel = new AddLvlViewModel();
            lvlmodel.job_id = job_id;
            lvlmodel.jobtree = db.V_Sisa_Job_Valid_Qty.Where(a=>a.trjob_job_taskid==job_id).ToList();
            lvlmodel.userlvl1 = db.V_user_id_level1.ToList();
            return View(lvlmodel);
        }

        [HttpPost]
        public ActionResult AddLvl(FormLvlViewModel job)
        {
           
            db.ADD_TRJOB(job.job_task_id, job.user_id, job.target_qty);
            string job_id = job.job_task_id;
            var lvlmodel = new AddLvlViewModel();
            lvlmodel.job_id = job_id;
            lvlmodel.jobtree = db.V_Sisa_Job_Valid_Qty.Where(a => a.trjob_job_taskid == job_id).ToList();
            lvlmodel.userlvl1 = db.V_user_id_level1.ToList();
            return RedirectToAction("Index", "Level",lvlmodel);
        }


    }
}
using DusMLM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace DusMLM.Controllers
{
    public class HomeController : Controller
    {
        private jobtaskappEntities db = new jobtaskappEntities();
        public ActionResult Index()
        {
            
            if (Session["UserID"] != null)
            {
               
                
                 if (int.Parse(Session["UserLevel"].ToString()) ==0)
                     return View(from job_task in db.job_task select job_task);
                else
                    return RedirectToAction("Index","Level1");
                   
            }
            return RedirectToAction("Index", "Login");
        }

        [HttpPost]
        public ActionResult AddJob(AddJobViewModel job)
        {
           
            db.ADD_JOB_TASK(job.job_name, job.job_desc, job.job_dateline, job.job_targetqty,job.job_value , Session["UserID"].ToString());
            return RedirectToAction("Index", "Home",from job_task in db.job_task select job_task);
        }
    }
}

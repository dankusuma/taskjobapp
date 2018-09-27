using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace DusMLM.Models
{
    public class AddLvlViewModel
    {
      public string job_id { get; set; }
      public  List<V_Sisa_Job_Valid_Qty> jobtree { get; set; }
      public  List<V_user_id_level1> userlvl1 { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DusMLM.Models
{
    public class AddJobViewModel
    {
        public string job_name { get; set; }
        public string job_desc { get; set; }
        public DateTime job_dateline { get; set; }
        public Int64 job_targetqty { get; set; }
        public float job_value { get; set; }
    }
}
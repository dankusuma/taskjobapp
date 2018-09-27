using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DusMLM.Models
{
    public class ValidasiViewModel
    {
        public string job_task_id { get; set; }
        public string user_id { get; set; }
        public Int64 resultqty { get; set; }
        public Int64 validqty { get; set; }
    }
}
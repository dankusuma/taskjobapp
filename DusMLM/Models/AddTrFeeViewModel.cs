using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DusMLM.Models
{
    public class AddTrFeeViewModel
    {
        public string job_task_id { get; set; }
        public Int64 fee { get; set; }
        public Int64 fee2 { get; set; }
    }
}
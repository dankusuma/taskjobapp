//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DusMLM
{
    using System;
    using System.Collections.Generic;
    
    public partial class V_Sisa_Job_Valid_Qty
    {
        public string trjob_job_taskid { get; set; }
        public string trjob_user_id_level1 { get; set; }
        public Nullable<decimal> trjob_targetqty { get; set; }
        public Nullable<decimal> trjob_realqty { get; set; }
        public Nullable<decimal> trjob_validqty { get; set; }
        public Nullable<decimal> trjob_sisatargetqty { get; set; }
        public Nullable<decimal> trjob_notvalidqty { get; set; }
        public string job_name { get; set; }
        public string job_desc { get; set; }
        public Nullable<System.DateTime> job_dateline { get; set; }
        public Nullable<int> status { get; set; }
        public int id { get; set; }
    }
}

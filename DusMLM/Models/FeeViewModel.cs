using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DusMLM.Models
{
    public class FeeViewModel
    {
        public V_Fee_Per_User FeeUser{get;set;}
        public List<V_Fee_Per_User_Job> FeeUserPerJob { get; set; }
    }
}
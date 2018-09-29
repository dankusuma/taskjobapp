using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DusMLM.Models
{
    public class RegisterViewModel
    {
        public string user_upline { get; set; }
        public string user_id { get; set; }
        public string user_name { get; set; }
        public string user_password { get; set; }
        public string user_password_confirm { get; set; }
     
    }
}
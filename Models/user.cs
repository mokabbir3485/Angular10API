using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class user
    {
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
        public string UserRole { get; set; }
        public bool Status { get; set; }
    }
}
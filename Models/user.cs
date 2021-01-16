using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblUsers")]
    public class user
    {
        [Column("User_Id")]
        public int UserId { get; set; }
        [Column("Full_Name")]
        public string FullName { get; set; }
        [Column("User_Name")]
        public string UserName { get; set; }
        [Column("Password")]
        public string Password { get; set; }
        [Column("User_Role")]
        public string UserRole { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
    }
}
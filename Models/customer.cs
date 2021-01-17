using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblCustomers")]
    public class customer
    {
        [Column("Customer_Id")]
        public int CustomerId { get; set; }
        [Column("Customer_Name")]
        public string CustomerName { get; set; }
        [Column("Customer_Phone")]
        public string CustomerPhone { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
    }
}
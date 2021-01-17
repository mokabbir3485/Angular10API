using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblCategorys")]
    public class category
    {
        [Column("Category_Id")]
        public int CategoryId { get; set; }
        [Column("Category")]
        public string Category { get; set; }
        [Column("Category_Type")]
        public string CategoryType { get; set; }
        [Column("Unit")]
        public string Unit { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
    }
}
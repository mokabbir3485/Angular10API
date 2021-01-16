using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class category
    {
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public string CategoryType { get; set; }
        public string Unit { get; set; }
        public bool Status { get; set; }
    }
}
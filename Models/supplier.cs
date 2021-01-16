using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class supplier
    {
        public int SupplierId { get; set; }
        public string Supplier { get; set; }
        public string ContactNo { get; set; }
        public string Company { get; set; }
        public string CompanyAddress { get; set; }
        public string FactoryAddress { get; set; }
        public bool Status { get; set; }
    }
}
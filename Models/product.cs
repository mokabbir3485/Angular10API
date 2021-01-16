using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class product
    {
        public int ProductId { get; set; }
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal OriginalPrice { get; set; }
        public decimal MarkupPrice { get; set; }
        public int ProductQty { get; set; }
        public bool Status { get; set; }
        public int CategoryId { get; set; }
    }
}
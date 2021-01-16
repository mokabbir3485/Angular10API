using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class order
    {
        public int OrdedrId { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderNo { get; set; }
        public int OrderQty { get; set; }
        public string OrderTotal { get; set; }
        public bool Status { get; set; }
        public string SupplierId { get; set; }
        public string ProductId { get; set; }
        

    }
}
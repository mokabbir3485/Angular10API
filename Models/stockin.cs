using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class stockin
    {
        public int StockinId { get; set; }
        public string StockinNo { get; set; }
        public DateTime DateReceived { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public decimal SubTotal { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class transaction
    {
        public int TransactionId { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Price { get; set; }
        public string TransVat { get; set; }
        public decimal TransDiscount { get; set; }
        public int TransactionQty { get; set; }
        public decimal SubTotal { get; set; }
        public bool Status { get; set; }
        public int UserId { get; set; }
        public int OrderId { get; set; }
    }
}
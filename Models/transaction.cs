using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblTransactions")]
    public class transaction
    {
        [Column("Transaction_Id")]
        public int TransactionId { get; set; }
        [Column("Invoice_No")]
        public string InvoiceNo { get; set; }
        [Column("Transaction_Date")]
        public DateTime TransactionDate { get; set; }
        [Column("Price")]
        public decimal Price { get; set; }
        [Column("Trans_Vat")]
        public string TransVat { get; set; }
        [Column("Trans_Discount")]
        public decimal TransDiscount { get; set; }
        [Column("Transaction_Qty")]
        public int TransactionQty { get; set; }
        [Column("Sub_Total")]
        public decimal SubTotal { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public user user { get; set; }
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public customer customer { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public order order { get; set; }
    }
}
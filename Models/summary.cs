using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblSummarys")]
    public class summary
    {
        [Column("Summary_Id")]
        public int SummaryId { get; set; }
        [Column("Transaction_Date")]
        public DateTime TransactionDate { get; set; }
        [Column("Invoice_No")]
        public string InvoiceNo { get; set; }
        [Column("Payment_Type")]
        public string PaymentType { get; set; }
        [Column("Trans_Discount")]
        public int TransDiscount { get; set; }
        [Column("Total_Amount")]
        public decimal TotalAmount { get; set; }
        [Column("Amount_Tendered")]
        public decimal AmountTendered { get; set; }
        [Column("Change")]
        public decimal Change { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
        public int BankId { get; set; }
        [ForeignKey("BankId")]
        public bankDetails bankDetails { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblCustomers")]
    public class bankDetails
    {
        [Column("Bank_Id")]
        public int BankId { get; set; }
        [Column("Bank_Name")]
        public string BankName { get; set; }
        [Column("Bank_Branch")]
        public string BankBranch { get; set; }
        [Column("Bank_Account_No")]
        public string BankAccountNo { get; set; }
        [Column("Bank_Account_Type")]
        public string BankAccountType { get; set; }
        [Column("Payment_Type")]
        public string PaymentType { get; set; }
        [Column("Bank_Transaction_No")]
        public string BankTransactionNo { get; set; }
        [Column("Status")]
        public bool Status { get; set; }

    }
}
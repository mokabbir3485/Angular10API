using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblStockins")]
    public class stockin
    {
        [Column("Stockin_Id")]
        public int StockinId { get; set; }
        [Column("Stockin_No")]
        public string StockinNo { get; set; }
        [Column("Date_Received")]
        public DateTime DateReceived { get; set; }
        [Column("Price")]
        public decimal Price { get; set; }
        [Column("Qty")]
        public int Qty { get; set; }
        [Column("Sub_Total")]
        public decimal SubTotal { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public user user { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public order order { get; set; }
    }
}
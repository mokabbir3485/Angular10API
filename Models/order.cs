using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblOrders")]
    public class order
    {
        [Column("Ordedr_Id")]
        public int OrdedrId { get; set; }
        [Column("Order_Date")]
        public DateTime OrderDate { get; set; }
        [Column("Order_No")]
        public string OrderNo { get; set; }
        [Column("Order_Qty")]
        public int OrderQty { get; set; }
        [Column("Order_Total")]
        public string OrderTotal { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
        public string SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public supplier supplier { get; set; }
        public string ProductId { get; set; }
        [ForeignKey("ProductId")]
        public product product { get; set; }


    }
}
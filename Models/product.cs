using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblProducts")]
    public class product
    {
        [Column("Product_Id")]
        public int ProductId { get; set; }
        [Column("Product_No")]
        public string ProductNo { get; set; }
        [Column("Product_Name")]
        public string ProductName { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Original_Price")]
        public decimal OriginalPrice { get; set; }
        [Column("Markup_Price")]
        public decimal MarkupPrice { get; set; }
        [Column("Product_Qty")]
        public int ProductQty { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("Category_Id")]
        public category category { get; set; }
    }
}
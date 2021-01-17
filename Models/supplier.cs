using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    [Table("tblSuppliers")]
    public class supplier
    {
        [Column("Supplier_Id")]
        public int SupplierId { get; set; }
        [Column("Supplier")]
        public string Supplier { get; set; }
        [Column("Contact_No")]
        public string ContactNo { get; set; }
        [Column("Company")]
        public string Company { get; set; }
        [Column("Company_Address")]
        public string CompanyAddress { get; set; }
        [Column("Factory_Address")]
        public string FactoryAddress { get; set; }
        [Column("Status")]
        public bool Status { get; set; }
    }
}
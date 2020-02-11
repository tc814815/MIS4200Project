using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200Project.Models
{
    public class orderDetail
    {
        [Key]
        public int orderdetailID { get; set; }
        public int qtyOrdered { get; set; }
        public decimal price { get; set; }
        // the next two properties link the orderDetail to the Order
        public int orderID { get; set; }
        public virtual Order Order { get; set; }
        // the next two properties link the orderDetail to the Product
        public int productID { get; set; }

        //public virtual Products Products { get; set; }
        //public virtual Products { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200Project.Models
{
    public class Products
    {
        
        public int productsID { get; set; }
        public string description { get; set; }
        public decimal unitCost { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<orderDetail> OrderDetail { get; set; }

    }
}
using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class SalesReason
    {
        public SalesReason()
        {
            this.SalesOrderHeaderSalesReasons = new List<SalesOrderHeaderSalesReason>();
        }

        public int SalesReasonID { get; set; }
        public string Name { get; set; }
        public string ReasonType { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasons { get; set; }
    }
}

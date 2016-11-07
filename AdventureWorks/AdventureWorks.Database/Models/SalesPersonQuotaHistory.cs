using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class SalesPersonQuotaHistory
    {
        public int BusinessEntityID { get; set; }
        public System.DateTime QuotaDate { get; set; }
        public decimal SalesQuota { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
    }
}

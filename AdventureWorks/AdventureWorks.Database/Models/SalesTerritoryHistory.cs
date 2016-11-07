using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class SalesTerritoryHistory
    {
        public int BusinessEntityID { get; set; }
        public int TerritoryID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual SalesTerritory SalesTerritory { get; set; }
    }
}

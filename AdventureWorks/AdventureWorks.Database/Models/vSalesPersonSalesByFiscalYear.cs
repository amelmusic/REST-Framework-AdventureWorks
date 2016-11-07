using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class vSalesPersonSalesByFiscalYear
    {
        public Nullable<int> SalesPersonID { get; set; }
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string SalesTerritory { get; set; }
        public Nullable<decimal> C2002 { get; set; }
        public Nullable<decimal> C2003 { get; set; }
        public Nullable<decimal> C2004 { get; set; }
    }
}

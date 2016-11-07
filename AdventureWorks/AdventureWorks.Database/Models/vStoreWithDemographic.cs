using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class vStoreWithDemographic
    {
        public int BusinessEntityID { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> AnnualSales { get; set; }
        public Nullable<decimal> AnnualRevenue { get; set; }
        public string BankName { get; set; }
        public string BusinessType { get; set; }
        public Nullable<int> YearOpened { get; set; }
        public string Specialty { get; set; }
        public Nullable<int> SquareFeet { get; set; }
        public string Brands { get; set; }
        public string Internet { get; set; }
        public Nullable<int> NumberEmployees { get; set; }
    }
}

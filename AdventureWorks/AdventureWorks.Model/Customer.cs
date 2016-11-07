using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.CRUDService, DefaultImplementationEnum.EntityFramework, "customers")]
    public partial class Customer
    {
        public Customer()
        {
            //this.SalesOrderHeaders = new List<SalesOrderHeader>();
            ModifiedDate = DateTime.Now;
            rowguid = Guid.NewGuid();
        }
        [Key]
        public int CustomerID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Required]
        public Nullable<int> PersonID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Required]
        public Nullable<int> StoreID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public Nullable<int> TerritoryID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Required]
        [DefaultValue("")]
        [MaxLength(10)]
        public string AccountNumber { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        [LazyLoading]
        public virtual Person Person { get; set; }
        //public virtual SalesTerritory SalesTerritory { get; set; }
        //public virtual Store Store { get; set; }
        //public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}

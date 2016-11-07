using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.ReadService, DefaultImplementationEnum.EntityFramework, "shipMethods")]
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            //this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            //this.SalesOrderHeaders = new List<SalesOrderHeader>();
            rowguid = new Guid();
        }

        [Key]
        public int ShipMethodID { get; set; }
        [Filter(FilterEnum.GreatherThanOrEqual)]
        public string Name { get; set; }
        public decimal ShipBase { get; set; }
        public decimal ShipRate { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        //public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        //public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}

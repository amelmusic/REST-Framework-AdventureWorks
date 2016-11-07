using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    //[DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.ReadService, DefaultImplementationEnum.EntityFramework, "purchaseOrderHeaders")]
    [StateMachine("PurchaseOrderHeaderStateMachine", "AdventureWorks.Model.PurchaceOrderHeaderStatusEnum", "Status")]
    public partial class PurchaseOrderHeader
    {
        public PurchaseOrderHeader()
        {
            //this.PurchaseOrderDetails = new List<PurchaseOrderDetail>();
            ModifiedDate = DateTime.Now;
        }

        [Key]
        public int PurchaseOrderID { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        public byte RevisionNumber { get; set; }
        [Filter(FilterEnum.Equal | FilterEnum.List)]
        public PurchaceOrderHeaderStatusEnum Status { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        [Filter(FilterEnum.Equal | FilterEnum.List)]
        public int EmployeeID { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        [Filter(FilterEnum.Equal | FilterEnum.List)]
        public int VendorID { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        [Filter(FilterEnum.Equal | FilterEnum.List)]
        public int ShipMethodID { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        [Filter(FilterEnum.Equal | FilterEnum.GreatherThanOrEqual | FilterEnum.LowerThanOrEqual)]
        public System.DateTime OrderDate { get; set; }

        [RequestField("Insert"), RequestField("Pending")]
        [Filter(FilterEnum.Equal | FilterEnum.GreatherThanOrEqual | FilterEnum.LowerThanOrEqual)]
        public Nullable<System.DateTime> ShipDate { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        public decimal SubTotal { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        public decimal TaxAmt { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        public decimal Freight { get; set; }
        [RequestField("Insert"), RequestField("Pending")]
        public decimal TotalDue { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        //public virtual Employee Employee { get; set; }
        //public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetails { get; set; }
        [LazyLoading]
        public virtual ShipMethod ShipMethod { get; set; }
        [LazyLoading]
        public virtual Vendor Vendor { get; set; }
    }
}

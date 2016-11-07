using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.CRUDService, DefaultImplementationEnum.EntityFramework, "purchaseOrderDetails")]
    public partial class PurchaseOrderDetail
    {
        [Key]
        public int PurchaseOrderID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public int PurchaseOrderDetailID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public System.DateTime DueDate { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public short OrderQty { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public int ProductID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public decimal UnitPrice { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public decimal LineTotal { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public decimal ReceivedQty { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public decimal RejectedQty { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public decimal StockedQty { get; set; }
        public System.DateTime ModifiedDate { get; set; }

        //public virtual Product Product { get; set; }
        public virtual PurchaseOrderHeader PurchaseOrderHeader { get; set; }
    }
}

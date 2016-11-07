using A.Core.Attributes;
using A.Core.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.CRUDService, DefaultImplementationEnum.EntityFramework, "vendors")]
    public partial class Vendor : BaseEntityWithDateTokens
    {
        public Vendor()
        {
            ActiveFlag = true;
        }

        [Key]
        [RequestField("Insert")]
        public int BusinessEntityID { get; set; }
        [Filter(FilterEnum.Equal | FilterEnum.GreatherThanOrEqual)]
        [RequestField("Insert"), RequestField("Update")]
        [Required]
        [MaxLength(15)]
        [DefaultValue("")]
        public string AccountNumber { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Required]
        [MaxLength(50)]
        [DefaultValue("")]
        public string Name { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Required]
        [Range(1, 5)]
        [DefaultValue(0)]
        public byte CreditRating { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public bool PreferredVendorStatus { get; set; }
        [RequestField("Update")]
        public bool? ActiveFlag { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [MaxLength(1024)]
        public string PurchasingWebServiceURL { get; set; }
    }
}

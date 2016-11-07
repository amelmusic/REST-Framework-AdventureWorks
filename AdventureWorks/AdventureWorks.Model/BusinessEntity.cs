using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.CRUDService, DefaultImplementationEnum.EntityFramework, "")]
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            //this.BusinessEntityAddresses = new List<BusinessEntityAddress>();
            //this.BusinessEntityContacts = new List<BusinessEntityContact>();
            rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }

        [Key]
        public int BusinessEntityID { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        //public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
        //public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        //public virtual Person Person { get; set; }
        //public virtual Store Store { get; set; }
        //public virtual Vendor Vendor { get; set; }
    }
}

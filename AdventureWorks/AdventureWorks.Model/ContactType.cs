using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.ReadService, DefaultImplementationEnum.EntityFramework, "contactTypes")]
    public partial class ContactType
    {
        public ContactType()
        {
            //this.BusinessEntityContacts = new List<BusinessEntityContact>();
        }

        [Key]
        public int ContactTypeID { get; set; }
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        //public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
    }
}

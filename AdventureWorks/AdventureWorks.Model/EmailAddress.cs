using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.CRUDService, DefaultImplementationEnum.EntityFramework, "emailAddresses")]
    public partial class EmailAddress
    {
        public EmailAddress()
        {
            rowguid = new Guid();
            ModifiedDate = DateTime.Now;
        }

        [RequestField("Insert"), RequestField("Update")]
        public int BusinessEntityID { get; set; }
        [Key]
        [RequestField("Update")]
        public int EmailAddressID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public string EmailAddress1 { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        //public virtual Person Person { get; set; }
    }
}

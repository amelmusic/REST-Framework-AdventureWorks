using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.CRUDService, DefaultImplementationEnum.EntityFramework, "persons")]
    public partial class Person
    {
        public Person()
        {
            //this.BusinessEntityContacts = new List<BusinessEntityContact>();
            //this.EmailAddresses = new List<EmailAddress>();
            //this.Customers = new List<Customer>();
            //this.PersonCreditCards = new List<PersonCreditCard>();
            //this.PersonPhones = new List<PersonPhone>();
            rowguid = Guid.NewGuid();
            ModifiedDate = DateTime.Now;
        }

        [Key]
        [RequestField("Insert")]
        public int BusinessEntityID { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Required]
        [DefaultValue("")]
        [Filter(FilterEnum.Equal)]
        public string PersonType { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public bool NameStyle { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public string Title { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Filter(FilterEnum.Equal | FilterEnum.GreatherThanOrEqual)]
        [Required]
        [DefaultValue("")]
        public string FirstName { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public string MiddleName { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        [Filter(FilterEnum.Equal | FilterEnum.GreatherThanOrEqual)]
        [Required]
        [DefaultValue("")]
        public string LastName { get; set; }
        [RequestField("Insert"), RequestField("Update")]

        public string Suffix { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public int EmailPromotion { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public string AdditionalContactInfo { get; set; }
        [RequestField("Insert"), RequestField("Update")]
        public string Demographics { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        //public virtual Employee Employee { get; set; }
        //public virtual BusinessEntity BusinessEntity { get; set; }
        //public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        [LazyLoading]
        public virtual ICollection<EmailAddress> EmailAddresses { get; set; }
        [LazyLoading]
        public virtual Password Password { get; set; }
        //public virtual ICollection<Customer> Customers { get; set; }
        //public virtual ICollection<PersonCreditCard> PersonCreditCards { get; set; }
        //public virtual ICollection<PersonPhone> PersonPhones { get; set; }
    }
}

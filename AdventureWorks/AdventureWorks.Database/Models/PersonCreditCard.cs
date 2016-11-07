using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class PersonCreditCard
    {
        public int BusinessEntityID { get; set; }
        public int CreditCardID { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Person Person { get; set; }
        public virtual CreditCard CreditCard { get; set; }
    }
}

using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.CRUDService, DefaultImplementationEnum.EntityFramework, "currencies")]
    public partial class Currency
    {
        public Currency()
        {
            //this.CountryRegionCurrencies = new List<CountryRegionCurrency>();
            //this.CurrencyRates = new List<CurrencyRate>();
            //this.CurrencyRates1 = new List<CurrencyRate>();
            ModifiedDate = DateTime.Now;
        }

        [Key]
        [Filter(FilterEnum.Equal | FilterEnum.List)]
        [RequestField("Insert"), RequestField("Update")]
        public string CurrencyCode { get; set; }
        [Filter(FilterEnum.GreatherThanOrEqual)]
        [RequestField("Insert"), RequestField("Update")]
        public string Name { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        //public virtual ICollection<CountryRegionCurrency> CountryRegionCurrencies { get; set; }
        //public virtual ICollection<CurrencyRate> CurrencyRates { get; set; }
        //public virtual ICollection<CurrencyRate> CurrencyRates1 { get; set; }
    }
}

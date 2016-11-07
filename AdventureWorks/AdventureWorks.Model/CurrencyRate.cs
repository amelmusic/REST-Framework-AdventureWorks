using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.ReadService, DefaultImplementationEnum.EntityFramework, "currencyRates")]
    public partial class CurrencyRate
    {
        [Key]
        public int CurrencyRateID { get; set; }
        public System.DateTime CurrencyRateDate { get; set; }
        [Filter(FilterEnum.Equal)]
        public string FromCurrencyCode { get; set; }
        [Filter(FilterEnum.Equal)]
        public string ToCurrencyCode { get; set; }
        public decimal AverageRate { get; set; }
        public decimal EndOfDayRate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        [LazyLoading]
        public virtual Currency FromCurrency { get; set; }
        [LazyLoading]
        public virtual Currency ToCurrency { get; set; }
    }
}

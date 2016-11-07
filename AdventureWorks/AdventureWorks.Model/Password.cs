using A.Core.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.ReadService, DefaultImplementationEnum.EntityFramework, "passwords")]
    public partial class Password
    {
        [Key]
        public int BusinessEntityID { get; set; }
        [JsonIgnore]
        public string PasswordHash { get; set; }
        [JsonIgnore]
        public string PasswordSalt { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        [LazyLoading]
        public virtual Person Person { get; set; }
    }
}

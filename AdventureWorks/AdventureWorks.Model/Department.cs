using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.ReadService, DefaultImplementationEnum.EntityFramework, "departments")]
    public partial class Department
    {
        [Key]
        [Filter(FilterEnum.List)]
        public short DepartmentID { get; set; }
        [Filter(FilterEnum.Equal | FilterEnum.GreatherThanOrEqual)]
        public string Name { get; set; }
        [Filter(FilterEnum.Equal | FilterEnum.List)]
        public string GroupName { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}

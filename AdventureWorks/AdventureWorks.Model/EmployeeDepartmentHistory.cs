using A.Core.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace  AdventureWorks.Model
{
    [Entity]
    [DefaultInterfaceBehaviour(DefaultInterfaceBehaviourEnum.ReadService, DefaultImplementationEnum.EntityFramework, "employeeDepartmentHistory")]
    public partial class EmployeeDepartmentHistory
    {
        [Key]
        public int BusinessEntityID { get; set; }
        public short DepartmentID { get; set; }
        public byte ShiftID { get; set; }
        public System.DateTime StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        [LazyLoading]
        public virtual Department Department { get; set; }
        [LazyLoading]
        public virtual Employee Employee { get; set; }
        //public virtual Shift Shift { get; set; }
    }
}

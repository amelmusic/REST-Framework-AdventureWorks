using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class Shift
    {
        public Shift()
        {
            this.EmployeeDepartmentHistories = new List<EmployeeDepartmentHistory>();
        }

        public byte ShiftID { get; set; }
        public string Name { get; set; }
        public System.TimeSpan StartTime { get; set; }
        public System.TimeSpan EndTime { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistories { get; set; }
    }
}

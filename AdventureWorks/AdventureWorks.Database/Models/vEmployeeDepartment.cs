using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class vEmployeeDepartment
    {
        public int BusinessEntityID { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public string GroupName { get; set; }
        public System.DateTime StartDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace  AdventureWorks.Model
{
    public partial class JobCandidate
    {
        public int JobCandidateID { get; set; }
        public Nullable<int> BusinessEntityID { get; set; }
        public string Resume { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
    }
}

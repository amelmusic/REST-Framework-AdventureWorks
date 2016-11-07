using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Model.Requests
{
    public partial class CustomerUpdateRequest
    {
        public PersonUpdateRequest PersonUpdateRequest { get; set; }
    }
}

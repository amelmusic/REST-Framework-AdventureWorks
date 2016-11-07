using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Model.Requests
{
    public partial class PersonUpdateRequest
    {
        public EmailAddressUpdateRequest EmailAddressUpdateRequest { get; set; }
    }
}

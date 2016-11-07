using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Model.Requests
{
    public partial class CustomerInsertRequest
    {
        /// <summary>
        /// When we insert request, we should insert person also.
        /// </summary>
        [Required]
        public PersonInsertRequest PersonInsertRequest { get; set; }
    }
}

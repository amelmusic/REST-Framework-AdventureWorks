using AdventureWorks.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services
{
    public partial class VendorService
    {
        [Dependency]
        public Lazy<IBusinessEntityService> BusinessEntityService { get; set; }

        public override Model.Vendor Insert(Model.Requests.VendorInsertRequest request, bool saveChanges = true)
        {
            if(request.BusinessEntityID == 0)
            {
                var businessEntity = BusinessEntityService.Value.Insert(new Model.Requests.BusinessEntityInsertRequest());
                request.BusinessEntityID = businessEntity.BusinessEntityID;
            }
            
            return base.Insert(request, saveChanges);
        }
    }
}

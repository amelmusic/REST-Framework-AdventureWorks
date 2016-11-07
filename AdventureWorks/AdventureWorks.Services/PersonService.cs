using AdventureWorks.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services
{
    public partial class PersonService
    {
        [Dependency]
        public Lazy<IEmailAddressService> EmailService { get; set; }
        [Dependency]
        public Lazy<IBusinessEntityService> BusinessEntityService { get; set; }

        [A.Core.Interceptors.LogInterceptor(AspectPriority = 0)]
        [A.Core.Interceptors.TransactionInterceptor(AspectPriority = 1)]
        public override AdventureWorks.Model.Person Insert(AdventureWorks.Model.Requests.PersonInsertRequest request, bool saveChanges = true)
        {
            //we need to insert business entity first and use its ID later
            var businessEntity = BusinessEntityService.Value.Insert(new Model.Requests.BusinessEntityInsertRequest());
            request.BusinessEntityID = businessEntity.BusinessEntityID;
            var person = base.Insert(request, saveChanges);
            if (request.EmailAddressInsertRequest != null)
            {
                //once we insert person, we will simply populate that field
                request.EmailAddressInsertRequest.BusinessEntityID = person.BusinessEntityID;
                EmailService.Value.Insert(request.EmailAddressInsertRequest);
            }
            return person;
        }

        [A.Core.Interceptors.LogInterceptor(AspectPriority = 0)]
        [A.Core.Interceptors.TransactionInterceptor(AspectPriority = 1)]
        public override Model.Person Update(object id, Model.Requests.PersonUpdateRequest request, bool saveChanges = true)
        {
            var person = base.Update(id, request, saveChanges);
            if (request.EmailAddressUpdateRequest != null)
            {
                request.EmailAddressUpdateRequest.BusinessEntityID = person.BusinessEntityID;
                EmailService.Value.Update(request.EmailAddressUpdateRequest.EmailAddressID, request.EmailAddressUpdateRequest);
            }
            return person;
        }
    }
}

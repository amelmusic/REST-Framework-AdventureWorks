using AdventureWorks.Interfaces;
using AdventureWorks.Model;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorks.Services
{
    public partial class CustomerService
    {
        const string PERSON_TYPE = "IN";

        [Dependency]
        public Lazy<IPersonService> PersonService { get; set; }

        [A.Core.Interceptors.LogInterceptor(AspectPriority = 0)]
        [A.Core.Interceptors.TransactionInterceptor(AspectPriority = 1)]
        public override AdventureWorks.Model.Customer Insert(AdventureWorks.Model.Requests.CustomerInsertRequest request, bool saveChanges = true)
        {           
            if(request.PersonInsertRequest != null)
            {
                request.PersonInsertRequest.PersonType = PERSON_TYPE;
                var person = PersonService.Value.Insert(request.PersonInsertRequest);
                request.PersonID = person.BusinessEntityID;
            }
            return base.Insert(request, saveChanges);
        }

        public override Customer Update(object id, Model.Requests.CustomerUpdateRequest request, bool saveChanges = true)
        {
            if(request.PersonUpdateRequest != null)
            {
                var customer = Get(id);
                PersonService.Value.Update(customer.PersonID.Value, request.PersonUpdateRequest);
            }
            return base.Update(id, request, saveChanges);
        }

        protected override void AddFilter(Model.SearchObjects.CustomerSearchObject search, ref IQueryable<Customer> query)
        {
            //mandatory filter
            query = query.Where(x => x.Person.PersonType == PERSON_TYPE);
            base.AddFilter(search, ref query);
        }
    }
}

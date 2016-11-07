









using System.Net;
using System.Net.Http;
using System.Web.Http;

using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace AdventureWorks.WebAPI.Controllers
{
    public partial class EndpointModel
	{
		public EndpointModel()
		{
			Links = new Dictionary<string, string>();
		}
		public Dictionary<string, string> Links {get; set;}
	}
	[RoutePrefix("")]
    public class endpointsController : ApiController
    {
        [Route("")]
        public HttpResponseMessage Get()
        {
            EndpointModel model = new EndpointModel();
            
            var apiDescriptions = Configuration.Services.GetApiExplorer().ApiDescriptions;
            foreach (var description in apiDescriptions.ToList())
            {
                var route = Url.Request.RequestUri.AbsoluteUri;
                var path = route + description.RelativePath;
                var controller = description.ActionDescriptor.ControllerDescriptor.ControllerName;
                string key = string.Format("{1}", "", description.RelativePath.Replace('/', '_').Replace("{id}","id"), description.HttpMethod.Method.ToLower());

                    if(key == controller + "_get")
                    {
                        key = controller;
                    }
                    if (!model.Links.ContainsKey(key))
                    {
                        model.Links[key] = path;
                    }

            }

            
            var resp = Request.CreateResponse<EndpointModel>(HttpStatusCode.OK, model);
           
            return resp;
        }
    }
}


namespace AdventureWorks.WebAPI.Controllers 
{ 
[RoutePrefix("customers")]
public partial class customersController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.ICustomerService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.ICustomerService
//metoda: Insert
//Generating template for Insert for: Insert

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Customer))]
				[System.Web.Http.HttpPost]
				public HttpResponseMessage  Insert([FromBody]AdventureWorks.Model.Requests.CustomerInsertRequest request)
				{
					var result = Service.Insert(request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Customer>(HttpStatusCode.Created, result);
					return response;
				}
//metoda: Update
//Generating template for Update for: Update

				[Route("{id}")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Customer))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Update([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.CustomerUpdateRequest request)
				{
					var result = Service.Update(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Customer>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Customer))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.CustomerAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.Customer>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.CustomerSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("vendors")]
public partial class vendorsController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IVendorService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IVendorService
//metoda: Insert
//Generating template for Insert for: Insert

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Vendor))]
				[System.Web.Http.HttpPost]
				public HttpResponseMessage  Insert([FromBody]AdventureWorks.Model.Requests.VendorInsertRequest request)
				{
					var result = Service.Insert(request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Vendor>(HttpStatusCode.Created, result);
					return response;
				}
//metoda: Update
//Generating template for Update for: Update

				[Route("{id}")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Vendor))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Update([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.VendorUpdateRequest request)
				{
					var result = Service.Update(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Vendor>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Vendor))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.VendorAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.Vendor>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.VendorSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("shipMethods")]
public partial class shipMethodsController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IShipMethodService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IShipMethodService
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.ShipMethod))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.ShipMethodAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.ShipMethod>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.ShipMethodSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("purchaseOrderDetails")]
public partial class purchaseOrderDetailsController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IPurchaseOrderDetailService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IPurchaseOrderDetailService
//metoda: Insert
//Generating template for Insert for: Insert

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderDetail))]
				[System.Web.Http.HttpPost]
				public HttpResponseMessage  Insert([FromBody]AdventureWorks.Model.Requests.PurchaseOrderDetailInsertRequest request)
				{
					var result = Service.Insert(request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.PurchaseOrderDetail>(HttpStatusCode.Created, result);
					return response;
				}
//metoda: Update
//Generating template for Update for: Update

				[Route("{id}")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderDetail))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Update([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.PurchaseOrderDetailUpdateRequest request)
				{
					var result = Service.Update(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.PurchaseOrderDetail>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderDetail))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.PurchaseOrderDetailAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.PurchaseOrderDetail>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.PurchaseOrderDetailSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("purchaseOrderHeaders")]
public partial class purchaseOrderHeadersController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IPurchaseOrderHeaderService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IPurchaseOrderHeaderService
//metoda: Insert
//Generating template for Insert for: Insert

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderHeader))]
				[System.Web.Http.HttpPost]
				public HttpResponseMessage  Insert([FromBody]AdventureWorks.Model.Requests.PurchaseOrderHeaderInsertRequest request)
				{
					var result = Service.Insert(request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.PurchaseOrderHeader>(HttpStatusCode.Created, result);
					return response;
				}
//metoda: Approve
//Generating template for Update for: Approve

				[Route("{id}/Approve")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderHeader))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Approve([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.PurchaseOrderHeaderApproveRequest request)
				{
					var result = Service.Approve(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.PurchaseOrderHeader>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Pending
//Generating template for Update for: Pending

				[Route("{id}/Pending")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderHeader))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Pending([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.PurchaseOrderHeaderPendingRequest request)
				{
					var result = Service.Pending(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.PurchaseOrderHeader>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Reject
//Generating template for Update for: Reject

				[Route("{id}/Reject")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderHeader))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Reject([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.PurchaseOrderHeaderRejectRequest request)
				{
					var result = Service.Reject(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.PurchaseOrderHeader>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Complete
//Generating template for Update for: Complete

				[Route("{id}/Complete")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderHeader))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Complete([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.PurchaseOrderHeaderCompleteRequest request)
				{
					var result = Service.Complete(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.PurchaseOrderHeader>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.PurchaseOrderHeader))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.PurchaseOrderHeader>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("departments")]
public partial class departmentsController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IDepartmentService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IDepartmentService
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Department))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int16 id, [FromUri]AdventureWorks.Model.SearchObjects.DepartmentAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.Department>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.DepartmentSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("employeeDepartmentHistory")]
public partial class employeeDepartmentHistoryController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IEmployeeDepartmentHistoryService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IEmployeeDepartmentHistoryService
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.EmployeeDepartmentHistory))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistoryAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.EmployeeDepartmentHistory>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistorySearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("emailAddresses")]
public partial class emailAddressesController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IEmailAddressService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IEmailAddressService
//metoda: Insert
//Generating template for Insert for: Insert

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.EmailAddress))]
				[System.Web.Http.HttpPost]
				public HttpResponseMessage  Insert([FromBody]AdventureWorks.Model.Requests.EmailAddressInsertRequest request)
				{
					var result = Service.Insert(request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.EmailAddress>(HttpStatusCode.Created, result);
					return response;
				}
//metoda: Update
//Generating template for Update for: Update

				[Route("{id}")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.EmailAddress))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Update([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.EmailAddressUpdateRequest request)
				{
					var result = Service.Update(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.EmailAddress>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.EmailAddress))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.EmailAddressAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.EmailAddress>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.EmailAddressSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("employees")]
public partial class employeesController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IEmployeeService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IEmployeeService
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Employee))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.EmployeeAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.Employee>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.EmployeeSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("passwords")]
public partial class passwordsController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IPasswordService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IPasswordService
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Password))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.PasswordAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.Password>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.PasswordSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("persons")]
public partial class personsController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IPersonService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IPersonService
//metoda: Insert
//Generating template for Insert for: Insert

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Person))]
				[System.Web.Http.HttpPost]
				public HttpResponseMessage  Insert([FromBody]AdventureWorks.Model.Requests.PersonInsertRequest request)
				{
					var result = Service.Insert(request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Person>(HttpStatusCode.Created, result);
					return response;
				}
//metoda: Update
//Generating template for Update for: Update

				[Route("{id}")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Person))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Update([FromUri]System.Int32 id,[FromBody]AdventureWorks.Model.Requests.PersonUpdateRequest request)
				{
					var result = Service.Update(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Person>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Person))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.PersonAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.Person>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.PersonSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("currencies")]
public partial class currenciesController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.ICurrencyService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.ICurrencyService
//metoda: Insert
//Generating template for Insert for: Insert

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Currency))]
				[System.Web.Http.HttpPost]
				public HttpResponseMessage  Insert([FromBody]AdventureWorks.Model.Requests.CurrencyInsertRequest request)
				{
					var result = Service.Insert(request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Currency>(HttpStatusCode.Created, result);
					return response;
				}
//metoda: Update
//Generating template for Update for: Update

				[Route("{id}")]
				[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Currency))]
				[System.Web.Http.HttpPut]
				public HttpResponseMessage  Update([FromUri]System.String id,[FromBody]AdventureWorks.Model.Requests.CurrencyUpdateRequest request)
				{
					var result = Service.Update(id,request);					 
					var response = Request.CreateResponse<AdventureWorks.Model.Currency>(HttpStatusCode.OK, result);
					return response;
				}
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.Currency))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.String id, [FromUri]AdventureWorks.Model.SearchObjects.CurrencyAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.Currency>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.CurrencySearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("currencyRates")]
public partial class currencyRatesController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.ICurrencyRateService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.ICurrencyRateService
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.CurrencyRate))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.CurrencyRateAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.CurrencyRate>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.CurrencyRateSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

[RoutePrefix("contactTypes")]
public partial class contactTypesController : System.Web.Http.ApiController
{
	[Microsoft.Practices.Unity.Dependency]
	public AdventureWorks.Interfaces.IContactTypeService Service { get; set; }
	
	//Getting all methods for:AdventureWorks.Interfaces.IContactTypeService
//metoda: Get
//Generating template for GetById for: Get

					[Route("{id}")]
					[System.Web.Http.Description.ResponseType(typeof(AdventureWorks.Model.ContactType))]
					[System.Web.Http.HttpGet]
					public System.Web.Http.IHttpActionResult  Get(System.Int32 id, [FromUri]AdventureWorks.Model.SearchObjects.ContactTypeAdditionalSearchRequestData additionalData)
					{
						var result = Service.Get(id, additionalData);
						if(result == null)
						{
							return NotFound();
						}
						else
						{
							return Ok(result);
						}
					}
//metoda: GetPage
//Generating template for Get for: GetPage

				[Route("")]
				[System.Web.Http.Description.ResponseType(typeof(A.Core.Model.PagedResult<AdventureWorks.Model.ContactType>))]
				[System.Web.Http.HttpGet]
				public System.Web.Http.IHttpActionResult  GetPage([FromUri]AdventureWorks.Model.SearchObjects.ContactTypeSearchObject search)
				{
					var result = Service.GetPage(search);
					return Ok(result);
				}
//metoda: BeginTransaction
//metoda: CommitTransaction
//metoda: DisposeTransaction
//metoda: RollbackTransaction



	}

}

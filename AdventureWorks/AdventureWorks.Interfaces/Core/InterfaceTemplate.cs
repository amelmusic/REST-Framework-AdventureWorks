




using System.Collections.Generic;
using A.Core.Interface;
using A.Core.Attributes;
using AdventureWorks.Model;
//Requests section
namespace AdventureWorks.Interfaces
{
	//Creating interfaces from model...14
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "purchaseOrderDetails")]
		public partial interface IPurchaseOrderDetailService : ICRUDService<AdventureWorks.Model.PurchaseOrderDetail, AdventureWorks.Model.SearchObjects.PurchaseOrderDetailSearchObject, AdventureWorks.Model.SearchObjects.PurchaseOrderDetailAdditionalSearchRequestData, AdventureWorks.Model.Requests.PurchaseOrderDetailInsertRequest, AdventureWorks.Model.Requests.PurchaseOrderDetailUpdateRequest>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "employeeDepartmentHistory")]
		public partial interface IEmployeeDepartmentHistoryService : IReadService<AdventureWorks.Model.EmployeeDepartmentHistory, AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistorySearchObject, AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistoryAdditionalSearchRequestData>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "customers")]
		public partial interface ICustomerService : ICRUDService<AdventureWorks.Model.Customer, AdventureWorks.Model.SearchObjects.CustomerSearchObject, AdventureWorks.Model.SearchObjects.CustomerAdditionalSearchRequestData, AdventureWorks.Model.Requests.CustomerInsertRequest, AdventureWorks.Model.Requests.CustomerUpdateRequest>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "passwords")]
		public partial interface IPasswordService : IReadService<AdventureWorks.Model.Password, AdventureWorks.Model.SearchObjects.PasswordSearchObject, AdventureWorks.Model.SearchObjects.PasswordAdditionalSearchRequestData>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "shipMethods")]
		public partial interface IShipMethodService : IReadService<AdventureWorks.Model.ShipMethod, AdventureWorks.Model.SearchObjects.ShipMethodSearchObject, AdventureWorks.Model.SearchObjects.ShipMethodAdditionalSearchRequestData>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "departments")]
		public partial interface IDepartmentService : IReadService<AdventureWorks.Model.Department, AdventureWorks.Model.SearchObjects.DepartmentSearchObject, AdventureWorks.Model.SearchObjects.DepartmentAdditionalSearchRequestData>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "currencyRates")]
		public partial interface ICurrencyRateService : IReadService<AdventureWorks.Model.CurrencyRate, AdventureWorks.Model.SearchObjects.CurrencyRateSearchObject, AdventureWorks.Model.SearchObjects.CurrencyRateAdditionalSearchRequestData>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "persons")]
		public partial interface IPersonService : ICRUDService<AdventureWorks.Model.Person, AdventureWorks.Model.SearchObjects.PersonSearchObject, AdventureWorks.Model.SearchObjects.PersonAdditionalSearchRequestData, AdventureWorks.Model.Requests.PersonInsertRequest, AdventureWorks.Model.Requests.PersonUpdateRequest>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "emailAddresses")]
		public partial interface IEmailAddressService : ICRUDService<AdventureWorks.Model.EmailAddress, AdventureWorks.Model.SearchObjects.EmailAddressSearchObject, AdventureWorks.Model.SearchObjects.EmailAddressAdditionalSearchRequestData, AdventureWorks.Model.Requests.EmailAddressInsertRequest, AdventureWorks.Model.Requests.EmailAddressUpdateRequest>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "currencies")]
		public partial interface ICurrencyService : ICRUDService<AdventureWorks.Model.Currency, AdventureWorks.Model.SearchObjects.CurrencySearchObject, AdventureWorks.Model.SearchObjects.CurrencyAdditionalSearchRequestData, AdventureWorks.Model.Requests.CurrencyInsertRequest, AdventureWorks.Model.Requests.CurrencyUpdateRequest>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "vendors")]
		public partial interface IVendorService : ICRUDService<AdventureWorks.Model.Vendor, AdventureWorks.Model.SearchObjects.VendorSearchObject, AdventureWorks.Model.SearchObjects.VendorAdditionalSearchRequestData, AdventureWorks.Model.Requests.VendorInsertRequest, AdventureWorks.Model.Requests.VendorUpdateRequest>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "contactTypes")]
		public partial interface IContactTypeService : IReadService<AdventureWorks.Model.ContactType, AdventureWorks.Model.SearchObjects.ContactTypeSearchObject, AdventureWorks.Model.SearchObjects.ContactTypeAdditionalSearchRequestData>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "")]
		public partial interface IBusinessEntityService : ICRUDService<AdventureWorks.Model.BusinessEntity, AdventureWorks.Model.SearchObjects.BusinessEntitySearchObject, AdventureWorks.Model.SearchObjects.BusinessEntityAdditionalSearchRequestData, AdventureWorks.Model.Requests.BusinessEntityInsertRequest, AdventureWorks.Model.Requests.BusinessEntityUpdateRequest>
		{
		
		}
		[DefaultServiceBehaviour(DefaultImplementationEnum.EntityFramework, "employees")]
		public partial interface IEmployeeService : IReadService<AdventureWorks.Model.Employee, AdventureWorks.Model.SearchObjects.EmployeeSearchObject, AdventureWorks.Model.SearchObjects.EmployeeAdditionalSearchRequestData>
		{
		
		}

}























using System.Linq;
using Microsoft.Practices.Unity;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System;
using System.Collections.Generic;
using A.Core.Interface;

	
//AdventureWorks.Interfaces
using AdventureWorks.Model;
using AdventureWorks.Model.Requests;


namespace AdventureWorks.Services 
	{ 
	public partial class ServicesRegistration : A.Core.Interface.IServicesRegistration
	{
		public int Priority {get; set; }
		public ServicesRegistration()
		{
			Priority = 0; //This is root, If you want to override this. Add new class with higher priority
		}
		public void Register(ref Microsoft.Practices.Unity.UnityContainer container)
		{
		container.RegisterType<AdventureWorks.Interfaces.IBusinessEntityService, BusinessEntityService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.ICustomerService, CustomerService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IVendorService, VendorService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IShipMethodService, ShipMethodService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IPurchaseOrderDetailService, PurchaseOrderDetailService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IPurchaseOrderHeaderService, PurchaseOrderHeaderService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IDepartmentService, DepartmentService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IEmployeeDepartmentHistoryService, EmployeeDepartmentHistoryService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IEmailAddressService, EmailAddressService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IEmployeeService, EmployeeService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IPasswordService, PasswordService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IPersonService, PersonService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.ICurrencyService, CurrencyService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.ICurrencyRateService, CurrencyRateService>(new HierarchicalLifetimeManager());
	container.RegisterType<AdventureWorks.Interfaces.IContactTypeService, ContactTypeService>(new HierarchicalLifetimeManager());
		}
	}

	public partial class Context : System.Data.Entity.DbContext
	{
			public Context()
	            : base("Context")
	        {
	            this.Configuration.LazyLoadingEnabled = false;
	        }
	
		public System.Data.Entity.DbSet<AdventureWorks.Model.PurchaseOrderHeader> PurchaseOrderHeader { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.PurchaseOrderDetail> PurchaseOrderDetail { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.Customer> Customer { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.Password> Password { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.ShipMethod> ShipMethod { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.Department> Department { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.CurrencyRate> CurrencyRate { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.Person> Person { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.EmailAddress> EmailAddress { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.Currency> Currency { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.Vendor> Vendor { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.ContactType> ContactType { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.BusinessEntity> BusinessEntity { get; set; }
	public System.Data.Entity.DbSet<AdventureWorks.Model.Employee> Employee { get; set; }
	
		protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
	        {
			modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.BusinessEntityMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.CustomerMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.VendorMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.ShipMethodMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.PurchaseOrderDetailMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.PurchaseOrderHeaderMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.EmployeeDepartmentHistoryMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.DepartmentMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.EmailAddressMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.EmployeeMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.PasswordMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.PersonMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.CurrencyMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.CurrencyRateMap());
	modelBuilder.Configurations.Add(new AdventureWorks.Services.Mapping.ContactTypeMap());
			}
	
			public partial class ContextInitializer : IDatabaseInitializer<Context>
			{
				public void InitializeDatabase(Context context)
				{
					if (!context.Database.Exists())
					{
						context.Database.Create();
					}
				}
			}
	
	}

	public partial class BusinessEntityService : AdventureWorks.Services.Core.BaseEFBasedCRUDService<AdventureWorks.Model.BusinessEntity,AdventureWorks.Model.SearchObjects.BusinessEntitySearchObject,AdventureWorks.Model.SearchObjects.BusinessEntityAdditionalSearchRequestData,AdventureWorks.Model.Requests.BusinessEntityInsertRequest,AdventureWorks.Model.Requests.BusinessEntityUpdateRequest, Context>, AdventureWorks.Interfaces.IBusinessEntityService
	{
	
		//ElapsedEFSingle getBaseClassName: BusinessEntityService:38
	//ElapsedEFSingle Get base interfaces: BusinessEntityService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: BusinessEntityService:2
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.BusinessEntitySearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.BusinessEntity> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.BusinessEntityID.HasValue)
								{
										query = query.Where(x => x.BusinessEntityID == search.BusinessEntityID);
								}
								
						}
					
	//ElapsedEFSingle filter for: BusinessEntityService:9
	//PropertyName: BusinessEntityID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.BusinessEntityAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.BusinessEntityAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.BusinessEntity Get(object id, AdventureWorks.Model.SearchObjects.BusinessEntityAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.BusinessEntitySearchObject search = new AdventureWorks.Model.SearchObjects.BusinessEntitySearchObject();
	                                    search.BusinessEntityID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: BusinessEntityService:3
	//ElapsedEFSingle get methods for: BusinessEntityService:19
	}
	//ElapsedEFSingle for: BusinessEntityService:0
	public partial class CustomerService : AdventureWorks.Services.Core.BaseEFBasedCRUDService<AdventureWorks.Model.Customer,AdventureWorks.Model.SearchObjects.CustomerSearchObject,AdventureWorks.Model.SearchObjects.CustomerAdditionalSearchRequestData,AdventureWorks.Model.Requests.CustomerInsertRequest,AdventureWorks.Model.Requests.CustomerUpdateRequest, Context>, AdventureWorks.Interfaces.ICustomerService
	{
	
		//ElapsedEFSingle getBaseClassName: CustomerService:3
	//ElapsedEFSingle Get base interfaces: CustomerService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: CustomerService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.CustomerSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.Customer> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.CustomerID.HasValue)
								{
										query = query.Where(x => x.CustomerID == search.CustomerID);
								}
								
						}
					
	//ElapsedEFSingle filter for: CustomerService:3
	//PropertyName: CustomerID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.CustomerAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.CustomerAdditionalSearchRequestData search)
						{
							if(search.IsPersonLoadingEnabled.HasValue && search.IsPersonLoadingEnabled == true)
									{
										search.IncludeList.Add("Person");
									}
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.Customer Get(object id, AdventureWorks.Model.SearchObjects.CustomerAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.CustomerSearchObject search = new AdventureWorks.Model.SearchObjects.CustomerSearchObject();
	                                    search.CustomerID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: CustomerService:2
	//ElapsedEFSingle get methods for: CustomerService:4
	}
	//ElapsedEFSingle for: CustomerService:0
	public partial class VendorService : AdventureWorks.Services.Core.BaseEFBasedCRUDService<AdventureWorks.Model.Vendor,AdventureWorks.Model.SearchObjects.VendorSearchObject,AdventureWorks.Model.SearchObjects.VendorAdditionalSearchRequestData,AdventureWorks.Model.Requests.VendorInsertRequest,AdventureWorks.Model.Requests.VendorUpdateRequest, Context>, AdventureWorks.Interfaces.IVendorService
	{
	
		//ElapsedEFSingle getBaseClassName: VendorService:2
	//ElapsedEFSingle Get base interfaces: VendorService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: VendorService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.VendorSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.Vendor> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(!string.IsNullOrWhiteSpace(search.AccountNumber))
								{
									query = query.Where(x => x.AccountNumber == search.AccountNumber);
	
								}
								if(!string.IsNullOrWhiteSpace(search.AccountNumberGTE))
								{
									query = query.Where(x => x.AccountNumber.StartsWith(search.AccountNumberGTE));
	
								}
								if(search.BusinessEntityID.HasValue)
								{
										query = query.Where(x => x.BusinessEntityID == search.BusinessEntityID);
								}
								
						}
					
	//ElapsedEFSingle filter for: VendorService:7
	//PropertyName: AccountNumber
	//PropertyName: AccountNumberGTE
	//PropertyName: BusinessEntityID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.VendorAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.VendorAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.Vendor Get(object id, AdventureWorks.Model.SearchObjects.VendorAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.VendorSearchObject search = new AdventureWorks.Model.SearchObjects.VendorSearchObject();
	                                    search.BusinessEntityID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: VendorService:3
	//ElapsedEFSingle get methods for: VendorService:5
	}
	//ElapsedEFSingle for: VendorService:0
	public partial class ShipMethodService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.ShipMethod,AdventureWorks.Model.SearchObjects.ShipMethodSearchObject,AdventureWorks.Model.SearchObjects.ShipMethodAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.IShipMethodService
	{
	
		//ElapsedEFSingle getBaseClassName: ShipMethodService:12
	//ElapsedEFSingle Get base interfaces: ShipMethodService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: ShipMethodService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.ShipMethodSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.ShipMethod> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(!string.IsNullOrWhiteSpace(search.NameGTE))
								{
									query = query.Where(x => x.Name.StartsWith(search.NameGTE));
	
								}
								if(search.ShipMethodID.HasValue)
								{
										query = query.Where(x => x.ShipMethodID == search.ShipMethodID);
								}
								
						}
					
	//ElapsedEFSingle filter for: ShipMethodService:5
	//PropertyName: NameGTE
	//PropertyName: ShipMethodID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.ShipMethodAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.ShipMethodAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.ShipMethod Get(object id, AdventureWorks.Model.SearchObjects.ShipMethodAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.ShipMethodSearchObject search = new AdventureWorks.Model.SearchObjects.ShipMethodSearchObject();
	                                    search.ShipMethodID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: ShipMethodService:2
	//ElapsedEFSingle get methods for: ShipMethodService:2
	}
	//ElapsedEFSingle for: ShipMethodService:0
	public partial class PurchaseOrderDetailService : AdventureWorks.Services.Core.BaseEFBasedCRUDService<AdventureWorks.Model.PurchaseOrderDetail,AdventureWorks.Model.SearchObjects.PurchaseOrderDetailSearchObject,AdventureWorks.Model.SearchObjects.PurchaseOrderDetailAdditionalSearchRequestData,AdventureWorks.Model.Requests.PurchaseOrderDetailInsertRequest,AdventureWorks.Model.Requests.PurchaseOrderDetailUpdateRequest, Context>, AdventureWorks.Interfaces.IPurchaseOrderDetailService
	{
	
		//ElapsedEFSingle getBaseClassName: PurchaseOrderDetailService:2
	//ElapsedEFSingle Get base interfaces: PurchaseOrderDetailService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: PurchaseOrderDetailService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.PurchaseOrderDetailSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.PurchaseOrderDetail> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.PurchaseOrderID.HasValue)
								{
										query = query.Where(x => x.PurchaseOrderID == search.PurchaseOrderID);
								}
								
						}
					
	//ElapsedEFSingle filter for: PurchaseOrderDetailService:4
	//PropertyName: PurchaseOrderID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.PurchaseOrderDetailAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.PurchaseOrderDetailAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.PurchaseOrderDetail Get(object id, AdventureWorks.Model.SearchObjects.PurchaseOrderDetailAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.PurchaseOrderDetailSearchObject search = new AdventureWorks.Model.SearchObjects.PurchaseOrderDetailSearchObject();
	                                    search.PurchaseOrderID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: PurchaseOrderDetailService:2
	//ElapsedEFSingle get methods for: PurchaseOrderDetailService:3
	}
	//ElapsedEFSingle for: PurchaseOrderDetailService:0
	public partial class PurchaseOrderHeaderService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.PurchaseOrderHeader,AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderSearchObject,AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.IPurchaseOrderHeaderService
	{
	
		//ElapsedEFSingle getBaseClassName: PurchaseOrderHeaderService:3
	//ElapsedEFSingle Get base interfaces: PurchaseOrderHeaderService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: PurchaseOrderHeaderService:2
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.PurchaseOrderHeader> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.Status.HasValue)
								{
										query = query.Where(x => x.Status == search.Status);
								}
								if(search.StatusList != null && search.StatusList.Count > 0)
								{
									query = query.Where(x => search.StatusList.Contains(x.Status));
	
								}
								if(search.EmployeeID.HasValue)
								{
										query = query.Where(x => x.EmployeeID == search.EmployeeID);
								}
								if(search.EmployeeIDList != null && search.EmployeeIDList.Count > 0)
								{
									query = query.Where(x => search.EmployeeIDList.Contains(x.EmployeeID));
	
								}
								if(search.VendorID.HasValue)
								{
										query = query.Where(x => x.VendorID == search.VendorID);
								}
								if(search.VendorIDList != null && search.VendorIDList.Count > 0)
								{
									query = query.Where(x => search.VendorIDList.Contains(x.VendorID));
	
								}
								if(search.ShipMethodID.HasValue)
								{
										query = query.Where(x => x.ShipMethodID == search.ShipMethodID);
								}
								if(search.ShipMethodIDList != null && search.ShipMethodIDList.Count > 0)
								{
									query = query.Where(x => search.ShipMethodIDList.Contains(x.ShipMethodID));
	
								}
								if(search.OrderDate.HasValue)
								{
										query = query.Where(x => x.OrderDate == search.OrderDate);
								}
								if(search.OrderDateGTE.HasValue)
								{
									query = query.Where(x => x.OrderDate >= search.OrderDateGTE);
	
								}
								if(search.OrderDateLTE.HasValue)
								{
									query = query.Where(x => x.OrderDate <= search.OrderDateLTE);
	
								}
								if(search.ShipDate.HasValue)
								{
										query = query.Where(x => x.ShipDate == search.ShipDate);
								}
								if(search.ShipDateGTE.HasValue)
								{
									query = query.Where(x => x.ShipDate >= search.ShipDateGTE);
	
								}
								if(search.ShipDateLTE.HasValue)
								{
									query = query.Where(x => x.ShipDate <= search.ShipDateLTE);
	
								}
								if(search.PurchaseOrderID.HasValue)
								{
										query = query.Where(x => x.PurchaseOrderID == search.PurchaseOrderID);
								}
								
						}
					
	//ElapsedEFSingle filter for: PurchaseOrderHeaderService:58
	//PropertyName: Status
	//PropertyName: StatusList
	//PropertyName: EmployeeID
	//PropertyName: EmployeeIDList
	//PropertyName: VendorID
	//PropertyName: VendorIDList
	//PropertyName: ShipMethodID
	//PropertyName: ShipMethodIDList
	//PropertyName: OrderDate
	//PropertyName: OrderDateGTE
	//PropertyName: OrderDateLTE
	//PropertyName: ShipDate
	//PropertyName: ShipDateGTE
	//PropertyName: ShipDateLTE
	//PropertyName: PurchaseOrderID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderAdditionalSearchRequestData search)
						{
							if(search.IsShipMethodLoadingEnabled.HasValue && search.IsShipMethodLoadingEnabled == true)
									{
										search.IncludeList.Add("ShipMethod");
									}if(search.IsVendorLoadingEnabled.HasValue && search.IsVendorLoadingEnabled == true)
									{
										search.IncludeList.Add("Vendor");
									}
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.PurchaseOrderHeader Get(object id, AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderSearchObject search = new AdventureWorks.Model.SearchObjects.PurchaseOrderHeaderSearchObject();
	                                    search.PurchaseOrderID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: PurchaseOrderHeaderService:7
	//ElapsedEFSingle get methods for: PurchaseOrderHeaderService:3
	}
	//ElapsedEFSingle for: PurchaseOrderHeaderService:5
	public partial class DepartmentService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.Department,AdventureWorks.Model.SearchObjects.DepartmentSearchObject,AdventureWorks.Model.SearchObjects.DepartmentAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.IDepartmentService
	{
	
		//ElapsedEFSingle getBaseClassName: DepartmentService:4
	//ElapsedEFSingle Get base interfaces: DepartmentService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: DepartmentService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.DepartmentSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.Department> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.DepartmentIDList != null && search.DepartmentIDList.Count > 0)
								{
									query = query.Where(x => search.DepartmentIDList.Contains(x.DepartmentID));
	
								}
								if(!string.IsNullOrWhiteSpace(search.Name))
								{
									query = query.Where(x => x.Name == search.Name);
	
								}
								if(!string.IsNullOrWhiteSpace(search.NameGTE))
								{
									query = query.Where(x => x.Name.StartsWith(search.NameGTE));
	
								}
								if(!string.IsNullOrWhiteSpace(search.GroupName))
								{
									query = query.Where(x => x.GroupName == search.GroupName);
	
								}
								if(search.GroupNameList != null && search.GroupNameList.Count > 0)
								{
									query = query.Where(x => search.GroupNameList.Contains(x.GroupName));
	
								}
								if(search.DepartmentID.HasValue)
								{
										query = query.Where(x => x.DepartmentID == search.DepartmentID);
								}
								
						}
					
	//ElapsedEFSingle filter for: DepartmentService:13
	//PropertyName: DepartmentIDList
	//PropertyName: Name
	//PropertyName: NameGTE
	//PropertyName: GroupName
	//PropertyName: GroupNameList
	//PropertyName: DepartmentID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.DepartmentAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.DepartmentAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.Department Get(object id, AdventureWorks.Model.SearchObjects.DepartmentAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.DepartmentSearchObject search = new AdventureWorks.Model.SearchObjects.DepartmentSearchObject();
	                                    search.DepartmentID = (System.Nullable<System.Int16>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: DepartmentService:4
	//ElapsedEFSingle get methods for: DepartmentService:1
	}
	//ElapsedEFSingle for: DepartmentService:0
	public partial class EmployeeDepartmentHistoryService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.EmployeeDepartmentHistory,AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistorySearchObject,AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistoryAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.IEmployeeDepartmentHistoryService
	{
	
		//ElapsedEFSingle getBaseClassName: EmployeeDepartmentHistoryService:2
	//ElapsedEFSingle Get base interfaces: EmployeeDepartmentHistoryService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: EmployeeDepartmentHistoryService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistorySearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.EmployeeDepartmentHistory> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.BusinessEntityID.HasValue)
								{
										query = query.Where(x => x.BusinessEntityID == search.BusinessEntityID);
								}
								
						}
					
	//ElapsedEFSingle filter for: EmployeeDepartmentHistoryService:4
	//PropertyName: BusinessEntityID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistoryAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistoryAdditionalSearchRequestData search)
						{
							if(search.IsDepartmentLoadingEnabled.HasValue && search.IsDepartmentLoadingEnabled == true)
									{
										search.IncludeList.Add("Department");
									}if(search.IsEmployeeLoadingEnabled.HasValue && search.IsEmployeeLoadingEnabled == true)
									{
										search.IncludeList.Add("Employee");
									}
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.EmployeeDepartmentHistory Get(object id, AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistoryAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistorySearchObject search = new AdventureWorks.Model.SearchObjects.EmployeeDepartmentHistorySearchObject();
	                                    search.BusinessEntityID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: EmployeeDepartmentHistoryService:10
	//ElapsedEFSingle get methods for: EmployeeDepartmentHistoryService:2
	}
	//ElapsedEFSingle for: EmployeeDepartmentHistoryService:0
	public partial class EmailAddressService : AdventureWorks.Services.Core.BaseEFBasedCRUDService<AdventureWorks.Model.EmailAddress,AdventureWorks.Model.SearchObjects.EmailAddressSearchObject,AdventureWorks.Model.SearchObjects.EmailAddressAdditionalSearchRequestData,AdventureWorks.Model.Requests.EmailAddressInsertRequest,AdventureWorks.Model.Requests.EmailAddressUpdateRequest, Context>, AdventureWorks.Interfaces.IEmailAddressService
	{
	
		//ElapsedEFSingle getBaseClassName: EmailAddressService:4
	//ElapsedEFSingle Get base interfaces: EmailAddressService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: EmailAddressService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.EmailAddressSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.EmailAddress> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.EmailAddressID.HasValue)
								{
										query = query.Where(x => x.EmailAddressID == search.EmailAddressID);
								}
								
						}
					
	//ElapsedEFSingle filter for: EmailAddressService:4
	//PropertyName: EmailAddressID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.EmailAddressAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.EmailAddressAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.EmailAddress Get(object id, AdventureWorks.Model.SearchObjects.EmailAddressAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.EmailAddressSearchObject search = new AdventureWorks.Model.SearchObjects.EmailAddressSearchObject();
	                                    search.EmailAddressID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: EmailAddressService:2
	//ElapsedEFSingle get methods for: EmailAddressService:3
	}
	//ElapsedEFSingle for: EmailAddressService:0
	public partial class EmployeeService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.Employee,AdventureWorks.Model.SearchObjects.EmployeeSearchObject,AdventureWorks.Model.SearchObjects.EmployeeAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.IEmployeeService
	{
	
		//ElapsedEFSingle getBaseClassName: EmployeeService:3
	//ElapsedEFSingle Get base interfaces: EmployeeService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: EmployeeService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.EmployeeSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.Employee> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.BusinessEntityID.HasValue)
								{
										query = query.Where(x => x.BusinessEntityID == search.BusinessEntityID);
								}
								
						}
					
	//ElapsedEFSingle filter for: EmployeeService:4
	//PropertyName: BusinessEntityID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.EmployeeAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.EmployeeAdditionalSearchRequestData search)
						{
							if(search.IsPersonLoadingEnabled.HasValue && search.IsPersonLoadingEnabled == true)
									{
										search.IncludeList.Add("Person");
									}
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.Employee Get(object id, AdventureWorks.Model.SearchObjects.EmployeeAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.EmployeeSearchObject search = new AdventureWorks.Model.SearchObjects.EmployeeSearchObject();
	                                    search.BusinessEntityID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: EmployeeService:2
	//ElapsedEFSingle get methods for: EmployeeService:1
	}
	//ElapsedEFSingle for: EmployeeService:0
	public partial class PasswordService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.Password,AdventureWorks.Model.SearchObjects.PasswordSearchObject,AdventureWorks.Model.SearchObjects.PasswordAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.IPasswordService
	{
	
		//ElapsedEFSingle getBaseClassName: PasswordService:2
	//ElapsedEFSingle Get base interfaces: PasswordService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: PasswordService:8
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.PasswordSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.Password> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.BusinessEntityID.HasValue)
								{
										query = query.Where(x => x.BusinessEntityID == search.BusinessEntityID);
								}
								
						}
					
	//ElapsedEFSingle filter for: PasswordService:11
	//PropertyName: BusinessEntityID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.PasswordAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.PasswordAdditionalSearchRequestData search)
						{
							if(search.IsPersonLoadingEnabled.HasValue && search.IsPersonLoadingEnabled == true)
									{
										search.IncludeList.Add("Person");
									}
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.Password Get(object id, AdventureWorks.Model.SearchObjects.PasswordAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.PasswordSearchObject search = new AdventureWorks.Model.SearchObjects.PasswordSearchObject();
	                                    search.BusinessEntityID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: PasswordService:3
	//ElapsedEFSingle get methods for: PasswordService:3
	}
	//ElapsedEFSingle for: PasswordService:0
	public partial class PersonService : AdventureWorks.Services.Core.BaseEFBasedCRUDService<AdventureWorks.Model.Person,AdventureWorks.Model.SearchObjects.PersonSearchObject,AdventureWorks.Model.SearchObjects.PersonAdditionalSearchRequestData,AdventureWorks.Model.Requests.PersonInsertRequest,AdventureWorks.Model.Requests.PersonUpdateRequest, Context>, AdventureWorks.Interfaces.IPersonService
	{
	
		//ElapsedEFSingle getBaseClassName: PersonService:5
	//ElapsedEFSingle Get base interfaces: PersonService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: PersonService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.PersonSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.Person> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(!string.IsNullOrWhiteSpace(search.PersonType))
								{
									query = query.Where(x => x.PersonType == search.PersonType);
	
								}
								if(!string.IsNullOrWhiteSpace(search.FirstName))
								{
									query = query.Where(x => x.FirstName == search.FirstName);
	
								}
								if(!string.IsNullOrWhiteSpace(search.FirstNameGTE))
								{
									query = query.Where(x => x.FirstName.StartsWith(search.FirstNameGTE));
	
								}
								if(!string.IsNullOrWhiteSpace(search.LastName))
								{
									query = query.Where(x => x.LastName == search.LastName);
	
								}
								if(!string.IsNullOrWhiteSpace(search.LastNameGTE))
								{
									query = query.Where(x => x.LastName.StartsWith(search.LastNameGTE));
	
								}
								if(search.BusinessEntityID.HasValue)
								{
										query = query.Where(x => x.BusinessEntityID == search.BusinessEntityID);
								}
								
						}
					
	//ElapsedEFSingle filter for: PersonService:13
	//PropertyName: PersonType
	//PropertyName: FirstName
	//PropertyName: FirstNameGTE
	//PropertyName: LastName
	//PropertyName: LastNameGTE
	//PropertyName: BusinessEntityID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.PersonAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.PersonAdditionalSearchRequestData search)
						{
							if(search.IsEmailAddressesLoadingEnabled.HasValue && search.IsEmailAddressesLoadingEnabled == true)
									{
										search.IncludeList.Add("EmailAddresses");
									}if(search.IsPasswordLoadingEnabled.HasValue && search.IsPasswordLoadingEnabled == true)
									{
										search.IncludeList.Add("Password");
									}
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.Person Get(object id, AdventureWorks.Model.SearchObjects.PersonAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.PersonSearchObject search = new AdventureWorks.Model.SearchObjects.PersonSearchObject();
	                                    search.BusinessEntityID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: PersonService:4
	//ElapsedEFSingle get methods for: PersonService:3
	}
	//ElapsedEFSingle for: PersonService:0
	public partial class CurrencyService : AdventureWorks.Services.Core.BaseEFBasedCRUDService<AdventureWorks.Model.Currency,AdventureWorks.Model.SearchObjects.CurrencySearchObject,AdventureWorks.Model.SearchObjects.CurrencyAdditionalSearchRequestData,AdventureWorks.Model.Requests.CurrencyInsertRequest,AdventureWorks.Model.Requests.CurrencyUpdateRequest, Context>, AdventureWorks.Interfaces.ICurrencyService
	{
	
		//ElapsedEFSingle getBaseClassName: CurrencyService:2
	//ElapsedEFSingle Get base interfaces: CurrencyService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: CurrencyService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.CurrencySearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.Currency> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(!string.IsNullOrWhiteSpace(search.CurrencyCode))
								{
									query = query.Where(x => x.CurrencyCode == search.CurrencyCode);
	
								}
								if(search.CurrencyCodeList != null && search.CurrencyCodeList.Count > 0)
								{
									query = query.Where(x => search.CurrencyCodeList.Contains(x.CurrencyCode));
	
								}
								if(!string.IsNullOrWhiteSpace(search.NameGTE))
								{
									query = query.Where(x => x.Name.StartsWith(search.NameGTE));
	
								}
								
						}
					
	//ElapsedEFSingle filter for: CurrencyService:9
	//PropertyName: CurrencyCode
	//PropertyName: CurrencyCodeList
	//PropertyName: NameGTE
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.CurrencyAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.CurrencyAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.Currency Get(object id, AdventureWorks.Model.SearchObjects.CurrencyAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.CurrencySearchObject search = new AdventureWorks.Model.SearchObjects.CurrencySearchObject();
	                                    search.CurrencyCode = (System.String)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: CurrencyService:9
	//ElapsedEFSingle get methods for: CurrencyService:5
	}
	//ElapsedEFSingle for: CurrencyService:0
	public partial class CurrencyRateService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.CurrencyRate,AdventureWorks.Model.SearchObjects.CurrencyRateSearchObject,AdventureWorks.Model.SearchObjects.CurrencyRateAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.ICurrencyRateService
	{
	
		//ElapsedEFSingle getBaseClassName: CurrencyRateService:2
	//ElapsedEFSingle Get base interfaces: CurrencyRateService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: CurrencyRateService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.CurrencyRateSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.CurrencyRate> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(!string.IsNullOrWhiteSpace(search.FromCurrencyCode))
								{
									query = query.Where(x => x.FromCurrencyCode == search.FromCurrencyCode);
	
								}
								if(!string.IsNullOrWhiteSpace(search.ToCurrencyCode))
								{
									query = query.Where(x => x.ToCurrencyCode == search.ToCurrencyCode);
	
								}
								if(search.CurrencyRateID.HasValue)
								{
										query = query.Where(x => x.CurrencyRateID == search.CurrencyRateID);
								}
								
						}
					
	//ElapsedEFSingle filter for: CurrencyRateService:8
	//PropertyName: FromCurrencyCode
	//PropertyName: ToCurrencyCode
	//PropertyName: CurrencyRateID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.CurrencyRateAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.CurrencyRateAdditionalSearchRequestData search)
						{
							if(search.IsFromCurrencyLoadingEnabled.HasValue && search.IsFromCurrencyLoadingEnabled == true)
									{
										search.IncludeList.Add("FromCurrency");
									}if(search.IsToCurrencyLoadingEnabled.HasValue && search.IsToCurrencyLoadingEnabled == true)
									{
										search.IncludeList.Add("ToCurrency");
									}
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.CurrencyRate Get(object id, AdventureWorks.Model.SearchObjects.CurrencyRateAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.CurrencyRateSearchObject search = new AdventureWorks.Model.SearchObjects.CurrencyRateSearchObject();
	                                    search.CurrencyRateID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: CurrencyRateService:5
	//ElapsedEFSingle get methods for: CurrencyRateService:5
	}
	//ElapsedEFSingle for: CurrencyRateService:1
	public partial class ContactTypeService : AdventureWorks.Services.Core.BaseEFBasedReadService<AdventureWorks.Model.ContactType,AdventureWorks.Model.SearchObjects.ContactTypeSearchObject,AdventureWorks.Model.SearchObjects.ContactTypeAdditionalSearchRequestData, Context>, AdventureWorks.Interfaces.IContactTypeService
	{
	
		//ElapsedEFSingle getBaseClassName: ContactTypeService:2
	//ElapsedEFSingle Get base interfaces: ContactTypeService:0
	//ElapsedEFSingle Get allPropertiesOnSearchObject: ContactTypeService:1
	
						protected override void AddFilterFromGeneratedCode(AdventureWorks.Model.SearchObjects.ContactTypeSearchObject search, ref System.Linq.IQueryable<AdventureWorks.Model.ContactType> query)
						{
							base.AddFilterFromGeneratedCode(search, ref query);
							if(search.ContactTypeID.HasValue)
								{
										query = query.Where(x => x.ContactTypeID == search.ContactTypeID);
								}
								
						}
					
	//ElapsedEFSingle filter for: ContactTypeService:4
	//PropertyName: ContactTypeID
	
						partial void OnGetIncludeList(AdventureWorks.Model.SearchObjects.ContactTypeAdditionalSearchRequestData search);
						protected override IList<string> GetIncludeList(AdventureWorks.Model.SearchObjects.ContactTypeAdditionalSearchRequestData search)
						{
							
							OnGetIncludeList(search);
							return base.GetIncludeList(search);
						}
					
	
						public override AdventureWorks.Model.ContactType Get(object id, AdventureWorks.Model.SearchObjects.ContactTypeAdditionalSearchRequestData additionalData = null)
						{
								if (additionalData != null)
	                            {
	                                var count = GetIncludeList(additionalData).Count;
	                                if (count > 0)
	                                {
	                                    AdventureWorks.Model.SearchObjects.ContactTypeSearchObject search = new AdventureWorks.Model.SearchObjects.ContactTypeSearchObject();
	                                    search.ContactTypeID = (System.Nullable<System.Int32>)id;
										search.AdditionalData = additionalData;
	                                    return Get(search).FirstOrDefault();
	                                }
	                            }
							return base.Get(id, additionalData);
						}
					
	//ElapsedEFSingle include for: ContactTypeService:5
	//ElapsedEFSingle get methods for: ContactTypeService:2
	}
	//ElapsedEFSingle for: ContactTypeService:0

	//file:C:\Projects\Other\REST-Framework-AdventureWorks\AdventureWorks\AdventureWorks.Model\AdventureWorks.Model.csproj_C:\Projects\Other\REST-Framework-AdventureWorks\AdventureWorks\AdventureWorks.Model
	//Creating state machine from: C:\Projects\Other\REST-Framework-AdventureWorks\AdventureWorks\AdventureWorks.Model\PurchaseOrderHeaderStateMachine.tastate
	//, enum AdventureWorks.Model.PurchaceOrderHeaderStatusEnum
					//StateMachine: IPurchaseOrderHeaderService,
					// name: PurchaseOrderHeaderStateMachine,
					// graphCount 4
					
					public partial class PurchaseOrderHeaderStateMachineUnknownState : AdventureWorks.Services.Core.StateBase 
					{
						protected AdventureWorks.Model.PurchaceOrderHeaderStatusEnum mStateId = AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Unknown;
						public PurchaseOrderHeaderStateMachineUnknownState(AdventureWorks.Services.Core.StateMachineBase machine) : base(machine) 
						{
							StateId = (int)mStateId;
						}
					}
					public partial class PurchaseOrderHeaderStateMachinePendingState : AdventureWorks.Services.Core.StateBase 
					{
						protected AdventureWorks.Model.PurchaceOrderHeaderStatusEnum mStateId = AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Pending;
						public PurchaseOrderHeaderStateMachinePendingState(AdventureWorks.Services.Core.StateMachineBase machine) : base(machine)
						{
							StateId = (int)mStateId;
						}
					}
					public partial class PurchaseOrderHeaderStateMachineRejectedState : AdventureWorks.Services.Core.StateBase 
					{
						protected AdventureWorks.Model.PurchaceOrderHeaderStatusEnum mStateId = AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Rejected;
						public PurchaseOrderHeaderStateMachineRejectedState(AdventureWorks.Services.Core.StateMachineBase machine) : base(machine)
						{
							StateId = (int)mStateId;
						}
					}
					public partial class PurchaseOrderHeaderStateMachineApprovedState : AdventureWorks.Services.Core.StateBase 
					{
						protected AdventureWorks.Model.PurchaceOrderHeaderStatusEnum mStateId = AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Approved;
						public PurchaseOrderHeaderStateMachineApprovedState(AdventureWorks.Services.Core.StateMachineBase machine) : base(machine)
						{
							StateId = (int)mStateId;
						}
					}
					public partial class PurchaseOrderHeaderStateMachineCompletedState : AdventureWorks.Services.Core.StateBase 
					{
						protected AdventureWorks.Model.PurchaceOrderHeaderStatusEnum mStateId = AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Completed;
						public PurchaseOrderHeaderStateMachineCompletedState(AdventureWorks.Services.Core.StateMachineBase machine) : base(machine)
						{
							StateId = (int)mStateId;
						}
					}
					public partial class PurchaseOrderHeaderStateMachineRejectTrigger : AdventureWorks.Services.Core.TriggerBase 
					{
						protected PurchaseOrderHeaderTriggerEnum mTriggerId = PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderRejectRequest;
						static PurchaseOrderHeaderStateMachineRejectTrigger()
	                    {
	                        AutoMapper.Mapper.CreateMap<PurchaseOrderHeaderRejectRequest, AdventureWorks.Model.PurchaseOrderHeader>().ForAllMembers(opt => opt.Condition(srs => !srs.IsSourceValueNull));
	                    }
						public PurchaseOrderHeaderStateMachineRejectTrigger()
						{
							TriggerId = (int)mTriggerId;
						}
						public PurchaseOrderHeaderRejectRequest Request {get; set;}
						public override void UpdateEntity(object entity)
						{
							AutoMapper.Mapper.Map(Request, entity);
						}
					}
	
					public partial class PurchaseOrderHeaderStateMachineApproveTrigger : AdventureWorks.Services.Core.TriggerBase 
					{
						protected PurchaseOrderHeaderTriggerEnum mTriggerId = PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderApproveRequest;
						static PurchaseOrderHeaderStateMachineApproveTrigger()
	                    {
	                        AutoMapper.Mapper.CreateMap<PurchaseOrderHeaderApproveRequest, AdventureWorks.Model.PurchaseOrderHeader>().ForAllMembers(opt => opt.Condition(srs => !srs.IsSourceValueNull));
	                    }
						public PurchaseOrderHeaderStateMachineApproveTrigger()
						{
							TriggerId = (int)mTriggerId;
						}
						public PurchaseOrderHeaderApproveRequest Request {get; set;}
						public override void UpdateEntity(object entity)
						{
							AutoMapper.Mapper.Map(Request, entity);
						}
					}
	
					public partial class PurchaseOrderHeaderStateMachinePendingTrigger : AdventureWorks.Services.Core.TriggerBase 
					{
						protected PurchaseOrderHeaderTriggerEnum mTriggerId = PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderPendingRequest;
						static PurchaseOrderHeaderStateMachinePendingTrigger()
	                    {
	                        AutoMapper.Mapper.CreateMap<PurchaseOrderHeaderPendingRequest, AdventureWorks.Model.PurchaseOrderHeader>().ForAllMembers(opt => opt.Condition(srs => !srs.IsSourceValueNull));
	                    }
						public PurchaseOrderHeaderStateMachinePendingTrigger()
						{
							TriggerId = (int)mTriggerId;
						}
						public PurchaseOrderHeaderPendingRequest Request {get; set;}
						public override void UpdateEntity(object entity)
						{
							AutoMapper.Mapper.Map(Request, entity);
						}
					}
	
					public partial class PurchaseOrderHeaderStateMachineCompleteTrigger : AdventureWorks.Services.Core.TriggerBase 
					{
						protected PurchaseOrderHeaderTriggerEnum mTriggerId = PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderCompleteRequest;
						static PurchaseOrderHeaderStateMachineCompleteTrigger()
	                    {
	                        AutoMapper.Mapper.CreateMap<PurchaseOrderHeaderCompleteRequest, AdventureWorks.Model.PurchaseOrderHeader>().ForAllMembers(opt => opt.Condition(srs => !srs.IsSourceValueNull));
	                    }
						public PurchaseOrderHeaderStateMachineCompleteTrigger()
						{
							TriggerId = (int)mTriggerId;
						}
						public PurchaseOrderHeaderCompleteRequest Request {get; set;}
						public override void UpdateEntity(object entity)
						{
							AutoMapper.Mapper.Map(Request, entity);
						}
					}
	
						public partial class PurchaseOrderHeaderStateMachineInsertTrigger : AdventureWorks.Services.Core.TriggerBase 
					{
						protected PurchaseOrderHeaderTriggerEnum mTriggerId = PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderInsertRequest;
						static PurchaseOrderHeaderStateMachineInsertTrigger()
	                    {
	                        AutoMapper.Mapper.CreateMap<PurchaseOrderHeaderInsertRequest, AdventureWorks.Model.PurchaseOrderHeader>().ForAllMembers(opt => opt.Condition(srs => !srs.IsSourceValueNull));
	                    }
						public PurchaseOrderHeaderStateMachineInsertTrigger()
						{
							TriggerId = (int)mTriggerId;
						}
						public PurchaseOrderHeaderInsertRequest Request {get; set;}
						public override void UpdateEntity(object entity)
						{
							AutoMapper.Mapper.Map(Request, entity);
						}
					}
					/// <summary>
					/// This class is the actual state machine designed in the State-Diagarm.
					/// </summary>
					public partial class PurchaseOrderHeaderStateMachine : AdventureWorks.Services.Core.StateMachineBase
					{
						/// <summary>
						/// Makes the state machine react to a trigger.
						/// </summary>
						public override void ProcessTrigger(AdventureWorks.Services.Core.TriggerBase trigger)
						{
							if (this.CurrentState == null) return;
							if (trigger == null) throw new ArgumentException("Trigger must not be null");
	
							// determine what action to take based on the current state
							// and the given trigger.
							// iterate all states in the diagram
							if (this.CurrentState is PurchaseOrderHeaderStateMachineUnknownState)
							{
								if(!GetAllowedTriggerList().Contains((PurchaseOrderHeaderTriggerEnum)trigger.TriggerId))
	                                    {
	                                        throw new A.Core.Validation.UserException("Action not allowed!");
	                                    }
									if (trigger is PurchaseOrderHeaderStateMachineInsertTrigger)
									{
										 var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachinePendingState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
										this.TransitionToNewState(state, trigger);
									}
							}
	
								else if (this.CurrentState is PurchaseOrderHeaderStateMachinePendingState)
								{
									if(!GetAllowedTriggerList().Contains((PurchaseOrderHeaderTriggerEnum)trigger.TriggerId))
	                                        {
	                                             throw new A.Core.Validation.UserException("Action not allowed!");
	                                        }
										if (trigger is PurchaseOrderHeaderStateMachineRejectTrigger)
										{
											var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachineRejectedState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
											this.TransitionToNewState(state, trigger);
											
										}
										if (trigger is PurchaseOrderHeaderStateMachineApproveTrigger)
										{
											var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachineApprovedState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
											this.TransitionToNewState(state, trigger);
											
										}
										if (trigger is PurchaseOrderHeaderStateMachinePendingTrigger)
										{
											var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachinePendingState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
											this.TransitionToNewState(state, trigger);
											
										}
								}
								else if (this.CurrentState is PurchaseOrderHeaderStateMachineRejectedState)
								{
									if(!GetAllowedTriggerList().Contains((PurchaseOrderHeaderTriggerEnum)trigger.TriggerId))
	                                        {
	                                             throw new A.Core.Validation.UserException("Action not allowed!");
	                                        }
								}
								else if (this.CurrentState is PurchaseOrderHeaderStateMachineApprovedState)
								{
									if(!GetAllowedTriggerList().Contains((PurchaseOrderHeaderTriggerEnum)trigger.TriggerId))
	                                        {
	                                             throw new A.Core.Validation.UserException("Action not allowed!");
	                                        }
										if (trigger is PurchaseOrderHeaderStateMachineCompleteTrigger)
										{
											var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachineCompletedState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
											this.TransitionToNewState(state, trigger);
											
										}
								}
								else if (this.CurrentState is PurchaseOrderHeaderStateMachineCompletedState)
								{
									if(!GetAllowedTriggerList().Contains((PurchaseOrderHeaderTriggerEnum)trigger.TriggerId))
	                                        {
	                                             throw new A.Core.Validation.UserException("Action not allowed!");
	                                        }
								}
	
						}
	
						 public System.Collections.Generic.IList<PurchaseOrderHeaderTriggerEnum> GetAllowedTriggerList()
	                        {
	                            IList<PurchaseOrderHeaderTriggerEnum> triggerList = new List<PurchaseOrderHeaderTriggerEnum>();
								if (this.CurrentState is PurchaseOrderHeaderStateMachineUnknownState)
								{
										triggerList.Add(PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderInsertRequest);
								}
								if (this.CurrentState is PurchaseOrderHeaderStateMachinePendingState)
								{
										triggerList.Add(PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderRejectRequest);
										triggerList.Add(PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderApproveRequest);
										triggerList.Add(PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderPendingRequest);
								}
								if (this.CurrentState is PurchaseOrderHeaderStateMachineRejectedState)
								{
								}
								if (this.CurrentState is PurchaseOrderHeaderStateMachineApprovedState)
								{
										triggerList.Add(PurchaseOrderHeaderTriggerEnum.PurchaseOrderHeaderCompleteRequest);
								}
								if (this.CurrentState is PurchaseOrderHeaderStateMachineCompletedState)
								{
								}
	
	
	                            return triggerList;
	                        }
	
							
							public AdventureWorks.Model.PurchaseOrderHeader Entity { get; set; }
							public PurchaseOrderHeaderStateMachine()
							:base()
							{
								
							}
							public override void UpdateEntityState()
	                        {
								//Entity: AdventureWorks.Model.PurchaseOrderHeader
								Entity.Status = (AdventureWorks.Model.PurchaceOrderHeaderStatusEnum)CurrentState.StateId;
	                            base.UpdateEntityState();
	                        }
	
							public void Initialize(AdventureWorks.Model.PurchaseOrderHeader entity)
							{
								//bind entity that we are operating ON
								
								Entity = entity;
								CurrentEntity = entity;
								CurrentState = GetState(entity.Status);
							}
	
							public AdventureWorks.Services.Core.StateBase GetState(AdventureWorks.Model.PurchaceOrderHeaderStatusEnum stateId)
							{
								switch(stateId)
								{
									case AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Unknown:
									{
										var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachineUnknownState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
										return state;
									}
									case AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Pending:
									{
										var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachinePendingState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
										return state;
									}
									case AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Rejected:
									{
										var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachineRejectedState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
										return state;
									}
									case AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Approved:
									{
										var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachineApprovedState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
										return state;
									}
									case AdventureWorks.Model.PurchaceOrderHeaderStatusEnum.Completed:
									{
										var state = ActionContext.CurrentContainer.Resolve<PurchaseOrderHeaderStateMachineCompletedState>(new ResolverOverride[]
	                                        {
	                                            new ParameterOverride("machine", this)
	                                        });
										return state;
									}
									default:
									{
										throw new ApplicationException("Invalid stateId:" + stateId);
									}
								}
	
								throw new ApplicationException("States undefined");
							}
	
					}
	
					public partial class PurchaseOrderHeaderService
					{
						
						[Dependency]
						public PurchaseOrderHeaderStateMachine PurchaseOrderHeaderStateMachineInstance { get; set; }
	//Creating state machine method: Insert
						partial void OnInsertBeforeSave(AdventureWorks.Model.Requests.PurchaseOrderHeaderInsertRequest request);
						partial void OnInsertAfterSave(AdventureWorks.Model.Requests.PurchaseOrderHeaderInsertRequest request);
						[A.Core.Interceptors.LogInterceptor(AspectPriority=0)]
						[A.Core.Interceptors.TransactionInterceptor(AspectPriority=1)]
						public virtual PurchaseOrderHeader Insert(AdventureWorks.Model.Requests.PurchaseOrderHeaderInsertRequest request)
						{
							var entity = CreateNewInstance();
	
							PurchaseOrderHeaderStateMachineInstance.Initialize(entity);
	
							PurchaseOrderHeaderStateMachineInstance.ProcessTrigger(new PurchaseOrderHeaderStateMachineInsertTrigger() { Request = request });
							OnInsertBeforeSave(request);
							Entity.Attach(entity);
	                        Context.Entry(entity).State = EntityState.Added;
							Save(entity);
							OnInsertAfterSave(request);
							return entity;
						}
	//Creating state machine method: Approve
						partial void OnApproveBeforeSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderApproveRequest request);
						partial void OnApproveAfterSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderApproveRequest request);
						[A.Core.Interceptors.LogInterceptor(AspectPriority=0)]
						[A.Core.Interceptors.TransactionInterceptor(AspectPriority=1)]
						public virtual PurchaseOrderHeader Approve(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderApproveRequest request)
						{
							var entity = Get(id);
							if(entity != null)
							{
								Entity.Attach(entity);
								PurchaseOrderHeaderStateMachineInstance.Initialize(entity);
	
								PurchaseOrderHeaderStateMachineInstance.ProcessTrigger(new PurchaseOrderHeaderStateMachineApproveTrigger() { Request = request });
								
								//Context.Entry(entity).State = EntityState.Modified;
								OnApproveBeforeSave(id, request);
								Save(entity);
								OnApproveAfterSave(id, request);
							}
							else
							{
								throw new ApplicationException("Entity not found!");
							}
							return entity;
						}
	//Creating state machine method: Pending
						partial void OnPendingBeforeSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderPendingRequest request);
						partial void OnPendingAfterSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderPendingRequest request);
						[A.Core.Interceptors.LogInterceptor(AspectPriority=0)]
						[A.Core.Interceptors.TransactionInterceptor(AspectPriority=1)]
						public virtual PurchaseOrderHeader Pending(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderPendingRequest request)
						{
							var entity = Get(id);
							if(entity != null)
							{
								Entity.Attach(entity);
								PurchaseOrderHeaderStateMachineInstance.Initialize(entity);
	
								PurchaseOrderHeaderStateMachineInstance.ProcessTrigger(new PurchaseOrderHeaderStateMachinePendingTrigger() { Request = request });
								
								//Context.Entry(entity).State = EntityState.Modified;
								OnPendingBeforeSave(id, request);
								Save(entity);
								OnPendingAfterSave(id, request);
							}
							else
							{
								throw new ApplicationException("Entity not found!");
							}
							return entity;
						}
	//Creating state machine method: Reject
						partial void OnRejectBeforeSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderRejectRequest request);
						partial void OnRejectAfterSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderRejectRequest request);
						[A.Core.Interceptors.LogInterceptor(AspectPriority=0)]
						[A.Core.Interceptors.TransactionInterceptor(AspectPriority=1)]
						public virtual PurchaseOrderHeader Reject(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderRejectRequest request)
						{
							var entity = Get(id);
							if(entity != null)
							{
								Entity.Attach(entity);
								PurchaseOrderHeaderStateMachineInstance.Initialize(entity);
	
								PurchaseOrderHeaderStateMachineInstance.ProcessTrigger(new PurchaseOrderHeaderStateMachineRejectTrigger() { Request = request });
								
								//Context.Entry(entity).State = EntityState.Modified;
								OnRejectBeforeSave(id, request);
								Save(entity);
								OnRejectAfterSave(id, request);
							}
							else
							{
								throw new ApplicationException("Entity not found!");
							}
							return entity;
						}
	//Creating state machine method: Complete
						partial void OnCompleteBeforeSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderCompleteRequest request);
						partial void OnCompleteAfterSave(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderCompleteRequest request);
						[A.Core.Interceptors.LogInterceptor(AspectPriority=0)]
						[A.Core.Interceptors.TransactionInterceptor(AspectPriority=1)]
						public virtual PurchaseOrderHeader Complete(System.Int32 id,AdventureWorks.Model.Requests.PurchaseOrderHeaderCompleteRequest request)
						{
							var entity = Get(id);
							if(entity != null)
							{
								Entity.Attach(entity);
								PurchaseOrderHeaderStateMachineInstance.Initialize(entity);
	
								PurchaseOrderHeaderStateMachineInstance.ProcessTrigger(new PurchaseOrderHeaderStateMachineCompleteTrigger() { Request = request });
								
								//Context.Entry(entity).State = EntityState.Modified;
								OnCompleteBeforeSave(id, request);
								Save(entity);
								OnCompleteAfterSave(id, request);
							}
							else
							{
								throw new ApplicationException("Entity not found!");
							}
							return entity;
						}
	//Creating state machine method: Get
	//Creating state machine method: GetPage
	//Creating state machine method: BeginTransaction
	//Creating state machine method: CommitTransaction
	//Creating state machine method: DisposeTransaction
	//Creating state machine method: RollbackTransaction
						
					}

}

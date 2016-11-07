















using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//Requests section
namespace AdventureWorks.Model.Requests
{
														//AdventureWorks.Model.PurchaseOrderHeader
				public partial class PurchaseOrderHeaderInsertRequest
{

	
	public System.Byte RevisionNumber { get; set; }

	public System.Int32 EmployeeID { get; set; }

	public System.Int32 VendorID { get; set; }

	public System.Int32 ShipMethodID { get; set; }

	public System.DateTime OrderDate { get; set; }

	public System.DateTime? ShipDate { get; set; }

	public System.Decimal SubTotal { get; set; }

	public System.Decimal TaxAmt { get; set; }

	public System.Decimal Freight { get; set; }

	public System.Decimal TotalDue { get; set; }
}

											//AdventureWorks.Model.PurchaseOrderHeader
				public partial class PurchaseOrderHeaderPendingRequest
{

	
	public System.Byte RevisionNumber { get; set; }

	public System.Int32 EmployeeID { get; set; }

	public System.Int32 VendorID { get; set; }

	public System.Int32 ShipMethodID { get; set; }

	public System.DateTime OrderDate { get; set; }

	public System.DateTime? ShipDate { get; set; }

	public System.Decimal SubTotal { get; set; }

	public System.Decimal TaxAmt { get; set; }

	public System.Decimal Freight { get; set; }

	public System.Decimal TotalDue { get; set; }
}

							
														//AdventureWorks.Model.PurchaseOrderDetail
				public partial class PurchaseOrderDetailInsertRequest
{

	
	public System.Int32 PurchaseOrderDetailID { get; set; }

	public System.DateTime DueDate { get; set; }

	public System.Int16 OrderQty { get; set; }

	public System.Int32 ProductID { get; set; }

	public System.Decimal UnitPrice { get; set; }

	public System.Decimal LineTotal { get; set; }

	public System.Decimal ReceivedQty { get; set; }

	public System.Decimal RejectedQty { get; set; }

	public System.Decimal StockedQty { get; set; }
}

											//AdventureWorks.Model.PurchaseOrderDetail
				public partial class PurchaseOrderDetailUpdateRequest
{

	
	public System.Int32 PurchaseOrderDetailID { get; set; }

	public System.DateTime DueDate { get; set; }

	public System.Int16 OrderQty { get; set; }

	public System.Int32 ProductID { get; set; }

	public System.Decimal UnitPrice { get; set; }

	public System.Decimal LineTotal { get; set; }

	public System.Decimal ReceivedQty { get; set; }

	public System.Decimal RejectedQty { get; set; }

	public System.Decimal StockedQty { get; set; }
}

							
					
														//AdventureWorks.Model.Customer
				public partial class CustomerInsertRequest
{

	
	public System.Int32? PersonID { get; set; }

	public System.Int32? StoreID { get; set; }

	public System.Int32? TerritoryID { get; set; }

	public System.String AccountNumber { get; set; }
}

											//AdventureWorks.Model.Customer
				public partial class CustomerUpdateRequest
{

	
	public System.Int32? PersonID { get; set; }

	public System.Int32? StoreID { get; set; }

	public System.Int32? TerritoryID { get; set; }

	public System.String AccountNumber { get; set; }
}

							
					
					
					
					
														//AdventureWorks.Model.Person
				public partial class PersonInsertRequest
{

	
	public System.Int32 BusinessEntityID { get; set; }

	public System.String PersonType { get; set; }

	public System.Boolean NameStyle { get; set; }

	public System.String Title { get; set; }

	public System.String FirstName { get; set; }

	public System.String MiddleName { get; set; }

	public System.String LastName { get; set; }

	public System.String Suffix { get; set; }

	public System.Int32 EmailPromotion { get; set; }

	public System.String AdditionalContactInfo { get; set; }

	public System.String Demographics { get; set; }
}

											//AdventureWorks.Model.Person
				public partial class PersonUpdateRequest
{

	
	public System.String PersonType { get; set; }

	public System.Boolean NameStyle { get; set; }

	public System.String Title { get; set; }

	public System.String FirstName { get; set; }

	public System.String MiddleName { get; set; }

	public System.String LastName { get; set; }

	public System.String Suffix { get; set; }

	public System.Int32 EmailPromotion { get; set; }

	public System.String AdditionalContactInfo { get; set; }

	public System.String Demographics { get; set; }
}

							
														//AdventureWorks.Model.EmailAddress
				public partial class EmailAddressInsertRequest
{

	
	public System.Int32 BusinessEntityID { get; set; }

	public System.String EmailAddress1 { get; set; }
}

											//AdventureWorks.Model.EmailAddress
				public partial class EmailAddressUpdateRequest
{

	
	public System.Int32 BusinessEntityID { get; set; }

	public System.Int32 EmailAddressID { get; set; }

	public System.String EmailAddress1 { get; set; }
}

							
														//AdventureWorks.Model.Currency
				public partial class CurrencyInsertRequest
{

	
	public System.String CurrencyCode { get; set; }

	public System.String Name { get; set; }
}

											//AdventureWorks.Model.Currency
				public partial class CurrencyUpdateRequest
{

	
	public System.String CurrencyCode { get; set; }

	public System.String Name { get; set; }
}

							
														//AdventureWorks.Model.Vendor
				public partial class VendorInsertRequest
{

	
	public System.Int32 BusinessEntityID { get; set; }

	public System.String AccountNumber { get; set; }

	public System.String Name { get; set; }

	public System.Byte CreditRating { get; set; }

	public System.Boolean PreferredVendorStatus { get; set; }

	public System.String PurchasingWebServiceURL { get; set; }
}

											//AdventureWorks.Model.Vendor
				public partial class VendorUpdateRequest
{

	
	public System.String AccountNumber { get; set; }

	public System.String Name { get; set; }

	public System.Byte CreditRating { get; set; }

	public System.Boolean PreferredVendorStatus { get; set; }

	public System.Boolean? ActiveFlag { get; set; }

	public System.String PurchasingWebServiceURL { get; set; }
}

							
					
					
					
	
		//Creating requests for state machines
//file:C:\Projects\Other\REST-Framework-AdventureWorks\AdventureWorks\AdventureWorks.Model\AdventureWorks.Model.csproj_C:\Projects\Other\REST-Framework-AdventureWorks\AdventureWorks\AdventureWorks.Model
//Creating state machine from: C:\Projects\Other\REST-Framework-AdventureWorks\AdventureWorks\AdventureWorks.Model\PurchaseOrderHeaderStateMachine.tastate
				//StateMachine: PurchaseOrderHeader, name: PurchaseOrderHeaderStateMachine, graphCount 4

				public partial class PurchaseOrderHeaderRejectRequest { }	

				public partial class PurchaseOrderHeaderApproveRequest { }	

				public partial class PurchaseOrderHeaderPendingRequest { }	

				public partial class PurchaseOrderHeaderCompleteRequest { }	

					public partial class PurchaseOrderHeaderInsertRequest { }	

				public enum PurchaseOrderHeaderTriggerEnum
				{
				 PurchaseOrderHeaderRejectRequest,

				 PurchaseOrderHeaderApproveRequest,

				 PurchaseOrderHeaderPendingRequest,

				 PurchaseOrderHeaderCompleteRequest,

					PurchaseOrderHeaderInsertRequest,
				}


	
}

namespace AdventureWorks.Model.SearchObjects
{
							//AdventureWorks.Model.PurchaseOrderHeader
				
	public partial class PurchaseOrderHeaderSearchObject : A.Core.Model.BaseSearchObject<PurchaseOrderHeaderAdditionalSearchRequestData>
{
	//PROP:purchaceorderheaderstatusenum
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual AdventureWorks.Model.PurchaceOrderHeaderStatusEnum? Status { get; set; }
	

	protected System.Collections.Generic.IList<AdventureWorks.Model.PurchaceOrderHeaderStatusEnum> mStatusList = new System.Collections.Generic.List<AdventureWorks.Model.PurchaceOrderHeaderStatusEnum>();
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.List, false)]
	public virtual System.Collections.Generic.IList<AdventureWorks.Model.PurchaceOrderHeaderStatusEnum> StatusList { get {return mStatusList;} set { mStatusList = value; }}
	

	//PROP:int32
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? EmployeeID { get; set; }
	

	protected System.Collections.Generic.IList<System.Int32> mEmployeeIDList = new System.Collections.Generic.List<System.Int32>();
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.List, false)]
	public virtual System.Collections.Generic.IList<System.Int32> EmployeeIDList { get {return mEmployeeIDList;} set { mEmployeeIDList = value; }}
	

	//PROP:int32
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? VendorID { get; set; }
	

	protected System.Collections.Generic.IList<System.Int32> mVendorIDList = new System.Collections.Generic.List<System.Int32>();
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.List, false)]
	public virtual System.Collections.Generic.IList<System.Int32> VendorIDList { get {return mVendorIDList;} set { mVendorIDList = value; }}
	

	//PROP:int32
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? ShipMethodID { get; set; }
	

	protected System.Collections.Generic.IList<System.Int32> mShipMethodIDList = new System.Collections.Generic.List<System.Int32>();
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.List, false)]
	public virtual System.Collections.Generic.IList<System.Int32> ShipMethodIDList { get {return mShipMethodIDList;} set { mShipMethodIDList = value; }}
	

	//PROP:datetime
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.DateTime? OrderDate { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.DateTime? OrderDateGTE { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.LowerThanOrEqual, false)]
	public virtual System.DateTime? OrderDateLTE { get; set; }
	

	//PROP:nullable
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Nullable<System.DateTime> ShipDate { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.Nullable<System.DateTime> ShipDateGTE { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.LowerThanOrEqual, false)]
	public virtual System.Nullable<System.DateTime> ShipDateLTE { get; set; }
	

	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? PurchaseOrderID { get; set; }
	

}
public partial class PurchaseOrderHeaderAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsShipMethodLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsShipMethodLoadingEnabled { get { return  mIsShipMethodLoadingEnabled; } set { mIsShipMethodLoadingEnabled = value; } }
	

	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsVendorLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsVendorLoadingEnabled { get { return  mIsVendorLoadingEnabled; } set { mIsVendorLoadingEnabled = value; } }
	

}

							//AdventureWorks.Model.PurchaseOrderDetail
				
	public partial class PurchaseOrderDetailSearchObject : A.Core.Model.BaseSearchObject<PurchaseOrderDetailAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? PurchaseOrderID { get; set; }
	

}
public partial class PurchaseOrderDetailAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.EmployeeDepartmentHistory
				
	public partial class EmployeeDepartmentHistorySearchObject : A.Core.Model.BaseSearchObject<EmployeeDepartmentHistoryAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? BusinessEntityID { get; set; }
	

}
public partial class EmployeeDepartmentHistoryAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsDepartmentLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsDepartmentLoadingEnabled { get { return  mIsDepartmentLoadingEnabled; } set { mIsDepartmentLoadingEnabled = value; } }
	

	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsEmployeeLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsEmployeeLoadingEnabled { get { return  mIsEmployeeLoadingEnabled; } set { mIsEmployeeLoadingEnabled = value; } }
	

}

							//AdventureWorks.Model.Customer
				
	public partial class CustomerSearchObject : A.Core.Model.BaseSearchObject<CustomerAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? CustomerID { get; set; }
	

}
public partial class CustomerAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsPersonLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsPersonLoadingEnabled { get { return  mIsPersonLoadingEnabled; } set { mIsPersonLoadingEnabled = value; } }
	

}

							//AdventureWorks.Model.Password
				
	public partial class PasswordSearchObject : A.Core.Model.BaseSearchObject<PasswordAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? BusinessEntityID { get; set; }
	

}
public partial class PasswordAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsPersonLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsPersonLoadingEnabled { get { return  mIsPersonLoadingEnabled; } set { mIsPersonLoadingEnabled = value; } }
	

}

							//AdventureWorks.Model.ShipMethod
				
	public partial class ShipMethodSearchObject : A.Core.Model.BaseSearchObject<ShipMethodAdditionalSearchRequestData>
{
	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.String NameGTE { get; set; }
	

	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? ShipMethodID { get; set; }
	

}
public partial class ShipMethodAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.Department
				
	public partial class DepartmentSearchObject : A.Core.Model.BaseSearchObject<DepartmentAdditionalSearchRequestData>
{
	//PROP:int16
	protected System.Collections.Generic.IList<System.Int16> mDepartmentIDList = new System.Collections.Generic.List<System.Int16>();
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.List, false)]
	public virtual System.Collections.Generic.IList<System.Int16> DepartmentIDList { get {return mDepartmentIDList;} set { mDepartmentIDList = value; }}
	

	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String Name { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.String NameGTE { get; set; }
	

	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String GroupName { get; set; }
	

	protected System.Collections.Generic.IList<System.String> mGroupNameList = new System.Collections.Generic.List<System.String>();
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.List, false)]
	public virtual System.Collections.Generic.IList<System.String> GroupNameList { get {return mGroupNameList;} set { mGroupNameList = value; }}
	

	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int16? DepartmentID { get; set; }
	

}
public partial class DepartmentAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.CurrencyRate
				
	public partial class CurrencyRateSearchObject : A.Core.Model.BaseSearchObject<CurrencyRateAdditionalSearchRequestData>
{
	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String FromCurrencyCode { get; set; }
	

	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String ToCurrencyCode { get; set; }
	

	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? CurrencyRateID { get; set; }
	

}
public partial class CurrencyRateAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsFromCurrencyLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsFromCurrencyLoadingEnabled { get { return  mIsFromCurrencyLoadingEnabled; } set { mIsFromCurrencyLoadingEnabled = value; } }
	

	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsToCurrencyLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsToCurrencyLoadingEnabled { get { return  mIsToCurrencyLoadingEnabled; } set { mIsToCurrencyLoadingEnabled = value; } }
	

}

							//AdventureWorks.Model.Person
				
	public partial class PersonSearchObject : A.Core.Model.BaseSearchObject<PersonAdditionalSearchRequestData>
{
	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String PersonType { get; set; }
	

	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String FirstName { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.String FirstNameGTE { get; set; }
	

	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String LastName { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.String LastNameGTE { get; set; }
	

	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? BusinessEntityID { get; set; }
	

}
public partial class PersonAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsEmailAddressesLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsEmailAddressesLoadingEnabled { get { return  mIsEmailAddressesLoadingEnabled; } set { mIsEmailAddressesLoadingEnabled = value; } }
	

	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsPasswordLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsPasswordLoadingEnabled { get { return  mIsPasswordLoadingEnabled; } set { mIsPasswordLoadingEnabled = value; } }
	

}

							//AdventureWorks.Model.EmailAddress
				
	public partial class EmailAddressSearchObject : A.Core.Model.BaseSearchObject<EmailAddressAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? EmailAddressID { get; set; }
	

}
public partial class EmailAddressAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.Currency
				
	public partial class CurrencySearchObject : A.Core.Model.BaseSearchObject<CurrencyAdditionalSearchRequestData>
{
	//PROP:string
	[Key]
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String CurrencyCode { get; set; }
	

	protected System.Collections.Generic.IList<System.String> mCurrencyCodeList = new System.Collections.Generic.List<System.String>();
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.List, false)]
	public virtual System.Collections.Generic.IList<System.String> CurrencyCodeList { get {return mCurrencyCodeList;} set { mCurrencyCodeList = value; }}
	

	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.String NameGTE { get; set; }
	

}
public partial class CurrencyAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.Vendor
				
	public partial class VendorSearchObject : A.Core.Model.BaseSearchObject<VendorAdditionalSearchRequestData>
{
	//PROP:string
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.String AccountNumber { get; set; }
	

	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.GreatherThanOrEqual, false)]
	public virtual System.String AccountNumberGTE { get; set; }
	

	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? BusinessEntityID { get; set; }
	

}
public partial class VendorAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.ContactType
				
	public partial class ContactTypeSearchObject : A.Core.Model.BaseSearchObject<ContactTypeAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? ContactTypeID { get; set; }
	

}
public partial class ContactTypeAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.BusinessEntity
				
	public partial class BusinessEntitySearchObject : A.Core.Model.BaseSearchObject<BusinessEntityAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? BusinessEntityID { get; set; }
	

}
public partial class BusinessEntityAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
}

							//AdventureWorks.Model.Employee
				
	public partial class EmployeeSearchObject : A.Core.Model.BaseSearchObject<EmployeeAdditionalSearchRequestData>
{
	[Key]//nofilter
	[A.Core.Attributes.Filter(A.Core.Attributes.FilterEnum.Equal, false)]
	public virtual System.Int32? BusinessEntityID { get; set; }
	

}
public partial class EmployeeAdditionalSearchRequestData :  A.Core.Model.BaseAdditionalSearchRequestData
{
	//A.Core.Attributes.LazyLoadingAttribute
	protected bool? mIsPersonLoadingEnabled = false;
	[A.Core.Attributes.LazyLoading(false)]
	public virtual bool? IsPersonLoadingEnabled { get { return  mIsPersonLoadingEnabled; } set { mIsPersonLoadingEnabled = value; } }
	

}

		
}



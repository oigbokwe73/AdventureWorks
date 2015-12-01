using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Linq;

namespace AdventureWorksDAL.DataContext
{
    public partial class DALDataContext : System.Data.Linq.DataContext
    {
        public DALDataContext(string connection_string) : base(connection_string) { }
        public DALDataContext(IDbConnection connection) : base(connection) { }

        //Define all the table/entities to be used
        public Table<Store> Store { get { return this.GetTable<Store>(); } }
        public Table<PurchaseOrderDetail> PurchaseOrderDetail { get { return this.GetTable<PurchaseOrderDetail>(); } }
        public Table<PurchaseOrderHeader> PurchaseOrderHeader { get { return this.GetTable<PurchaseOrderHeader>(); } }
        public Table<ShipMethod> ShipMethod { get { return this.GetTable<ShipMethod>(); } }
        public Table<Vendor> Vendor { get { return this.GetTable<Vendor>(); } }
        public Table<CountryRegionCurrency> CountryRegionCurrency { get { return this.GetTable<CountryRegionCurrency>(); } }
        public Table<CreditCard> CreditCard { get { return this.GetTable<CreditCard>(); } }
        public Table<Currency> Currency { get { return this.GetTable<Currency>(); } }
        public Table<CurrencyRate> CurrencyRate { get { return this.GetTable<CurrencyRate>(); } }
        public Table<Customer> Customer { get { return this.GetTable<Customer>(); } }
        public Table<PersonCreditCard> PersonCreditCard { get { return this.GetTable<PersonCreditCard>(); } }
        public Table<SalesOrderDetail> SalesOrderDetail { get { return this.GetTable<SalesOrderDetail>(); } }
        public Table<SalesOrderHeader> SalesOrderHeader { get { return this.GetTable<SalesOrderHeader>(); } }
        public Table<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReason { get { return this.GetTable<SalesOrderHeaderSalesReason>(); } }
        public Table<SalesPerson> SalesPerson { get { return this.GetTable<SalesPerson>(); } }
        public Table<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get { return this.GetTable<SalesPersonQuotaHistory>(); } }
        public Table<SalesReason> SalesReason { get { return this.GetTable<SalesReason>(); } }
        public Table<SalesTaxRate> SalesTaxRate { get { return this.GetTable<SalesTaxRate>(); } }
        public Table<SalesTerritory> SalesTerritory { get { return this.GetTable<SalesTerritory>(); } }
        public Table<SalesTerritoryHistory> SalesTerritoryHistory { get { return this.GetTable<SalesTerritoryHistory>(); } }
        public Table<ShoppingCartItem> ShoppingCartItem { get { return this.GetTable<ShoppingCartItem>(); } }
        public Table<SpecialOffer> SpecialOffer { get { return this.GetTable<SpecialOffer>(); } }
        public Table<SpecialOfferProduct> SpecialOfferProduct { get { return this.GetTable<SpecialOfferProduct>(); } }
        public Table<ProductVendor> ProductVendor { get { return this.GetTable<ProductVendor>(); } }
        public Table<ProductPhoto> ProductPhoto { get { return this.GetTable<ProductPhoto>(); } }
        public Table<ProductProductPhoto> ProductProductPhoto { get { return this.GetTable<ProductProductPhoto>(); } }
        public Table<ProductReview> ProductReview { get { return this.GetTable<ProductReview>(); } }
        public Table<ProductSubcategory> ProductSubcategory { get { return this.GetTable<ProductSubcategory>(); } }
        public Table<ScrapReason> ScrapReason { get { return this.GetTable<ScrapReason>(); } }
        public Table<TransactionHistory> TransactionHistory { get { return this.GetTable<TransactionHistory>(); } }
        public Table<TransactionHistoryArchive> TransactionHistoryArchive { get { return this.GetTable<TransactionHistoryArchive>(); } }
        public Table<UnitMeasure> UnitMeasure { get { return this.GetTable<UnitMeasure>(); } }
        public Table<WorkOrder> WorkOrder { get { return this.GetTable<WorkOrder>(); } }
        public Table<WorkOrderRouting> WorkOrderRouting { get { return this.GetTable<WorkOrderRouting>(); } }
        public Table<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get { return this.GetTable<ProductModelProductDescriptionCulture>(); } }
        public Table<ProductModel> ProductModel { get { return this.GetTable<ProductModel>(); } }
        public Table<ProductModelIllustration> ProductModelIllustration { get { return this.GetTable<ProductModelIllustration>(); } }
        public Table<ProductListPriceHistory> ProductListPriceHistory { get { return this.GetTable<ProductListPriceHistory>(); } }
        public Table<ProductInventory> ProductInventory { get { return this.GetTable<ProductInventory>(); } }
        public Table<ProductDescription> ProductDescription { get { return this.GetTable<ProductDescription>(); } }
        public Table<Illustration> Illustration { get { return this.GetTable<Illustration>(); } }
        public Table<Location> Location { get { return this.GetTable<Location>(); } }
        public Table<Product> Product { get { return this.GetTable<Product>(); } }
        public Table<ProductCategory> ProductCategory { get { return this.GetTable<ProductCategory>(); } }
        public Table<ProductCostHistory> ProductCostHistory { get { return this.GetTable<ProductCostHistory>(); } }
        public Table<Illustration1> Illustration1 { get { return this.GetTable<Illustration1>(); } }
        public Table<Culture> Culture { get { return this.GetTable<Culture>(); } }
        public Table<BillOfMaterial> BillOfMaterial { get { return this.GetTable<BillOfMaterial>(); } }
        public Table<Password> Password { get { return this.GetTable<Password>(); } }
        public Table<Person> Person { get { return this.GetTable<Person>(); } }
        public Table<PersonPhone> PersonPhone { get { return this.GetTable<PersonPhone>(); } }
        public Table<PhoneNumberType> PhoneNumberType { get { return this.GetTable<PhoneNumberType>(); } }
        public Table<StateProvince> StateProvince { get { return this.GetTable<StateProvince>(); } }
        public Table<EmailAddress> EmailAddress { get { return this.GetTable<EmailAddress>(); } }
        public Table<BusinessEntityAddress> BusinessEntityAddress { get { return this.GetTable<BusinessEntityAddress>(); } }
        public Table<BusinessEntityContact> BusinessEntityContact { get { return this.GetTable<BusinessEntityContact>(); } }
        public Table<ContactType> ContactType { get { return this.GetTable<ContactType>(); } }
        public Table<CountryRegion> CountryRegion { get { return this.GetTable<CountryRegion>(); } }
        public Table<JobCandidate> JobCandidate { get { return this.GetTable<JobCandidate>(); } }
        public Table<EmployeePayHistory> EmployeePayHistory { get { return this.GetTable<EmployeePayHistory>(); } }
        public Table<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get { return this.GetTable<EmployeeDepartmentHistory>(); } }
        public Table<Department> Department { get { return this.GetTable<Department>(); } }
        public Table<DatabaseLog> DatabaseLog { get { return this.GetTable<DatabaseLog>(); } }
        public Table<ErrorLog> ErrorLog { get { return this.GetTable<ErrorLog>(); } }
        public Table<AWBuildVersion> AWBuildVersion { get { return this.GetTable<AWBuildVersion>(); } }
        public Table<BusinessEntity> BusinessEntity { get { return this.GetTable<BusinessEntity>(); } }
        public Table<vProductAndDescription> vProductAndDescription { get { return this.GetTable<vProductAndDescription>(); } }
        
        
        

        
        
        
        

        
        






        //Store  procedure



        //[FunctionAttribute(Name = "dbo.USP_WXP_LOG_TRANSACTION")]
        //public int USP_WXP_LOG_TRANSACTION([ParameterAttribute(Name = "TRANSACTION_GUID", DbType = "VarChar(50)")] string tRANSACTION_GUID, [ParameterAttribute(Name = "TRANSACTION_TYPE", DbType = "VarChar(50)")] string tRANSACTION_TYPE, [ParameterAttribute(Name = "COMMENT", DbType = "VarChar(200)")] string cOMMENT, [ParameterAttribute(Name = "STATUS", DbType = "VarChar(50)")] string sTATUS, [ParameterAttribute(Name = "XML", DbType = "Xml")] System.Xml.Linq.XElement xML, [ParameterAttribute(Name = "TIMESTAMP", DbType = "DateTime")] System.Nullable<System.DateTime> tIMESTAMP, [ParameterAttribute(Name = "CORRELATION_ID", DbType = "VarChar(50)")] string cORRELATION_ID)
        //{
        //    IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tRANSACTION_GUID, tRANSACTION_TYPE, cOMMENT, sTATUS, xML, tIMESTAMP, cORRELATION_ID);
        //    return ((int)(result.ReturnValue));
        //}



    }
}

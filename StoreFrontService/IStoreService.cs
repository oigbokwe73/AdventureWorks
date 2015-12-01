using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AdventureWorksDAL.DataContext;

namespace StoreFrontService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStoreService" in both code and config file together.
    [ServiceContract]
    public interface IStoreService
    {
        [OperationContract]
        void StoreAdd(Store store);
        [OperationContract]
        void StoreUpdate(Store store);
        [OperationContract]
        void StoreDelete(Store store);
        [OperationContract]
        List<Store> StoreList();
        [OperationContract]
        List<Store> StoreListAll();
        [OperationContract]
        void PurchaseOrderDetailAdd(PurchaseOrderDetail purchaseorderdetail);
        [OperationContract]
        void PurchaseOrderDetailUpdate(PurchaseOrderDetail purchaseorderdetail);
        [OperationContract]
        void PurchaseOrderDetailDelete(PurchaseOrderDetail purchaseorderdetail);
        [OperationContract]
        List<PurchaseOrderDetail> PurchaseOrderDetailList();
        [OperationContract]
        List<PurchaseOrderDetail> PurchaseOrderDetailListAll();
        [OperationContract]
        void PurchaseOrderHeaderAdd(PurchaseOrderHeader purchaseorderheader);
        [OperationContract]
        void PurchaseOrderHeaderUpdate(PurchaseOrderHeader purchaseorderheader);
        [OperationContract]
        void PurchaseOrderHeaderDelete(PurchaseOrderHeader purchaseorderheader);
        [OperationContract]
        List<PurchaseOrderHeader> PurchaseOrderHeaderList();
        [OperationContract]
        List<PurchaseOrderHeader> PurchaseOrderHeaderListAll();
        [OperationContract]
        void ShipMethodAdd(ShipMethod shipmethod);
        [OperationContract]
        void ShipMethodUpdate(ShipMethod shipmethod);
        [OperationContract]
        void ShipMethodDelete(ShipMethod shipmethod);
        [OperationContract]
        List<ShipMethod> ShipMethodList();
        [OperationContract]
        List<ShipMethod> ShipMethodListAll();
        [OperationContract]
        void VendorAdd(Vendor vendor);
        [OperationContract]
        void VendorUpdate(Vendor vendor);
        [OperationContract]
        void VendorDelete(Vendor vendor);
        [OperationContract]
        List<Vendor> VendorList();
        [OperationContract]
        List<Vendor> VendorListAll();
        [OperationContract]
        void CountryRegionCurrencyAdd(CountryRegionCurrency countryregioncurrency);
        [OperationContract]
        void CountryRegionCurrencyUpdate(CountryRegionCurrency countryregioncurrency);
        [OperationContract]
        void CountryRegionCurrencyDelete(CountryRegionCurrency countryregioncurrency);
        [OperationContract]
        List<CountryRegionCurrency> CountryRegionCurrencyList();
        [OperationContract]
        List<CountryRegionCurrency> CountryRegionCurrencyListAll();
        [OperationContract]
        void CreditCardAdd(CreditCard creditcard);
        [OperationContract]
        void CreditCardUpdate(CreditCard creditcard);
        [OperationContract]
        void CreditCardDelete(CreditCard creditcard);
        [OperationContract]
        List<CreditCard> CreditCardList();
        [OperationContract]
        List<CreditCard> CreditCardListAll();
        [OperationContract]
        void CurrencyAdd(Currency currency);
        [OperationContract]
        void CurrencyUpdate(Currency currency);
        [OperationContract]
        void CurrencyDelete(Currency currency);
        [OperationContract]
        List<Currency> CurrencyList();
        [OperationContract]
        List<Currency> CurrencyListAll();
        [OperationContract]
        void CurrencyRateAdd(CurrencyRate currencyrate);
        [OperationContract]
        void CurrencyRateUpdate(CurrencyRate currencyrate);
        [OperationContract]
        void CurrencyRateDelete(CurrencyRate currencyrate);
        [OperationContract]
        List<CurrencyRate> CurrencyRateList();
        [OperationContract]
        List<CurrencyRate> CurrencyRateListAll();
        [OperationContract]
        void CustomerAdd(Customer customer);
        [OperationContract]
        void CustomerUpdate(Customer customer);
        [OperationContract]
        void CustomerDelete(Customer customer);
        [OperationContract]
        List<Customer> CustomerList();
        [OperationContract]
        List<Customer> CustomerListAll();
        [OperationContract]
        void PersonCreditCardAdd(PersonCreditCard personcreditcard);
        [OperationContract]
        void PersonCreditCardUpdate(PersonCreditCard personcreditcard);
        [OperationContract]
        void PersonCreditCardDelete(PersonCreditCard personcreditcard);
        [OperationContract]
        List<PersonCreditCard> PersonCreditCardList();
        [OperationContract]
        List<PersonCreditCard> PersonCreditCardListAll();
        [OperationContract]
        void SalesOrderDetailAdd(SalesOrderDetail salesorderdetail);
        [OperationContract]
        void SalesOrderDetailUpdate(SalesOrderDetail salesorderdetail);
        [OperationContract]
        void SalesOrderDetailDelete(SalesOrderDetail salesorderdetail);
        [OperationContract]
        List<SalesOrderDetail> SalesOrderDetailList();
        [OperationContract]
        List<SalesOrderDetail> SalesOrderDetailListAll();
        [OperationContract]
        void SalesOrderHeaderAdd(SalesOrderHeader salesorderheader);
        [OperationContract]
        void SalesOrderHeaderUpdate(SalesOrderHeader salesorderheader);
        [OperationContract]
        void SalesOrderHeaderDelete(SalesOrderHeader salesorderheader);
        [OperationContract]
        List<SalesOrderHeader> SalesOrderHeaderList();
        [OperationContract]
        List<SalesOrderHeader> SalesOrderHeaderListAll();
        [OperationContract]
        void SalesOrderHeaderSalesReasonAdd(SalesOrderHeaderSalesReason salesorderheadersalesreason);
        [OperationContract]
        void SalesOrderHeaderSalesReasonUpdate(SalesOrderHeaderSalesReason salesorderheadersalesreason);
        [OperationContract]
        void SalesOrderHeaderSalesReasonDelete(SalesOrderHeaderSalesReason salesorderheadersalesreason);
        [OperationContract]
        List<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasonList();
        [OperationContract]
        List<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasonListAll();
        [OperationContract]
        void SalesPersonAdd(SalesPerson salesperson);
        [OperationContract]
        void SalesPersonUpdate(SalesPerson salesperson);
        [OperationContract]
        void SalesPersonDelete(SalesPerson salesperson);
        [OperationContract]
        List<SalesPerson> SalesPersonList();
        [OperationContract]
        List<SalesPerson> SalesPersonListAll();
        [OperationContract]
        void SalesPersonQuotaHistoryAdd(SalesPersonQuotaHistory salespersonquotahistory);
        [OperationContract]
        void SalesPersonQuotaHistoryUpdate(SalesPersonQuotaHistory salespersonquotahistory);
        [OperationContract]
        void SalesPersonQuotaHistoryDelete(SalesPersonQuotaHistory salespersonquotahistory);
        [OperationContract]
        List<SalesPersonQuotaHistory> SalesPersonQuotaHistoryList();
        [OperationContract]
        List<SalesPersonQuotaHistory> SalesPersonQuotaHistoryListAll();
        [OperationContract]
        void SalesReasonAdd(SalesReason salesreason);
        [OperationContract]
        void SalesReasonUpdate(SalesReason salesreason);
        [OperationContract]
        void SalesReasonDelete(SalesReason salesreason);
        [OperationContract]
        List<SalesReason> SalesReasonList();
        [OperationContract]
        List<SalesReason> SalesReasonListAll();
        [OperationContract]
        void SalesTaxRateAdd(SalesTaxRate salestaxrate);
        [OperationContract]
        void SalesTaxRateUpdate(SalesTaxRate salestaxrate);
        [OperationContract]
        void SalesTaxRateDelete(SalesTaxRate salestaxrate);
        [OperationContract]
        List<SalesTaxRate> SalesTaxRateList();
        [OperationContract]
        List<SalesTaxRate> SalesTaxRateListAll();
        [OperationContract]
        void SalesTerritoryAdd(SalesTerritory salesterritory);
        [OperationContract]
        void SalesTerritoryUpdate(SalesTerritory salesterritory);
        [OperationContract]
        void SalesTerritoryDelete(SalesTerritory salesterritory);
        [OperationContract]
        List<SalesTerritory> SalesTerritoryList();
        [OperationContract]
        List<SalesTerritory> SalesTerritoryListAll();
        [OperationContract]
        void SalesTerritoryHistoryAdd(SalesTerritoryHistory salesterritoryhistory);
        [OperationContract]
        void SalesTerritoryHistoryUpdate(SalesTerritoryHistory salesterritoryhistory);
        [OperationContract]
        void SalesTerritoryHistoryDelete(SalesTerritoryHistory salesterritoryhistory);
        [OperationContract]
        List<SalesTerritoryHistory> SalesTerritoryHistoryList();
        [OperationContract]
        List<SalesTerritoryHistory> SalesTerritoryHistoryListAll();
        [OperationContract]
        void ShoppingCartItemAdd(ShoppingCartItem shoppingcartitem);
        [OperationContract]
        void ShoppingCartItemUpdate(ShoppingCartItem shoppingcartitem);
        [OperationContract]
        void ShoppingCartItemDelete(ShoppingCartItem shoppingcartitem);
        [OperationContract]
        List<ShoppingCartItem> ShoppingCartItemList();
        [OperationContract]
        List<ShoppingCartItem> ShoppingCartItemListAll();
        [OperationContract]
        void SpecialOfferAdd(SpecialOffer specialoffer);
        [OperationContract]
        void SpecialOfferUpdate(SpecialOffer specialoffer);
        [OperationContract]
        void SpecialOfferDelete(SpecialOffer specialoffer);
        [OperationContract]
        List<SpecialOffer> SpecialOfferList();
        [OperationContract]
        List<SpecialOffer> SpecialOfferListAll();
        [OperationContract]
        void SpecialOfferProductAdd(SpecialOfferProduct specialofferproduct);
        [OperationContract]
        void SpecialOfferProductUpdate(SpecialOfferProduct specialofferproduct);
        [OperationContract]
        void SpecialOfferProductDelete(SpecialOfferProduct specialofferproduct);
        [OperationContract]
        List<SpecialOfferProduct> SpecialOfferProductList();
        [OperationContract]
        List<SpecialOfferProduct> SpecialOfferProductListAll();
        [OperationContract]
        void ProductVendorAdd(ProductVendor productvendor);
        [OperationContract]
        void ProductVendorUpdate(ProductVendor productvendor);
        [OperationContract]
        void ProductVendorDelete(ProductVendor productvendor);
        [OperationContract]
        List<ProductVendor> ProductVendorList();
        [OperationContract]
        List<ProductVendor> ProductVendorListAll();
        [OperationContract]
        void ProductPhotoAdd(ProductPhoto productphoto);
        [OperationContract]
        void ProductPhotoUpdate(ProductPhoto productphoto);
        [OperationContract]
        void ProductPhotoDelete(ProductPhoto productphoto);
        [OperationContract]
        List<ProductPhoto> ProductPhotoList();
        [OperationContract]
        List<ProductPhoto> ProductPhotoListAll();
        [OperationContract]
        void ProductProductPhotoAdd(ProductProductPhoto productproductphoto);
        [OperationContract]
        void ProductProductPhotoUpdate(ProductProductPhoto productproductphoto);
        [OperationContract]
        void ProductProductPhotoDelete(ProductProductPhoto productproductphoto);
        [OperationContract]
        List<ProductProductPhoto> ProductProductPhotoList();
        [OperationContract]
        List<ProductProductPhoto> ProductProductPhotoListAll();
        [OperationContract]
        void ProductReviewAdd(ProductReview productreview);
        [OperationContract]
        void ProductReviewUpdate(ProductReview productreview);
        [OperationContract]
        void ProductReviewDelete(ProductReview productreview);
        [OperationContract]
        List<ProductReview> ProductReviewList();
        [OperationContract]
        List<ProductReview> ProductReviewListAll();
        [OperationContract]
        void ProductSubcategoryAdd(ProductSubcategory productsubcategory);
        [OperationContract]
        void ProductSubcategoryUpdate(ProductSubcategory productsubcategory);
        [OperationContract]
        void ProductSubcategoryDelete(ProductSubcategory productsubcategory);
        [OperationContract]
        List<ProductSubcategory> ProductSubcategoryList();
        [OperationContract]
        List<ProductSubcategory> ProductSubcategoryListAll();
        [OperationContract]
        void ScrapReasonAdd(ScrapReason scrapreason);
        [OperationContract]
        void ScrapReasonUpdate(ScrapReason scrapreason);
        [OperationContract]
        void ScrapReasonDelete(ScrapReason scrapreason);
        [OperationContract]
        List<ScrapReason> ScrapReasonList();
        [OperationContract]
        List<ScrapReason> ScrapReasonListAll();
        [OperationContract]
        void TransactionHistoryAdd(TransactionHistory transactionhistory);
        [OperationContract]
        void TransactionHistoryUpdate(TransactionHistory transactionhistory);
        [OperationContract]
        void TransactionHistoryDelete(TransactionHistory transactionhistory);
        [OperationContract]
        List<TransactionHistory> TransactionHistoryList();
        [OperationContract]
        List<TransactionHistory> TransactionHistoryListAll();
        [OperationContract]
        void TransactionHistoryArchiveAdd(TransactionHistoryArchive transactionhistoryarchive);
        [OperationContract]
        void TransactionHistoryArchiveUpdate(TransactionHistoryArchive transactionhistoryarchive);
        [OperationContract]
        void TransactionHistoryArchiveDelete(TransactionHistoryArchive transactionhistoryarchive);
        [OperationContract]
        List<TransactionHistoryArchive> TransactionHistoryArchiveList();
        [OperationContract]
        List<TransactionHistoryArchive> TransactionHistoryArchiveListAll();
        [OperationContract]
        void UnitMeasureAdd(UnitMeasure unitmeasure);
        [OperationContract]
        void UnitMeasureUpdate(UnitMeasure unitmeasure);
        [OperationContract]
        void UnitMeasureDelete(UnitMeasure unitmeasure);
        [OperationContract]
        List<UnitMeasure> UnitMeasureList();
        [OperationContract]
        List<UnitMeasure> UnitMeasureListAll();
        [OperationContract]
        void WorkOrderAdd(WorkOrder workorder);
        [OperationContract]
        void WorkOrderUpdate(WorkOrder workorder);
        [OperationContract]
        void WorkOrderDelete(WorkOrder workorder);
        [OperationContract]
        List<WorkOrder> WorkOrderList();
        [OperationContract]
        List<WorkOrder> WorkOrderListAll();
        [OperationContract]
        void WorkOrderRoutingAdd(WorkOrderRouting workorderrouting);
        [OperationContract]
        void WorkOrderRoutingUpdate(WorkOrderRouting workorderrouting);
        [OperationContract]
        void WorkOrderRoutingDelete(WorkOrderRouting workorderrouting);
        [OperationContract]
        List<WorkOrderRouting> WorkOrderRoutingList();
        [OperationContract]
        List<WorkOrderRouting> WorkOrderRoutingListAll();
        [OperationContract]
        void ProductModelProductDescriptionCultureAdd(ProductModelProductDescriptionCulture productmodelproductdescriptionculture);
        [OperationContract]
        void ProductModelProductDescriptionCultureUpdate(ProductModelProductDescriptionCulture productmodelproductdescriptionculture);
        [OperationContract]
        void ProductModelProductDescriptionCultureDelete(ProductModelProductDescriptionCulture productmodelproductdescriptionculture);
        [OperationContract]
        List<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultureList();
        [OperationContract]
        List<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultureListAll();
        [OperationContract]
        void ProductModelAdd(ProductModel productmodel);
        [OperationContract]
        void ProductModelUpdate(ProductModel productmodel);
        [OperationContract]
        void ProductModelDelete(ProductModel productmodel);
        [OperationContract]
        List<ProductModel> ProductModelList();
        [OperationContract]
        List<ProductModel> ProductModelListAll();
        [OperationContract]
        void ProductModelIllustrationAdd(ProductModelIllustration productmodelillustration);
        [OperationContract]
        void ProductModelIllustrationUpdate(ProductModelIllustration productmodelillustration);
        [OperationContract]
        void ProductModelIllustrationDelete(ProductModelIllustration productmodelillustration);
        [OperationContract]
        List<ProductModelIllustration> ProductModelIllustrationList();
        [OperationContract]
        List<ProductModelIllustration> ProductModelIllustrationListAll();
        [OperationContract]
        void ProductListPriceHistoryAdd(ProductListPriceHistory productlistpricehistory);
        [OperationContract]
        void ProductListPriceHistoryUpdate(ProductListPriceHistory productlistpricehistory);
        [OperationContract]
        void ProductListPriceHistoryDelete(ProductListPriceHistory productlistpricehistory);
        [OperationContract]
        List<ProductListPriceHistory> ProductListPriceHistoryList();
        [OperationContract]
        List<ProductListPriceHistory> ProductListPriceHistoryListAll();
        [OperationContract]
        void ProductInventoryAdd(ProductInventory productinventory);
        [OperationContract]
        void ProductInventoryUpdate(ProductInventory productinventory);
        [OperationContract]
        void ProductInventoryDelete(ProductInventory productinventory);
        [OperationContract]
        List<ProductInventory> ProductInventoryList();
        [OperationContract]
        List<ProductInventory> ProductInventoryListAll();
        [OperationContract]
        void ProductDescriptionAdd(ProductDescription productdescription);
        [OperationContract]
        void ProductDescriptionUpdate(ProductDescription productdescription);
        [OperationContract]
        void ProductDescriptionDelete(ProductDescription productdescription);
        [OperationContract]
        List<ProductDescription> ProductDescriptionList();
        [OperationContract]
        List<ProductDescription> ProductDescriptionListAll();
        [OperationContract]
        void IllustrationAdd(Illustration illustration);
        [OperationContract]
        void IllustrationUpdate(Illustration illustration);
        [OperationContract]
        void IllustrationDelete(Illustration illustration);
        [OperationContract]
        List<Illustration> IllustrationList();
        [OperationContract]
        List<Illustration> IllustrationListAll();
        [OperationContract]
        void LocationAdd(Location location);
        [OperationContract]
        void LocationUpdate(Location location);
        [OperationContract]
        void LocationDelete(Location location);
        [OperationContract]
        List<Location> LocationList();
        [OperationContract]
        List<Location> LocationListAll();
        [OperationContract]
        void ProductAdd(Product product);
        [OperationContract]
        void ProductUpdate(Product product);
        [OperationContract]
        void ProductDelete(Product product);
        [OperationContract]
        List<Product> ProductList();
        [OperationContract]
        List<Product> ProductListAll();
        [OperationContract]
        void ProductCategoryAdd(ProductCategory productcategory);
        [OperationContract]
        void ProductCategoryUpdate(ProductCategory productcategory);
        [OperationContract]
        void ProductCategoryDelete(ProductCategory productcategory);
        [OperationContract]
        List<ProductCategory> ProductCategoryList();
        [OperationContract]
        List<ProductCategory> ProductCategoryListAll();
        [OperationContract]
        void ProductCostHistoryAdd(ProductCostHistory productcosthistory);
        [OperationContract]
        void ProductCostHistoryUpdate(ProductCostHistory productcosthistory);
        [OperationContract]
        void ProductCostHistoryDelete(ProductCostHistory productcosthistory);
        [OperationContract]
        List<ProductCostHistory> ProductCostHistoryList();
        [OperationContract]
        List<ProductCostHistory> ProductCostHistoryListAll();
        [OperationContract]
        void Illustration1Add(Illustration1 illustration1);
        [OperationContract]
        void Illustration1Update(Illustration1 illustration1);
        [OperationContract]
        void Illustration1Delete(Illustration1 illustration1);
        [OperationContract]
        List<Illustration1> Illustration1List();
        [OperationContract]
        List<Illustration1> Illustration1ListAll();
        [OperationContract]
        void CultureAdd(Culture culture);
        [OperationContract]
        void CultureUpdate(Culture culture);
        [OperationContract]
        void CultureDelete(Culture culture);
        [OperationContract]
        List<Culture> CultureList();
        [OperationContract]
        List<Culture> CultureListAll();
        [OperationContract]
        void BillOfMaterialAdd(BillOfMaterial billofmaterial);
        [OperationContract]
        void BillOfMaterialUpdate(BillOfMaterial billofmaterial);
        [OperationContract]
        void BillOfMaterialDelete(BillOfMaterial billofmaterial);
        [OperationContract]
        List<BillOfMaterial> BillOfMaterialList();
        [OperationContract]
        List<BillOfMaterial> BillOfMaterialListAll();
        [OperationContract]
        void PasswordAdd(Password password);
        [OperationContract]
        void PasswordUpdate(Password password);
        [OperationContract]
        void PasswordDelete(Password password);
        [OperationContract]
        List<Password> PasswordList();
        [OperationContract]
        List<Password> PasswordListAll();
        [OperationContract]
        void PersonAdd(Person person);
        [OperationContract]
        void PersonUpdate(Person person);
        [OperationContract]
        void PersonDelete(Person person);
        [OperationContract]
        List<Person> PersonList();
        [OperationContract]
        List<Person> PersonListAll();
        [OperationContract]
        void PersonPhoneAdd(PersonPhone personphone);
        [OperationContract]
        void PersonPhoneUpdate(PersonPhone personphone);
        [OperationContract]
        void PersonPhoneDelete(PersonPhone personphone);
        [OperationContract]
        List<PersonPhone> PersonPhoneList();
        [OperationContract]
        List<PersonPhone> PersonPhoneListAll();
        [OperationContract]
        void PhoneNumberTypeAdd(PhoneNumberType phonenumbertype);
        [OperationContract]
        void PhoneNumberTypeUpdate(PhoneNumberType phonenumbertype);
        [OperationContract]
        void PhoneNumberTypeDelete(PhoneNumberType phonenumbertype);
        [OperationContract]
        List<PhoneNumberType> PhoneNumberTypeList();
        [OperationContract]
        List<PhoneNumberType> PhoneNumberTypeListAll();
        [OperationContract]
        void StateProvinceAdd(StateProvince stateprovince);
        [OperationContract]
        void StateProvinceUpdate(StateProvince stateprovince);
        [OperationContract]
        void StateProvinceDelete(StateProvince stateprovince);
        [OperationContract]
        List<StateProvince> StateProvinceList();
        [OperationContract]
        List<StateProvince> StateProvinceListAll();
        [OperationContract]
        void EmailAddressAdd(EmailAddress emailaddress);
        [OperationContract]
        void EmailAddressUpdate(EmailAddress emailaddress);
        [OperationContract]
        void EmailAddressDelete(EmailAddress emailaddress);
        [OperationContract]
        List<EmailAddress> EmailAddressList();
        [OperationContract]
        List<EmailAddress> EmailAddressListAll();
        [OperationContract]
        void BusinessEntityAddressAdd(BusinessEntityAddress businessentityaddress);
        [OperationContract]
        void BusinessEntityAddressUpdate(BusinessEntityAddress businessentityaddress);
        [OperationContract]
        void BusinessEntityAddressDelete(BusinessEntityAddress businessentityaddress);
        [OperationContract]
        List<BusinessEntityAddress> BusinessEntityAddressList();
        [OperationContract]
        List<BusinessEntityAddress> BusinessEntityAddressListAll();
        [OperationContract]
        void BusinessEntityContactAdd(BusinessEntityContact businessentitycontact);
        [OperationContract]
        void BusinessEntityContactUpdate(BusinessEntityContact businessentitycontact);
        [OperationContract]
        void BusinessEntityContactDelete(BusinessEntityContact businessentitycontact);
        [OperationContract]
        List<BusinessEntityContact> BusinessEntityContactList();
        [OperationContract]
        List<BusinessEntityContact> BusinessEntityContactListAll();
        [OperationContract]
        void ContactTypeAdd(ContactType contacttype);
        [OperationContract]
        void ContactTypeUpdate(ContactType contacttype);
        [OperationContract]
        void ContactTypeDelete(ContactType contacttype);
        [OperationContract]
        List<ContactType> ContactTypeList();
        [OperationContract]
        List<ContactType> ContactTypeListAll();
        [OperationContract]
        void CountryRegionAdd(CountryRegion countryregion);
        [OperationContract]
        void CountryRegionUpdate(CountryRegion countryregion);
        [OperationContract]
        void CountryRegionDelete(CountryRegion countryregion);
        [OperationContract]
        List<CountryRegion> CountryRegionList();
        [OperationContract]
        List<CountryRegion> CountryRegionListAll();
        [OperationContract]
        void JobCandidateAdd(JobCandidate jobcandidate);
        [OperationContract]
        void JobCandidateUpdate(JobCandidate jobcandidate);
        [OperationContract]
        void JobCandidateDelete(JobCandidate jobcandidate);
        [OperationContract]
        List<JobCandidate> JobCandidateList();
        [OperationContract]
        List<JobCandidate> JobCandidateListAll();
        [OperationContract]
        void EmployeePayHistoryAdd(EmployeePayHistory employeepayhistory);
        [OperationContract]
        void EmployeePayHistoryUpdate(EmployeePayHistory employeepayhistory);
        [OperationContract]
        void EmployeePayHistoryDelete(EmployeePayHistory employeepayhistory);
        [OperationContract]
        List<EmployeePayHistory> EmployeePayHistoryList();
        [OperationContract]
        List<EmployeePayHistory> EmployeePayHistoryListAll();
        [OperationContract]
        void EmployeeDepartmentHistoryAdd(EmployeeDepartmentHistory employeedepartmenthistory);
        [OperationContract]
        void EmployeeDepartmentHistoryUpdate(EmployeeDepartmentHistory employeedepartmenthistory);
        [OperationContract]
        void EmployeeDepartmentHistoryDelete(EmployeeDepartmentHistory employeedepartmenthistory);
        [OperationContract]
        List<EmployeeDepartmentHistory> EmployeeDepartmentHistoryList();
        [OperationContract]
        List<EmployeeDepartmentHistory> EmployeeDepartmentHistoryListAll();
        [OperationContract]
        void DepartmentAdd(Department department);
        [OperationContract]
        void DepartmentUpdate(Department department);
        [OperationContract]
        void DepartmentDelete(Department department);
        [OperationContract]
        List<Department> DepartmentList();
        [OperationContract]
        List<Department> DepartmentListAll();
        [OperationContract]
        void DatabaseLogAdd(DatabaseLog databaselog);
        [OperationContract]
        void DatabaseLogUpdate(DatabaseLog databaselog);
        [OperationContract]
        void DatabaseLogDelete(DatabaseLog databaselog);
        [OperationContract]
        List<DatabaseLog> DatabaseLogList();
        [OperationContract]
        List<DatabaseLog> DatabaseLogListAll();
        [OperationContract]
        void ErrorLogAdd(ErrorLog errorlog);
        [OperationContract]
        void ErrorLogUpdate(ErrorLog errorlog);
        [OperationContract]
        void ErrorLogDelete(ErrorLog errorlog);
        [OperationContract]
        List<ErrorLog> ErrorLogList();
        [OperationContract]
        List<ErrorLog> ErrorLogListAll();
        [OperationContract]
        void AWBuildVersionAdd(AWBuildVersion awbuildversion);
        [OperationContract]
        void AWBuildVersionUpdate(AWBuildVersion awbuildversion);
        [OperationContract]
        void AWBuildVersionDelete(AWBuildVersion awbuildversion);
        [OperationContract]
        List<AWBuildVersion> AWBuildVersionList();
        [OperationContract]
        List<AWBuildVersion> AWBuildVersionListAll();
        [OperationContract]
        void vProductAndDescriptionAdd(vProductAndDescription vproductanddescription);
        [OperationContract]
        void vProductAndDescriptionUpdate(vProductAndDescription vproductanddescription);
        [OperationContract]
        void vProductAndDescriptionDelete(vProductAndDescription vproductanddescription);
        [OperationContract]
        List<vProductAndDescription> vProductAndDescriptionList();
        [OperationContract]
        List<vProductAndDescription> vProductAndDescriptionListAll();
    }
}
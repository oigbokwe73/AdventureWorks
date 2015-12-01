using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
using AdventureWorksDAL.BusinessComponents;
using AdventureWorksDAL.DataContext;


namespace StoreFrontService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StoreService" in code, svc and config file together.
    public class StoreService : IStoreService
    {
        AdventureWorksDataContext adventureWorks_BC = new AdventureWorksDataContext();

        public void StoreAdd(Store store)
        {
            adventureWorks_BC.StoreAdd(store);
        }
        public void StoreUpdate(Store store)
        {
            adventureWorks_BC.StoreUpdate(store);
        }
        public void StoreDelete(Store store)
        {
            adventureWorks_BC.StoreDelete(store);
        }
        public List<Store> StoreList()
        {
            return adventureWorks_BC.StoreList();
        }
        public List<Store> StoreListAll()
        {
            return adventureWorks_BC.StoreListAll();
        }
        public void PurchaseOrderDetailAdd(PurchaseOrderDetail purchaseorderdetail)
        {
            adventureWorks_BC.PurchaseOrderDetailAdd(purchaseorderdetail);
        }
        public void PurchaseOrderDetailUpdate(PurchaseOrderDetail purchaseorderdetail)
        {
            adventureWorks_BC.PurchaseOrderDetailUpdate(purchaseorderdetail);
        }
        public void PurchaseOrderDetailDelete(PurchaseOrderDetail purchaseorderdetail)
        {
            adventureWorks_BC.PurchaseOrderDetailDelete(purchaseorderdetail);
        }
        public List<PurchaseOrderDetail> PurchaseOrderDetailList()
        {
            return adventureWorks_BC.PurchaseOrderDetailList();
        }
        public List<PurchaseOrderDetail> PurchaseOrderDetailListAll()
        {
            return adventureWorks_BC.PurchaseOrderDetailListAll();
        }
        public void PurchaseOrderHeaderAdd(PurchaseOrderHeader purchaseorderheader)
        {
            adventureWorks_BC.PurchaseOrderHeaderAdd(purchaseorderheader);
        }
        public void PurchaseOrderHeaderUpdate(PurchaseOrderHeader purchaseorderheader)
        {
            adventureWorks_BC.PurchaseOrderHeaderUpdate(purchaseorderheader);
        }
        public void PurchaseOrderHeaderDelete(PurchaseOrderHeader purchaseorderheader)
        {
            adventureWorks_BC.PurchaseOrderHeaderDelete(purchaseorderheader);
        }
        public List<PurchaseOrderHeader> PurchaseOrderHeaderList()
        {
            return adventureWorks_BC.PurchaseOrderHeaderList();
        }
        public List<PurchaseOrderHeader> PurchaseOrderHeaderListAll()
        {
            return adventureWorks_BC.PurchaseOrderHeaderListAll();
        }
        public void ShipMethodAdd(ShipMethod shipmethod)
        {
            adventureWorks_BC.ShipMethodAdd(shipmethod);
        }
        public void ShipMethodUpdate(ShipMethod shipmethod)
        {
            adventureWorks_BC.ShipMethodUpdate(shipmethod);
        }
        public void ShipMethodDelete(ShipMethod shipmethod)
        {
            adventureWorks_BC.ShipMethodDelete(shipmethod);
        }
        public List<ShipMethod> ShipMethodList()
        {
            return adventureWorks_BC.ShipMethodList();
        }
        public List<ShipMethod> ShipMethodListAll()
        {
            return adventureWorks_BC.ShipMethodListAll();
        }
        public void VendorAdd(Vendor vendor)
        {
            adventureWorks_BC.VendorAdd(vendor);
        }
        public void VendorUpdate(Vendor vendor)
        {
            adventureWorks_BC.VendorUpdate(vendor);
        }
        public void VendorDelete(Vendor vendor)
        {
            adventureWorks_BC.VendorDelete(vendor);
        }
        public List<Vendor> VendorList()
        {
            return adventureWorks_BC.VendorList();
        }
        public List<Vendor> VendorListAll()
        {
            return adventureWorks_BC.VendorListAll();
        }
        public void CountryRegionCurrencyAdd(CountryRegionCurrency countryregioncurrency)
        {
            adventureWorks_BC.CountryRegionCurrencyAdd(countryregioncurrency);
        }
        public void CountryRegionCurrencyUpdate(CountryRegionCurrency countryregioncurrency)
        {
            adventureWorks_BC.CountryRegionCurrencyUpdate(countryregioncurrency);
        }
        public void CountryRegionCurrencyDelete(CountryRegionCurrency countryregioncurrency)
        {
            adventureWorks_BC.CountryRegionCurrencyDelete(countryregioncurrency);
        }
        public List<CountryRegionCurrency> CountryRegionCurrencyList()
        {
            return adventureWorks_BC.CountryRegionCurrencyList();
        }
        public List<CountryRegionCurrency> CountryRegionCurrencyListAll()
        {
            return adventureWorks_BC.CountryRegionCurrencyListAll();
        }
        public void CreditCardAdd(CreditCard creditcard)
        {
            adventureWorks_BC.CreditCardAdd(creditcard);
        }
        public void CreditCardUpdate(CreditCard creditcard)
        {
            adventureWorks_BC.CreditCardUpdate(creditcard);
        }
        public void CreditCardDelete(CreditCard creditcard)
        {
            adventureWorks_BC.CreditCardDelete(creditcard);
        }
        public List<CreditCard> CreditCardList()
        {
            return adventureWorks_BC.CreditCardList();
        }
        public List<CreditCard> CreditCardListAll()
        {
            return adventureWorks_BC.CreditCardListAll();
        }
        public void CurrencyAdd(Currency currency)
        {
            adventureWorks_BC.CurrencyAdd(currency);
        }
        public void CurrencyUpdate(Currency currency)
        {
            adventureWorks_BC.CurrencyUpdate(currency);
        }
        public void CurrencyDelete(Currency currency)
        {
            adventureWorks_BC.CurrencyDelete(currency);
        }
        public List<Currency> CurrencyList()
        {
            return adventureWorks_BC.CurrencyList();
        }
        public List<Currency> CurrencyListAll()
        {
            return adventureWorks_BC.CurrencyListAll();
        }
        public void CurrencyRateAdd(CurrencyRate currencyrate)
        {
            adventureWorks_BC.CurrencyRateAdd(currencyrate);
        }
        public void CurrencyRateUpdate(CurrencyRate currencyrate)
        {
            adventureWorks_BC.CurrencyRateUpdate(currencyrate);
        }
        public void CurrencyRateDelete(CurrencyRate currencyrate)
        {
            adventureWorks_BC.CurrencyRateDelete(currencyrate);
        }
        public List<CurrencyRate> CurrencyRateList()
        {
            return adventureWorks_BC.CurrencyRateList();
        }
        public List<CurrencyRate> CurrencyRateListAll()
        {
            return adventureWorks_BC.CurrencyRateListAll();
        }
        public void CustomerAdd(Customer customer)
        {
            adventureWorks_BC.CustomerAdd(customer);
        }
        public void CustomerUpdate(Customer customer)
        {
            adventureWorks_BC.CustomerUpdate(customer);
        }
        public void CustomerDelete(Customer customer)
        {
            adventureWorks_BC.CustomerDelete(customer);
        }
        public List<Customer> CustomerList()
        {
            return adventureWorks_BC.CustomerList();
        }
        public List<Customer> CustomerListAll()
        {
            return adventureWorks_BC.CustomerListAll();
        }
        public void PersonCreditCardAdd(PersonCreditCard personcreditcard)
        {
            adventureWorks_BC.PersonCreditCardAdd(personcreditcard);
        }
        public void PersonCreditCardUpdate(PersonCreditCard personcreditcard)
        {
            adventureWorks_BC.PersonCreditCardUpdate(personcreditcard);
        }
        public void PersonCreditCardDelete(PersonCreditCard personcreditcard)
        {
            adventureWorks_BC.PersonCreditCardDelete(personcreditcard);
        }
        public List<PersonCreditCard> PersonCreditCardList()
        {
            return adventureWorks_BC.PersonCreditCardList();
        }
        public List<PersonCreditCard> PersonCreditCardListAll()
        {
            return adventureWorks_BC.PersonCreditCardListAll();
        }
        public void SalesOrderDetailAdd(SalesOrderDetail salesorderdetail)
        {
            adventureWorks_BC.SalesOrderDetailAdd(salesorderdetail);
        }
        public void SalesOrderDetailUpdate(SalesOrderDetail salesorderdetail)
        {
            adventureWorks_BC.SalesOrderDetailUpdate(salesorderdetail);
        }
        public void SalesOrderDetailDelete(SalesOrderDetail salesorderdetail)
        {
            adventureWorks_BC.SalesOrderDetailDelete(salesorderdetail);
        }
        public List<SalesOrderDetail> SalesOrderDetailList()
        {
            return adventureWorks_BC.SalesOrderDetailList();
        }
        public List<SalesOrderDetail> SalesOrderDetailListAll()
        {
            return adventureWorks_BC.SalesOrderDetailListAll();
        }
        public void SalesOrderHeaderAdd(SalesOrderHeader salesorderheader)
        {
            adventureWorks_BC.SalesOrderHeaderAdd(salesorderheader);
        }
        public void SalesOrderHeaderUpdate(SalesOrderHeader salesorderheader)
        {
            adventureWorks_BC.SalesOrderHeaderUpdate(salesorderheader);
        }
        public void SalesOrderHeaderDelete(SalesOrderHeader salesorderheader)
        {
            adventureWorks_BC.SalesOrderHeaderDelete(salesorderheader);
        }
        public List<SalesOrderHeader> SalesOrderHeaderList()
        {
            return adventureWorks_BC.SalesOrderHeaderList();
        }
        public List<SalesOrderHeader> SalesOrderHeaderListAll()
        {
            return adventureWorks_BC.SalesOrderHeaderListAll();
        }
        public void SalesOrderHeaderSalesReasonAdd(SalesOrderHeaderSalesReason salesorderheadersalesreason)
        {
            adventureWorks_BC.SalesOrderHeaderSalesReasonAdd(salesorderheadersalesreason);
        }
        public void SalesOrderHeaderSalesReasonUpdate(SalesOrderHeaderSalesReason salesorderheadersalesreason)
        {
            adventureWorks_BC.SalesOrderHeaderSalesReasonUpdate(salesorderheadersalesreason);
        }
        public void SalesOrderHeaderSalesReasonDelete(SalesOrderHeaderSalesReason salesorderheadersalesreason)
        {
            adventureWorks_BC.SalesOrderHeaderSalesReasonDelete(salesorderheadersalesreason);
        }
        public List<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasonList()
        {
            return adventureWorks_BC.SalesOrderHeaderSalesReasonList();
        }
        public List<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasonListAll()
        {
            return adventureWorks_BC.SalesOrderHeaderSalesReasonListAll();
        }
        public void SalesPersonAdd(SalesPerson salesperson)
        {
            adventureWorks_BC.SalesPersonAdd(salesperson);
        }
        public void SalesPersonUpdate(SalesPerson salesperson)
        {
            adventureWorks_BC.SalesPersonUpdate(salesperson);
        }
        public void SalesPersonDelete(SalesPerson salesperson)
        {
            adventureWorks_BC.SalesPersonDelete(salesperson);
        }
        public List<SalesPerson> SalesPersonList()
        {
            return adventureWorks_BC.SalesPersonList();
        }
        public List<SalesPerson> SalesPersonListAll()
        {
            return adventureWorks_BC.SalesPersonListAll();
        }
        public void SalesPersonQuotaHistoryAdd(SalesPersonQuotaHistory salespersonquotahistory)
        {
            adventureWorks_BC.SalesPersonQuotaHistoryAdd(salespersonquotahistory);
        }
        public void SalesPersonQuotaHistoryUpdate(SalesPersonQuotaHistory salespersonquotahistory)
        {
            adventureWorks_BC.SalesPersonQuotaHistoryUpdate(salespersonquotahistory);
        }
        public void SalesPersonQuotaHistoryDelete(SalesPersonQuotaHistory salespersonquotahistory)
        {
            adventureWorks_BC.SalesPersonQuotaHistoryDelete(salespersonquotahistory);
        }
        public List<SalesPersonQuotaHistory> SalesPersonQuotaHistoryList()
        {
            return adventureWorks_BC.SalesPersonQuotaHistoryList();
        }
        public List<SalesPersonQuotaHistory> SalesPersonQuotaHistoryListAll()
        {
            return adventureWorks_BC.SalesPersonQuotaHistoryListAll();
        }
        public void SalesReasonAdd(SalesReason salesreason)
        {
            adventureWorks_BC.SalesReasonAdd(salesreason);
        }
        public void SalesReasonUpdate(SalesReason salesreason)
        {
            adventureWorks_BC.SalesReasonUpdate(salesreason);
        }
        public void SalesReasonDelete(SalesReason salesreason)
        {
            adventureWorks_BC.SalesReasonDelete(salesreason);
        }
        public List<SalesReason> SalesReasonList()
        {
            return adventureWorks_BC.SalesReasonList();
        }
        public List<SalesReason> SalesReasonListAll()
        {
            return adventureWorks_BC.SalesReasonListAll();
        }
        public void SalesTaxRateAdd(SalesTaxRate salestaxrate)
        {
            adventureWorks_BC.SalesTaxRateAdd(salestaxrate);
        }
        public void SalesTaxRateUpdate(SalesTaxRate salestaxrate)
        {
            adventureWorks_BC.SalesTaxRateUpdate(salestaxrate);
        }
        public void SalesTaxRateDelete(SalesTaxRate salestaxrate)
        {
            adventureWorks_BC.SalesTaxRateDelete(salestaxrate);
        }
        public List<SalesTaxRate> SalesTaxRateList()
        {
            return adventureWorks_BC.SalesTaxRateList();
        }
        public List<SalesTaxRate> SalesTaxRateListAll()
        {
            return adventureWorks_BC.SalesTaxRateListAll();
        }
        public void SalesTerritoryAdd(SalesTerritory salesterritory)
        {
            adventureWorks_BC.SalesTerritoryAdd(salesterritory);
        }
        public void SalesTerritoryUpdate(SalesTerritory salesterritory)
        {
            adventureWorks_BC.SalesTerritoryUpdate(salesterritory);
        }
        public void SalesTerritoryDelete(SalesTerritory salesterritory)
        {
            adventureWorks_BC.SalesTerritoryDelete(salesterritory);
        }
        public List<SalesTerritory> SalesTerritoryList()
        {
            return adventureWorks_BC.SalesTerritoryList();
        }
        public List<SalesTerritory> SalesTerritoryListAll()
        {
            return adventureWorks_BC.SalesTerritoryListAll();
        }
        public void SalesTerritoryHistoryAdd(SalesTerritoryHistory salesterritoryhistory)
        {
            adventureWorks_BC.SalesTerritoryHistoryAdd(salesterritoryhistory);
        }
        public void SalesTerritoryHistoryUpdate(SalesTerritoryHistory salesterritoryhistory)
        {
            adventureWorks_BC.SalesTerritoryHistoryUpdate(salesterritoryhistory);
        }
        public void SalesTerritoryHistoryDelete(SalesTerritoryHistory salesterritoryhistory)
        {
            adventureWorks_BC.SalesTerritoryHistoryDelete(salesterritoryhistory);
        }
        public List<SalesTerritoryHistory> SalesTerritoryHistoryList()
        {
            return adventureWorks_BC.SalesTerritoryHistoryList();
        }
        public List<SalesTerritoryHistory> SalesTerritoryHistoryListAll()
        {
            return adventureWorks_BC.SalesTerritoryHistoryListAll();
        }
        public void ShoppingCartItemAdd(ShoppingCartItem shoppingcartitem)
        {
            adventureWorks_BC.ShoppingCartItemAdd(shoppingcartitem);
        }
        public void ShoppingCartItemUpdate(ShoppingCartItem shoppingcartitem)
        {
            adventureWorks_BC.ShoppingCartItemUpdate(shoppingcartitem);
        }
        public void ShoppingCartItemDelete(ShoppingCartItem shoppingcartitem)
        {
            adventureWorks_BC.ShoppingCartItemDelete(shoppingcartitem);
        }
        public List<ShoppingCartItem> ShoppingCartItemList()
        {
            return adventureWorks_BC.ShoppingCartItemList();
        }
        public List<ShoppingCartItem> ShoppingCartItemListAll()
        {
            return adventureWorks_BC.ShoppingCartItemListAll();
        }
        public void SpecialOfferAdd(SpecialOffer specialoffer)
        {
            adventureWorks_BC.SpecialOfferAdd(specialoffer);
        }
        public void SpecialOfferUpdate(SpecialOffer specialoffer)
        {
            adventureWorks_BC.SpecialOfferUpdate(specialoffer);
        }
        public void SpecialOfferDelete(SpecialOffer specialoffer)
        {
            adventureWorks_BC.SpecialOfferDelete(specialoffer);
        }
        public List<SpecialOffer> SpecialOfferList()
        {
            return adventureWorks_BC.SpecialOfferList();
        }
        public List<SpecialOffer> SpecialOfferListAll()
        {
            return adventureWorks_BC.SpecialOfferListAll();
        }
        public void SpecialOfferProductAdd(SpecialOfferProduct specialofferproduct)
        {
            adventureWorks_BC.SpecialOfferProductAdd(specialofferproduct);
        }
        public void SpecialOfferProductUpdate(SpecialOfferProduct specialofferproduct)
        {
            adventureWorks_BC.SpecialOfferProductUpdate(specialofferproduct);
        }
        public void SpecialOfferProductDelete(SpecialOfferProduct specialofferproduct)
        {
            adventureWorks_BC.SpecialOfferProductDelete(specialofferproduct);
        }
        public List<SpecialOfferProduct> SpecialOfferProductList()
        {
            return adventureWorks_BC.SpecialOfferProductList();
        }
        public List<SpecialOfferProduct> SpecialOfferProductListAll()
        {
            return adventureWorks_BC.SpecialOfferProductListAll();
        }
        public void ProductVendorAdd(ProductVendor productvendor)
        {
            adventureWorks_BC.ProductVendorAdd(productvendor);
        }
        public void ProductVendorUpdate(ProductVendor productvendor)
        {
            adventureWorks_BC.ProductVendorUpdate(productvendor);
        }
        public void ProductVendorDelete(ProductVendor productvendor)
        {
            adventureWorks_BC.ProductVendorDelete(productvendor);
        }
        public List<ProductVendor> ProductVendorList()
        {
            return adventureWorks_BC.ProductVendorList();
        }
        public List<ProductVendor> ProductVendorListAll()
        {
            return adventureWorks_BC.ProductVendorListAll();
        }
        public void ProductPhotoAdd(ProductPhoto productphoto)
        {
            adventureWorks_BC.ProductPhotoAdd(productphoto);
        }
        public void ProductPhotoUpdate(ProductPhoto productphoto)
        {
            adventureWorks_BC.ProductPhotoUpdate(productphoto);
        }
        public void ProductPhotoDelete(ProductPhoto productphoto)
        {
            adventureWorks_BC.ProductPhotoDelete(productphoto);
        }
        public List<ProductPhoto> ProductPhotoList()
        {
            return adventureWorks_BC.ProductPhotoList();
        }
        public List<ProductPhoto> ProductPhotoListAll()
        {
            return adventureWorks_BC.ProductPhotoListAll();
        }
        public void ProductProductPhotoAdd(ProductProductPhoto productproductphoto)
        {
            adventureWorks_BC.ProductProductPhotoAdd(productproductphoto);
        }
        public void ProductProductPhotoUpdate(ProductProductPhoto productproductphoto)
        {
            adventureWorks_BC.ProductProductPhotoUpdate(productproductphoto);
        }
        public void ProductProductPhotoDelete(ProductProductPhoto productproductphoto)
        {
            adventureWorks_BC.ProductProductPhotoDelete(productproductphoto);
        }
        public List<ProductProductPhoto> ProductProductPhotoList()
        {
            return adventureWorks_BC.ProductProductPhotoList();
        }
        public List<ProductProductPhoto> ProductProductPhotoListAll()
        {
            return adventureWorks_BC.ProductProductPhotoListAll();
        }
        public void ProductReviewAdd(ProductReview productreview)
        {
            adventureWorks_BC.ProductReviewAdd(productreview);
        }
        public void ProductReviewUpdate(ProductReview productreview)
        {
            adventureWorks_BC.ProductReviewUpdate(productreview);
        }
        public void ProductReviewDelete(ProductReview productreview)
        {
            adventureWorks_BC.ProductReviewDelete(productreview);
        }
        public List<ProductReview> ProductReviewList()
        {
            return adventureWorks_BC.ProductReviewList();
        }
        public List<ProductReview> ProductReviewListAll()
        {
            return adventureWorks_BC.ProductReviewListAll();
        }
        public void ProductSubcategoryAdd(ProductSubcategory productsubcategory)
        {
            adventureWorks_BC.ProductSubcategoryAdd(productsubcategory);
        }
        public void ProductSubcategoryUpdate(ProductSubcategory productsubcategory)
        {
            adventureWorks_BC.ProductSubcategoryUpdate(productsubcategory);
        }
        public void ProductSubcategoryDelete(ProductSubcategory productsubcategory)
        {
            adventureWorks_BC.ProductSubcategoryDelete(productsubcategory);
        }
        public List<ProductSubcategory> ProductSubcategoryList()
        {
            return adventureWorks_BC.ProductSubcategoryList();
        }
        public List<ProductSubcategory> ProductSubcategoryListAll()
        {
            return adventureWorks_BC.ProductSubcategoryListAll();
        }
        public void ScrapReasonAdd(ScrapReason scrapreason)
        {
            adventureWorks_BC.ScrapReasonAdd(scrapreason);
        }
        public void ScrapReasonUpdate(ScrapReason scrapreason)
        {
            adventureWorks_BC.ScrapReasonUpdate(scrapreason);
        }
        public void ScrapReasonDelete(ScrapReason scrapreason)
        {
            adventureWorks_BC.ScrapReasonDelete(scrapreason);
        }
        public List<ScrapReason> ScrapReasonList()
        {
            return adventureWorks_BC.ScrapReasonList();
        }
        public List<ScrapReason> ScrapReasonListAll()
        {
            return adventureWorks_BC.ScrapReasonListAll();
        }
        public void TransactionHistoryAdd(TransactionHistory transactionhistory)
        {
            adventureWorks_BC.TransactionHistoryAdd(transactionhistory);
        }
        public void TransactionHistoryUpdate(TransactionHistory transactionhistory)
        {
            adventureWorks_BC.TransactionHistoryUpdate(transactionhistory);
        }
        public void TransactionHistoryDelete(TransactionHistory transactionhistory)
        {
            adventureWorks_BC.TransactionHistoryDelete(transactionhistory);
        }
        public List<TransactionHistory> TransactionHistoryList()
        {
            return adventureWorks_BC.TransactionHistoryList();
        }
        public List<TransactionHistory> TransactionHistoryListAll()
        {
            return adventureWorks_BC.TransactionHistoryListAll();
        }
        public void TransactionHistoryArchiveAdd(TransactionHistoryArchive transactionhistoryarchive)
        {
            adventureWorks_BC.TransactionHistoryArchiveAdd(transactionhistoryarchive);
        }
        public void TransactionHistoryArchiveUpdate(TransactionHistoryArchive transactionhistoryarchive)
        {
            adventureWorks_BC.TransactionHistoryArchiveUpdate(transactionhistoryarchive);
        }
        public void TransactionHistoryArchiveDelete(TransactionHistoryArchive transactionhistoryarchive)
        {
            adventureWorks_BC.TransactionHistoryArchiveDelete(transactionhistoryarchive);
        }
        public List<TransactionHistoryArchive> TransactionHistoryArchiveList()
        {
            return adventureWorks_BC.TransactionHistoryArchiveList();
        }
        public List<TransactionHistoryArchive> TransactionHistoryArchiveListAll()
        {
            return adventureWorks_BC.TransactionHistoryArchiveListAll();
        }
        public void UnitMeasureAdd(UnitMeasure unitmeasure)
        {
            adventureWorks_BC.UnitMeasureAdd(unitmeasure);
        }
        public void UnitMeasureUpdate(UnitMeasure unitmeasure)
        {
            adventureWorks_BC.UnitMeasureUpdate(unitmeasure);
        }
        public void UnitMeasureDelete(UnitMeasure unitmeasure)
        {
            adventureWorks_BC.UnitMeasureDelete(unitmeasure);
        }
        public List<UnitMeasure> UnitMeasureList()
        {
            return adventureWorks_BC.UnitMeasureList();
        }
        public List<UnitMeasure> UnitMeasureListAll()
        {
            return adventureWorks_BC.UnitMeasureListAll();
        }
        public void WorkOrderAdd(WorkOrder workorder)
        {
            adventureWorks_BC.WorkOrderAdd(workorder);
        }
        public void WorkOrderUpdate(WorkOrder workorder)
        {
            adventureWorks_BC.WorkOrderUpdate(workorder);
        }
        public void WorkOrderDelete(WorkOrder workorder)
        {
            adventureWorks_BC.WorkOrderDelete(workorder);
        }
        public List<WorkOrder> WorkOrderList()
        {
            return adventureWorks_BC.WorkOrderList();
        }
        public List<WorkOrder> WorkOrderListAll()
        {
            return adventureWorks_BC.WorkOrderListAll();
        }
        public void WorkOrderRoutingAdd(WorkOrderRouting workorderrouting)
        {
            adventureWorks_BC.WorkOrderRoutingAdd(workorderrouting);
        }
        public void WorkOrderRoutingUpdate(WorkOrderRouting workorderrouting)
        {
            adventureWorks_BC.WorkOrderRoutingUpdate(workorderrouting);
        }
        public void WorkOrderRoutingDelete(WorkOrderRouting workorderrouting)
        {
            adventureWorks_BC.WorkOrderRoutingDelete(workorderrouting);
        }
        public List<WorkOrderRouting> WorkOrderRoutingList()
        {
            return adventureWorks_BC.WorkOrderRoutingList();
        }
        public List<WorkOrderRouting> WorkOrderRoutingListAll()
        {
            return adventureWorks_BC.WorkOrderRoutingListAll();
        }
        public void ProductModelProductDescriptionCultureAdd(ProductModelProductDescriptionCulture productmodelproductdescriptionculture)
        {
            adventureWorks_BC.ProductModelProductDescriptionCultureAdd(productmodelproductdescriptionculture);
        }
        public void ProductModelProductDescriptionCultureUpdate(ProductModelProductDescriptionCulture productmodelproductdescriptionculture)
        {
            adventureWorks_BC.ProductModelProductDescriptionCultureUpdate(productmodelproductdescriptionculture);
        }
        public void ProductModelProductDescriptionCultureDelete(ProductModelProductDescriptionCulture productmodelproductdescriptionculture)
        {
            adventureWorks_BC.ProductModelProductDescriptionCultureDelete(productmodelproductdescriptionculture);
        }
        public List<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultureList()
        {
            return adventureWorks_BC.ProductModelProductDescriptionCultureList();
        }
        public List<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultureListAll()
        {
            return adventureWorks_BC.ProductModelProductDescriptionCultureListAll();
        }
        public void ProductModelAdd(ProductModel productmodel)
        {
            adventureWorks_BC.ProductModelAdd(productmodel);
        }
        public void ProductModelUpdate(ProductModel productmodel)
        {
            adventureWorks_BC.ProductModelUpdate(productmodel);
        }
        public void ProductModelDelete(ProductModel productmodel)
        {
            adventureWorks_BC.ProductModelDelete(productmodel);
        }
        public List<ProductModel> ProductModelList()
        {
            return adventureWorks_BC.ProductModelList();
        }
        public List<ProductModel> ProductModelListAll()
        {
            return adventureWorks_BC.ProductModelListAll();
        }
        public void ProductModelIllustrationAdd(ProductModelIllustration productmodelillustration)
        {
            adventureWorks_BC.ProductModelIllustrationAdd(productmodelillustration);
        }
        public void ProductModelIllustrationUpdate(ProductModelIllustration productmodelillustration)
        {
            adventureWorks_BC.ProductModelIllustrationUpdate(productmodelillustration);
        }
        public void ProductModelIllustrationDelete(ProductModelIllustration productmodelillustration)
        {
            adventureWorks_BC.ProductModelIllustrationDelete(productmodelillustration);
        }
        public List<ProductModelIllustration> ProductModelIllustrationList()
        {
            return adventureWorks_BC.ProductModelIllustrationList();
        }
        public List<ProductModelIllustration> ProductModelIllustrationListAll()
        {
            return adventureWorks_BC.ProductModelIllustrationListAll();
        }
        public void ProductListPriceHistoryAdd(ProductListPriceHistory productlistpricehistory)
        {
            adventureWorks_BC.ProductListPriceHistoryAdd(productlistpricehistory);
        }
        public void ProductListPriceHistoryUpdate(ProductListPriceHistory productlistpricehistory)
        {
            adventureWorks_BC.ProductListPriceHistoryUpdate(productlistpricehistory);
        }
        public void ProductListPriceHistoryDelete(ProductListPriceHistory productlistpricehistory)
        {
            adventureWorks_BC.ProductListPriceHistoryDelete(productlistpricehistory);
        }
        public List<ProductListPriceHistory> ProductListPriceHistoryList()
        {
            return adventureWorks_BC.ProductListPriceHistoryList();
        }
        public List<ProductListPriceHistory> ProductListPriceHistoryListAll()
        {
            return adventureWorks_BC.ProductListPriceHistoryListAll();
        }
        public void ProductInventoryAdd(ProductInventory productinventory)
        {
            adventureWorks_BC.ProductInventoryAdd(productinventory);
        }
        public void ProductInventoryUpdate(ProductInventory productinventory)
        {
            adventureWorks_BC.ProductInventoryUpdate(productinventory);
        }
        public void ProductInventoryDelete(ProductInventory productinventory)
        {
            adventureWorks_BC.ProductInventoryDelete(productinventory);
        }
        public List<ProductInventory> ProductInventoryList()
        {
            return adventureWorks_BC.ProductInventoryList();
        }
        public List<ProductInventory> ProductInventoryListAll()
        {
            return adventureWorks_BC.ProductInventoryListAll();
        }
        public void ProductDescriptionAdd(ProductDescription productdescription)
        {
            adventureWorks_BC.ProductDescriptionAdd(productdescription);
        }
        public void ProductDescriptionUpdate(ProductDescription productdescription)
        {
            adventureWorks_BC.ProductDescriptionUpdate(productdescription);
        }
        public void ProductDescriptionDelete(ProductDescription productdescription)
        {
            adventureWorks_BC.ProductDescriptionDelete(productdescription);
        }
        public List<ProductDescription> ProductDescriptionList()
        {
            return adventureWorks_BC.ProductDescriptionList();
        }
        public List<ProductDescription> ProductDescriptionListAll()
        {
            return adventureWorks_BC.ProductDescriptionListAll();
        }
        public void IllustrationAdd(Illustration illustration)
        {
            adventureWorks_BC.IllustrationAdd(illustration);
        }
        public void IllustrationUpdate(Illustration illustration)
        {
            adventureWorks_BC.IllustrationUpdate(illustration);
        }
        public void IllustrationDelete(Illustration illustration)
        {
            adventureWorks_BC.IllustrationDelete(illustration);
        }
        public List<Illustration> IllustrationList()
        {
            return adventureWorks_BC.IllustrationList();
        }
        public List<Illustration> IllustrationListAll()
        {
            return adventureWorks_BC.IllustrationListAll();
        }
        public void LocationAdd(Location location)
        {
            adventureWorks_BC.LocationAdd(location);
        }
        public void LocationUpdate(Location location)
        {
            adventureWorks_BC.LocationUpdate(location);
        }
        public void LocationDelete(Location location)
        {
            adventureWorks_BC.LocationDelete(location);
        }
        public List<Location> LocationList()
        {
            return adventureWorks_BC.LocationList();
        }
        public List<Location> LocationListAll()
        {
            return adventureWorks_BC.LocationListAll();
        }
        public void ProductAdd(Product product)
        {
            adventureWorks_BC.ProductAdd(product);
        }
        public void ProductUpdate(Product product)
        {
            adventureWorks_BC.ProductUpdate(product);
        }
        public void ProductDelete(Product product)
        {
            adventureWorks_BC.ProductDelete(product);
        }
        public List<Product> ProductList()
        {
            return adventureWorks_BC.ProductList();
        }
        public List<Product> ProductListAll()
        {
            return adventureWorks_BC.ProductListAll();
        }
        public void ProductCategoryAdd(ProductCategory productcategory)
        {
            adventureWorks_BC.ProductCategoryAdd(productcategory);
        }
        public void ProductCategoryUpdate(ProductCategory productcategory)
        {
            adventureWorks_BC.ProductCategoryUpdate(productcategory);
        }
        public void ProductCategoryDelete(ProductCategory productcategory)
        {
            adventureWorks_BC.ProductCategoryDelete(productcategory);
        }
        public List<ProductCategory> ProductCategoryList()
        {
            return adventureWorks_BC.ProductCategoryList();
        }
        public List<ProductCategory> ProductCategoryListAll()
        {
            return adventureWorks_BC.ProductCategoryListAll();
        }
        public void ProductCostHistoryAdd(ProductCostHistory productcosthistory)
        {
            adventureWorks_BC.ProductCostHistoryAdd(productcosthistory);
        }
        public void ProductCostHistoryUpdate(ProductCostHistory productcosthistory)
        {
            adventureWorks_BC.ProductCostHistoryUpdate(productcosthistory);
        }
        public void ProductCostHistoryDelete(ProductCostHistory productcosthistory)
        {
            adventureWorks_BC.ProductCostHistoryDelete(productcosthistory);
        }
        public List<ProductCostHistory> ProductCostHistoryList()
        {
            return adventureWorks_BC.ProductCostHistoryList();
        }
        public List<ProductCostHistory> ProductCostHistoryListAll()
        {
            return adventureWorks_BC.ProductCostHistoryListAll();
        }
        public void Illustration1Add(Illustration1 illustration1)
        {
            adventureWorks_BC.Illustration1Add(illustration1);
        }
        public void Illustration1Update(Illustration1 illustration1)
        {
            adventureWorks_BC.Illustration1Update(illustration1);
        }
        public void Illustration1Delete(Illustration1 illustration1)
        {
            adventureWorks_BC.Illustration1Delete(illustration1);
        }
        public List<Illustration1> Illustration1List()
        {
            return adventureWorks_BC.Illustration1List();
        }
        public List<Illustration1> Illustration1ListAll()
        {
            return adventureWorks_BC.Illustration1ListAll();
        }
        public void CultureAdd(Culture culture)
        {
            adventureWorks_BC.CultureAdd(culture);
        }
        public void CultureUpdate(Culture culture)
        {
            adventureWorks_BC.CultureUpdate(culture);
        }
        public void CultureDelete(Culture culture)
        {
            adventureWorks_BC.CultureDelete(culture);
        }
        public List<Culture> CultureList()
        {
            return adventureWorks_BC.CultureList();
        }
        public List<Culture> CultureListAll()
        {
            return adventureWorks_BC.CultureListAll();
        }
        public void BillOfMaterialAdd(BillOfMaterial billofmaterial)
        {
            adventureWorks_BC.BillOfMaterialAdd(billofmaterial);
        }
        public void BillOfMaterialUpdate(BillOfMaterial billofmaterial)
        {
            adventureWorks_BC.BillOfMaterialUpdate(billofmaterial);
        }
        public void BillOfMaterialDelete(BillOfMaterial billofmaterial)
        {
            adventureWorks_BC.BillOfMaterialDelete(billofmaterial);
        }
        public List<BillOfMaterial> BillOfMaterialList()
        {
            return adventureWorks_BC.BillOfMaterialList();
        }
        public List<BillOfMaterial> BillOfMaterialListAll()
        {
            return adventureWorks_BC.BillOfMaterialListAll();
        }
        public void PasswordAdd(Password password)
        {
            adventureWorks_BC.PasswordAdd(password);
        }
        public void PasswordUpdate(Password password)
        {
            adventureWorks_BC.PasswordUpdate(password);
        }
        public void PasswordDelete(Password password)
        {
            adventureWorks_BC.PasswordDelete(password);
        }
        public List<Password> PasswordList()
        {
            return adventureWorks_BC.PasswordList();
        }
        public List<Password> PasswordListAll()
        {
            return adventureWorks_BC.PasswordListAll();
        }
        public void PersonAdd(Person person)
        {
            adventureWorks_BC.PersonAdd(person);
        }
        public void PersonUpdate(Person person)
        {
            adventureWorks_BC.PersonUpdate(person);
        }
        public void PersonDelete(Person person)
        {
            adventureWorks_BC.PersonDelete(person);
        }
        public List<Person> PersonList()
        {
            return adventureWorks_BC.PersonList();
        }
        public List<Person> PersonListAll()
        {
            return adventureWorks_BC.PersonListAll();
        }
        public void PersonPhoneAdd(PersonPhone personphone)
        {
            adventureWorks_BC.PersonPhoneAdd(personphone);
        }
        public void PersonPhoneUpdate(PersonPhone personphone)
        {
            adventureWorks_BC.PersonPhoneUpdate(personphone);
        }
        public void PersonPhoneDelete(PersonPhone personphone)
        {
            adventureWorks_BC.PersonPhoneDelete(personphone);
        }
        public List<PersonPhone> PersonPhoneList()
        {
            return adventureWorks_BC.PersonPhoneList();
        }
        public List<PersonPhone> PersonPhoneListAll()
        {
            return adventureWorks_BC.PersonPhoneListAll();
        }
        public void PhoneNumberTypeAdd(PhoneNumberType phonenumbertype)
        {
            adventureWorks_BC.PhoneNumberTypeAdd(phonenumbertype);
        }
        public void PhoneNumberTypeUpdate(PhoneNumberType phonenumbertype)
        {
            adventureWorks_BC.PhoneNumberTypeUpdate(phonenumbertype);
        }
        public void PhoneNumberTypeDelete(PhoneNumberType phonenumbertype)
        {
            adventureWorks_BC.PhoneNumberTypeDelete(phonenumbertype);
        }
        public List<PhoneNumberType> PhoneNumberTypeList()
        {
            return adventureWorks_BC.PhoneNumberTypeList();
        }
        public List<PhoneNumberType> PhoneNumberTypeListAll()
        {
            return adventureWorks_BC.PhoneNumberTypeListAll();
        }
        public void StateProvinceAdd(StateProvince stateprovince)
        {
            adventureWorks_BC.StateProvinceAdd(stateprovince);
        }
        public void StateProvinceUpdate(StateProvince stateprovince)
        {
            adventureWorks_BC.StateProvinceUpdate(stateprovince);
        }
        public void StateProvinceDelete(StateProvince stateprovince)
        {
            adventureWorks_BC.StateProvinceDelete(stateprovince);
        }
        public List<StateProvince> StateProvinceList()
        {
            return adventureWorks_BC.StateProvinceList();
        }
        public List<StateProvince> StateProvinceListAll()
        {
            return adventureWorks_BC.StateProvinceListAll();
        }
        public void EmailAddressAdd(EmailAddress emailaddress)
        {
            adventureWorks_BC.EmailAddressAdd(emailaddress);
        }
        public void EmailAddressUpdate(EmailAddress emailaddress)
        {
            adventureWorks_BC.EmailAddressUpdate(emailaddress);
        }
        public void EmailAddressDelete(EmailAddress emailaddress)
        {
            adventureWorks_BC.EmailAddressDelete(emailaddress);
        }
        public List<EmailAddress> EmailAddressList()
        {
            return adventureWorks_BC.EmailAddressList();
        }
        public List<EmailAddress> EmailAddressListAll()
        {
            return adventureWorks_BC.EmailAddressListAll();
        }
        public void BusinessEntityAddressAdd(BusinessEntityAddress businessentityaddress)
        {
            adventureWorks_BC.BusinessEntityAddressAdd(businessentityaddress);
        }
        public void BusinessEntityAddressUpdate(BusinessEntityAddress businessentityaddress)
        {
            adventureWorks_BC.BusinessEntityAddressUpdate(businessentityaddress);
        }
        public void BusinessEntityAddressDelete(BusinessEntityAddress businessentityaddress)
        {
            adventureWorks_BC.BusinessEntityAddressDelete(businessentityaddress);
        }
        public List<BusinessEntityAddress> BusinessEntityAddressList()
        {
            return adventureWorks_BC.BusinessEntityAddressList();
        }
        public List<BusinessEntityAddress> BusinessEntityAddressListAll()
        {
            return adventureWorks_BC.BusinessEntityAddressListAll();
        }
        public void BusinessEntityContactAdd(BusinessEntityContact businessentitycontact)
        {
            adventureWorks_BC.BusinessEntityContactAdd(businessentitycontact);
        }
        public void BusinessEntityContactUpdate(BusinessEntityContact businessentitycontact)
        {
            adventureWorks_BC.BusinessEntityContactUpdate(businessentitycontact);
        }
        public void BusinessEntityContactDelete(BusinessEntityContact businessentitycontact)
        {
            adventureWorks_BC.BusinessEntityContactDelete(businessentitycontact);
        }
        public List<BusinessEntityContact> BusinessEntityContactList()
        {
            return adventureWorks_BC.BusinessEntityContactList();
        }
        public List<BusinessEntityContact> BusinessEntityContactListAll()
        {
            return adventureWorks_BC.BusinessEntityContactListAll();
        }
        public void ContactTypeAdd(ContactType contacttype)
        {
            adventureWorks_BC.ContactTypeAdd(contacttype);
        }
        public void ContactTypeUpdate(ContactType contacttype)
        {
            adventureWorks_BC.ContactTypeUpdate(contacttype);
        }
        public void ContactTypeDelete(ContactType contacttype)
        {
            adventureWorks_BC.ContactTypeDelete(contacttype);
        }
        public List<ContactType> ContactTypeList()
        {
            return adventureWorks_BC.ContactTypeList();
        }
        public List<ContactType> ContactTypeListAll()
        {
            return adventureWorks_BC.ContactTypeListAll();
        }
        public void CountryRegionAdd(CountryRegion countryregion)
        {
            adventureWorks_BC.CountryRegionAdd(countryregion);
        }
        public void CountryRegionUpdate(CountryRegion countryregion)
        {
            adventureWorks_BC.CountryRegionUpdate(countryregion);
        }
        public void CountryRegionDelete(CountryRegion countryregion)
        {
            adventureWorks_BC.CountryRegionDelete(countryregion);
        }
        public List<CountryRegion> CountryRegionList()
        {
            return adventureWorks_BC.CountryRegionList();
        }
        public List<CountryRegion> CountryRegionListAll()
        {
            return adventureWorks_BC.CountryRegionListAll();
        }
        public void JobCandidateAdd(JobCandidate jobcandidate)
        {
            adventureWorks_BC.JobCandidateAdd(jobcandidate);
        }
        public void JobCandidateUpdate(JobCandidate jobcandidate)
        {
            adventureWorks_BC.JobCandidateUpdate(jobcandidate);
        }
        public void JobCandidateDelete(JobCandidate jobcandidate)
        {
            adventureWorks_BC.JobCandidateDelete(jobcandidate);
        }
        public List<JobCandidate> JobCandidateList()
        {
            return adventureWorks_BC.JobCandidateList();
        }
        public List<JobCandidate> JobCandidateListAll()
        {
            return adventureWorks_BC.JobCandidateListAll();
        }
        public void EmployeePayHistoryAdd(EmployeePayHistory employeepayhistory)
        {
            adventureWorks_BC.EmployeePayHistoryAdd(employeepayhistory);
        }
        public void EmployeePayHistoryUpdate(EmployeePayHistory employeepayhistory)
        {
            adventureWorks_BC.EmployeePayHistoryUpdate(employeepayhistory);
        }
        public void EmployeePayHistoryDelete(EmployeePayHistory employeepayhistory)
        {
            adventureWorks_BC.EmployeePayHistoryDelete(employeepayhistory);
        }
        public List<EmployeePayHistory> EmployeePayHistoryList()
        {
            return adventureWorks_BC.EmployeePayHistoryList();
        }
        public List<EmployeePayHistory> EmployeePayHistoryListAll()
        {
            return adventureWorks_BC.EmployeePayHistoryListAll();
        }
        public void EmployeeDepartmentHistoryAdd(EmployeeDepartmentHistory employeedepartmenthistory)
        {
            adventureWorks_BC.EmployeeDepartmentHistoryAdd(employeedepartmenthistory);
        }
        public void EmployeeDepartmentHistoryUpdate(EmployeeDepartmentHistory employeedepartmenthistory)
        {
            adventureWorks_BC.EmployeeDepartmentHistoryUpdate(employeedepartmenthistory);
        }
        public void EmployeeDepartmentHistoryDelete(EmployeeDepartmentHistory employeedepartmenthistory)
        {
            adventureWorks_BC.EmployeeDepartmentHistoryDelete(employeedepartmenthistory);
        }
        public List<EmployeeDepartmentHistory> EmployeeDepartmentHistoryList()
        {
            return adventureWorks_BC.EmployeeDepartmentHistoryList();
        }
        public List<EmployeeDepartmentHistory> EmployeeDepartmentHistoryListAll()
        {
            return adventureWorks_BC.EmployeeDepartmentHistoryListAll();
        }
        public void DepartmentAdd(Department department)
        {
            adventureWorks_BC.DepartmentAdd(department);
        }
        public void DepartmentUpdate(Department department)
        {
            adventureWorks_BC.DepartmentUpdate(department);
        }
        public void DepartmentDelete(Department department)
        {
            adventureWorks_BC.DepartmentDelete(department);
        }
        public List<Department> DepartmentList()
        {
            return adventureWorks_BC.DepartmentList();
        }
        public List<Department> DepartmentListAll()
        {
            return adventureWorks_BC.DepartmentListAll();
        }
        public void DatabaseLogAdd(DatabaseLog databaselog)
        {
            adventureWorks_BC.DatabaseLogAdd(databaselog);
        }
        public void DatabaseLogUpdate(DatabaseLog databaselog)
        {
            adventureWorks_BC.DatabaseLogUpdate(databaselog);
        }
        public void DatabaseLogDelete(DatabaseLog databaselog)
        {
            adventureWorks_BC.DatabaseLogDelete(databaselog);
        }
        public List<DatabaseLog> DatabaseLogList()
        {
            return adventureWorks_BC.DatabaseLogList();
        }
        public List<DatabaseLog> DatabaseLogListAll()
        {
            return adventureWorks_BC.DatabaseLogListAll();
        }
        public void ErrorLogAdd(ErrorLog errorlog)
        {
            adventureWorks_BC.ErrorLogAdd(errorlog);
        }
        public void ErrorLogUpdate(ErrorLog errorlog)
        {
            adventureWorks_BC.ErrorLogUpdate(errorlog);
        }
        public void ErrorLogDelete(ErrorLog errorlog)
        {
            adventureWorks_BC.ErrorLogDelete(errorlog);
        }
        public List<ErrorLog> ErrorLogList()
        {
            return adventureWorks_BC.ErrorLogList();
        }
        public List<ErrorLog> ErrorLogListAll()
        {
            return adventureWorks_BC.ErrorLogListAll();
        }
        public void AWBuildVersionAdd(AWBuildVersion awbuildversion)
        {
            adventureWorks_BC.AWBuildVersionAdd(awbuildversion);
        }
        public void AWBuildVersionUpdate(AWBuildVersion awbuildversion)
        {
            adventureWorks_BC.AWBuildVersionUpdate(awbuildversion);
        }
        public void AWBuildVersionDelete(AWBuildVersion awbuildversion)
        {
            adventureWorks_BC.AWBuildVersionDelete(awbuildversion);
        }
        public List<AWBuildVersion> AWBuildVersionList()
        {
            return adventureWorks_BC.AWBuildVersionList();
        }
        public List<AWBuildVersion> AWBuildVersionListAll()
        {
            return adventureWorks_BC.AWBuildVersionListAll();
        }
        public void vProductAndDescriptionAdd(vProductAndDescription vproductanddescription)
        {
            adventureWorks_BC.vProductAndDescriptionAdd(vproductanddescription);
        }
        public void vProductAndDescriptionUpdate(vProductAndDescription vproductanddescription)
        {
            adventureWorks_BC.vProductAndDescriptionUpdate(vproductanddescription);
        }
        public void vProductAndDescriptionDelete(vProductAndDescription vproductanddescription)
        {
            adventureWorks_BC.vProductAndDescriptionDelete(vproductanddescription);
        }
        public List<vProductAndDescription> vProductAndDescriptionList()
        {
            return adventureWorks_BC.vProductAndDescriptionList();
        }
        public List<vProductAndDescription> vProductAndDescriptionListAll()
        {
            return adventureWorks_BC.vProductAndDescriptionListAll();
        }
    }
}

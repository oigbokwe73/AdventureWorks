using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksDAL.DataContext;
using System.Configuration;

namespace AdventureWorksDAL.BusinessComponents
{
    public partial class  AdventureWorksDataContext
    {

        public List<SalesOrderHeader> SalesOrderHeaderList()
        {
            var getSalesOrderHeader = Execute<List<SalesOrderHeader>>(dal =>
            {
                var item = dal.SalesOrderHeader.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesOrderHeader;
        }

        public List<SalesOrderHeader> SalesOrderHeaderListAll()
        {
            var getSalesOrderHeader = Execute<List<SalesOrderHeader>>(dal =>
            {
                var item = dal.SalesOrderHeader;
                return item.ToList();
            });
            return getSalesOrderHeader;
        }

        public bool SalesOrderHeaderUpdate(SalesOrderHeader salesorderheader)
        {
             return Execute<bool>(dal =>
            {
                SalesOrderHeader salesorderheaderUpdate = dal.SalesOrderHeader.Where(x => x.SalesOrderID == salesorderheader.SalesOrderID).FirstOrDefault();
                if (salesorderheaderUpdate != null)
                {
                    salesorderheaderUpdate.SalesOrderID = salesorderheader.SalesOrderID;
                    salesorderheaderUpdate.RevisionNumber = salesorderheader.RevisionNumber;
                    salesorderheaderUpdate.OrderDate = salesorderheader.OrderDate;
                    salesorderheaderUpdate.DueDate = salesorderheader.DueDate;
                    salesorderheaderUpdate.ShipDate = salesorderheader.ShipDate;
                    salesorderheaderUpdate.Status = salesorderheader.Status;
                    salesorderheaderUpdate.OnlineOrderFlag = salesorderheader.OnlineOrderFlag;
                    salesorderheaderUpdate.SalesOrderNumber = salesorderheader.SalesOrderNumber;
                    salesorderheaderUpdate.PurchaseOrderNumber = salesorderheader.PurchaseOrderNumber;
                    salesorderheaderUpdate.AccountNumber = salesorderheader.AccountNumber;
                    salesorderheaderUpdate.CustomerID = salesorderheader.CustomerID;
                    salesorderheaderUpdate.SalesPersonID = salesorderheader.SalesPersonID;
                    salesorderheaderUpdate.TerritoryID = salesorderheader.TerritoryID;
                    salesorderheaderUpdate.BillToAddressID = salesorderheader.BillToAddressID;
                    salesorderheaderUpdate.ShipToAddressID = salesorderheader.ShipToAddressID;
                    salesorderheaderUpdate.ShipMethodID = salesorderheader.ShipMethodID;
                    salesorderheaderUpdate.CreditCardID = salesorderheader.CreditCardID;
                    salesorderheaderUpdate.CreditCardApprovalCode = salesorderheader.CreditCardApprovalCode;
                    salesorderheaderUpdate.CurrencyRateID = salesorderheader.CurrencyRateID;
                    salesorderheaderUpdate.SubTotal = salesorderheader.SubTotal;
                    salesorderheaderUpdate.TaxAmt = salesorderheader.TaxAmt;
                    salesorderheaderUpdate.Freight = salesorderheader.Freight;
                    salesorderheaderUpdate.TotalDue = salesorderheader.TotalDue;
                    salesorderheaderUpdate.Comment = salesorderheader.Comment;
                    salesorderheaderUpdate.rowguid = salesorderheader.rowguid;
                    salesorderheaderUpdate.ModifiedDate = salesorderheader.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesOrderHeaderAdd(SalesOrderHeader salesorderheader)
        {
            return Execute<bool>(dal =>
            {
                SalesOrderHeader salesorderheaderAdd = dal.SalesOrderHeader.Where(x => x.SalesOrderID == salesorderheader.SalesOrderID).FirstOrDefault();
                if (salesorderheaderAdd != null)
                {
                    dal.SalesOrderHeader.InsertOnSubmit(salesorderheaderAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesOrderHeaderDelete(SalesOrderHeader salesorderheader)
        {
            return Execute<bool>(dal =>
            {
                SalesOrderHeader salesorderheaderDelete = dal.SalesOrderHeader.Where(x => x.SalesOrderID == salesorderheader.SalesOrderID).FirstOrDefault();
                if (salesorderheaderDelete != null)
                {
                    dal.SalesOrderHeader.DeleteOnSubmit(salesorderheaderDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

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

        public List<PurchaseOrderHeader> PurchaseOrderHeaderList()
        {
            var getPurchaseOrderHeader = Execute<List<PurchaseOrderHeader>>(dal =>
            {
                var item = dal.PurchaseOrderHeader.Skip(0).Take(100);
                return item.ToList();
            });
            return getPurchaseOrderHeader;
        }

        public List<PurchaseOrderHeader> PurchaseOrderHeaderListAll()
        {
            var getPurchaseOrderHeader = Execute<List<PurchaseOrderHeader>>(dal =>
            {
                var item = dal.PurchaseOrderHeader;
                return item.ToList();
            });
            return getPurchaseOrderHeader;
        }

        public bool PurchaseOrderHeaderUpdate(PurchaseOrderHeader purchaseorderheader)
        {
             return Execute<bool>(dal =>
            {
                PurchaseOrderHeader purchaseorderheaderUpdate = dal.PurchaseOrderHeader.Where(x => x.PurchaseOrderID == purchaseorderheader.PurchaseOrderID).FirstOrDefault();
                if (purchaseorderheaderUpdate != null)
                {
				    purchaseorderheaderUpdate.PurchaseOrderID=purchaseorderheader.PurchaseOrderID;
purchaseorderheaderUpdate.RevisionNumber=purchaseorderheader.RevisionNumber;
purchaseorderheaderUpdate.Status=purchaseorderheader.Status;
purchaseorderheaderUpdate.EmployeeID=purchaseorderheader.EmployeeID;
purchaseorderheaderUpdate.VendorID=purchaseorderheader.VendorID;
purchaseorderheaderUpdate.ShipMethodID=purchaseorderheader.ShipMethodID;
purchaseorderheaderUpdate.OrderDate=purchaseorderheader.OrderDate;
purchaseorderheaderUpdate.ShipDate=purchaseorderheader.ShipDate;
purchaseorderheaderUpdate.SubTotal=purchaseorderheader.SubTotal;
purchaseorderheaderUpdate.TaxAmt=purchaseorderheader.TaxAmt;
purchaseorderheaderUpdate.Freight=purchaseorderheader.Freight;
purchaseorderheaderUpdate.TotalDue=purchaseorderheader.TotalDue;
purchaseorderheaderUpdate.ModifiedDate=purchaseorderheader.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool PurchaseOrderHeaderAdd(PurchaseOrderHeader purchaseorderheader)
        {
            return Execute<bool>(dal =>
            {
                PurchaseOrderHeader purchaseorderheaderAdd = dal.PurchaseOrderHeader.Where(x => x.PurchaseOrderID == purchaseorderheader.PurchaseOrderID).FirstOrDefault();
                if (purchaseorderheaderAdd != null)
                {
                    dal.PurchaseOrderHeader.InsertOnSubmit(purchaseorderheaderAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PurchaseOrderHeaderDelete(PurchaseOrderHeader purchaseorderheader)
        {
            return Execute<bool>(dal =>
            {
                PurchaseOrderHeader purchaseorderheaderDelete = dal.PurchaseOrderHeader.Where(x => x.PurchaseOrderID == purchaseorderheader.PurchaseOrderID).FirstOrDefault();
                if (purchaseorderheaderDelete != null)
                {
                    dal.PurchaseOrderHeader.DeleteOnSubmit(purchaseorderheaderDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

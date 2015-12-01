using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksDAL.DataContext;
using System.Configuration;

namespace AdventureWorksDAL.BusinessComponents
{
    public partial class AdventureWorksDataContext
    {

        public List<PurchaseOrderDetail> PurchaseOrderDetailList()
        {
            var getPurchaseOrderDetail = Execute<List<PurchaseOrderDetail>>(dal =>
            {
                var item = dal.PurchaseOrderDetail.Skip(0).Take(100);
                return item.ToList();
            });
            return getPurchaseOrderDetail;
        }

        public List<PurchaseOrderDetail> PurchaseOrderDetailListAll()
        {
            var getPurchaseOrderDetail = Execute<List<PurchaseOrderDetail>>(dal =>
            {
                var item = dal.PurchaseOrderDetail;
                return item.ToList();
            });
            return getPurchaseOrderDetail;
        }

        public bool PurchaseOrderDetailUpdate(PurchaseOrderDetail purchaseorderdetail)
        {
            return Execute<bool>(dal =>
            {
                PurchaseOrderDetail purchaseorderdetailUpdate = dal.PurchaseOrderDetail.Where(x => x.PurchaseOrderID == purchaseorderdetail.PurchaseOrderID).FirstOrDefault();
                if (purchaseorderdetailUpdate != null)
                {
                    purchaseorderdetailUpdate.PurchaseOrderID = purchaseorderdetail.PurchaseOrderID;
                    purchaseorderdetailUpdate.PurchaseOrderDetailID = purchaseorderdetail.PurchaseOrderDetailID;
                    purchaseorderdetailUpdate.DueDate = purchaseorderdetail.DueDate;
                    purchaseorderdetailUpdate.OrderQty = purchaseorderdetail.OrderQty;
                    purchaseorderdetailUpdate.ProductID = purchaseorderdetail.ProductID;
                    purchaseorderdetailUpdate.UnitPrice = purchaseorderdetail.UnitPrice;
                    purchaseorderdetailUpdate.LineTotal = purchaseorderdetail.LineTotal;
                    purchaseorderdetailUpdate.ReceivedQty = purchaseorderdetail.ReceivedQty;
                    purchaseorderdetailUpdate.RejectedQty = purchaseorderdetail.RejectedQty;
                    purchaseorderdetailUpdate.StockedQty = purchaseorderdetail.StockedQty;
                    purchaseorderdetailUpdate.ModifiedDate = purchaseorderdetail.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PurchaseOrderDetailAdd(PurchaseOrderDetail purchaseorderdetail)
        {
            return Execute<bool>(dal =>
            {
                PurchaseOrderDetail purchaseorderdetailAdd = dal.PurchaseOrderDetail.Where(x => x.PurchaseOrderID == purchaseorderdetail.PurchaseOrderID).FirstOrDefault();
                if (purchaseorderdetailAdd != null)
                {
                    dal.PurchaseOrderDetail.InsertOnSubmit(purchaseorderdetailAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PurchaseOrderDetailDelete(PurchaseOrderDetail purchaseorderdetail)
        {
            return Execute<bool>(dal =>
            {
                PurchaseOrderDetail purchaseorderdetailDelete = dal.PurchaseOrderDetail.Where(x => x.PurchaseOrderID == purchaseorderdetail.PurchaseOrderID).FirstOrDefault();
                if (purchaseorderdetailDelete != null)
                {
                    dal.PurchaseOrderDetail.DeleteOnSubmit(purchaseorderdetailDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

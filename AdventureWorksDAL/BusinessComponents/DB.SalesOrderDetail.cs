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

        public List<SalesOrderDetail> SalesOrderDetailList()
        {
            var getSalesOrderDetail = Execute<List<SalesOrderDetail>>(dal =>
            {
                var item = dal.SalesOrderDetail.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesOrderDetail;
        }

        public List<SalesOrderDetail> SalesOrderDetailListAll()
        {
            var getSalesOrderDetail = Execute<List<SalesOrderDetail>>(dal =>
            {
                var item = dal.SalesOrderDetail;
                return item.ToList();
            });
            return getSalesOrderDetail;
        }

        public bool SalesOrderDetailUpdate(SalesOrderDetail salesorderdetail)
        {
             return Execute<bool>(dal =>
            {
                SalesOrderDetail salesorderdetailUpdate = dal.SalesOrderDetail.Where(x => x.SalesOrderID == salesorderdetail.SalesOrderID).FirstOrDefault();
                if (salesorderdetailUpdate != null)
                {
                    salesorderdetailUpdate.SalesOrderID = salesorderdetail.SalesOrderID;
                    salesorderdetailUpdate.SalesOrderDetailID = salesorderdetail.SalesOrderDetailID;
                    salesorderdetailUpdate.CarrierTrackingNumber = salesorderdetail.CarrierTrackingNumber;
                    salesorderdetailUpdate.OrderQty = salesorderdetail.OrderQty;
                    salesorderdetailUpdate.ProductID = salesorderdetail.ProductID;
                    salesorderdetailUpdate.SpecialOfferID = salesorderdetail.SpecialOfferID;
                    salesorderdetailUpdate.UnitPrice = salesorderdetail.UnitPrice;
                    salesorderdetailUpdate.UnitPriceDiscount = salesorderdetail.UnitPriceDiscount;
                    salesorderdetailUpdate.LineTotal = salesorderdetail.LineTotal;
                    salesorderdetailUpdate.rowguid = salesorderdetail.rowguid;
                    salesorderdetailUpdate.ModifiedDate = salesorderdetail.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesOrderDetailAdd(SalesOrderDetail salesorderdetail)
        {
            return Execute<bool>(dal =>
            {
                SalesOrderDetail salesorderdetailAdd = dal.SalesOrderDetail.Where(x => x.SalesOrderID == salesorderdetail.SalesOrderID).FirstOrDefault();
                if (salesorderdetailAdd != null)
                {
                    dal.SalesOrderDetail.InsertOnSubmit(salesorderdetailAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesOrderDetailDelete(SalesOrderDetail salesorderdetail)
        {
            return Execute<bool>(dal =>
            {
                SalesOrderDetail salesorderdetailDelete = dal.SalesOrderDetail.Where(x => x.SalesOrderID == salesorderdetail.SalesOrderID).FirstOrDefault();
                if (salesorderdetailDelete != null)
                {
                    dal.SalesOrderDetail.DeleteOnSubmit(salesorderdetailDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

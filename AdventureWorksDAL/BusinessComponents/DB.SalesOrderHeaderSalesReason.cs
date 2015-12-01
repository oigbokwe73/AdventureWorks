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

        public List<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasonList()
        {
            var getSalesOrderHeaderSalesReason = Execute<List<SalesOrderHeaderSalesReason>>(dal =>
            {
                var item = dal.SalesOrderHeaderSalesReason.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesOrderHeaderSalesReason;
        }

        public List<SalesOrderHeaderSalesReason> SalesOrderHeaderSalesReasonListAll()
        {
            var getSalesOrderHeaderSalesReason = Execute<List<SalesOrderHeaderSalesReason>>(dal =>
            {
                var item = dal.SalesOrderHeaderSalesReason;
                return item.ToList();
            });
            return getSalesOrderHeaderSalesReason;
        }

        public bool SalesOrderHeaderSalesReasonUpdate(SalesOrderHeaderSalesReason salesorderheadersalesreason)
        {
             return Execute<bool>(dal =>
            {
                SalesOrderHeaderSalesReason salesorderheadersalesreasonUpdate = dal.SalesOrderHeaderSalesReason.Where(x => x.SalesOrderID == salesorderheadersalesreason.SalesOrderID).FirstOrDefault();
                if (salesorderheadersalesreasonUpdate != null)
                {
                    salesorderheadersalesreasonUpdate.SalesOrderID = salesorderheadersalesreason.SalesOrderID;
                    salesorderheadersalesreasonUpdate.SalesReasonID = salesorderheadersalesreason.SalesReasonID;
                    salesorderheadersalesreasonUpdate.ModifiedDate = salesorderheadersalesreason.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesOrderHeaderSalesReasonAdd(SalesOrderHeaderSalesReason salesorderheadersalesreason)
        {
            return Execute<bool>(dal =>
            {
                SalesOrderHeaderSalesReason salesorderheadersalesreasonAdd = dal.SalesOrderHeaderSalesReason.Where(x => x.SalesOrderID == salesorderheadersalesreason.SalesOrderID).FirstOrDefault();
                if (salesorderheadersalesreasonAdd != null)
                {
                    dal.SalesOrderHeaderSalesReason.InsertOnSubmit(salesorderheadersalesreasonAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesOrderHeaderSalesReasonDelete(SalesOrderHeaderSalesReason salesorderheadersalesreason)
        {
            return Execute<bool>(dal =>
            {
                SalesOrderHeaderSalesReason salesorderheadersalesreasonDelete = dal.SalesOrderHeaderSalesReason.Where(x => x.SalesOrderID == salesorderheadersalesreason.SalesOrderID).FirstOrDefault();
                if (salesorderheadersalesreasonDelete != null)
                {
                    dal.SalesOrderHeaderSalesReason.DeleteOnSubmit(salesorderheadersalesreasonDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

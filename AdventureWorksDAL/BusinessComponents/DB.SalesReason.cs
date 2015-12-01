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

        public List<SalesReason> SalesReasonList()
        {
            var getSalesReason = Execute<List<SalesReason>>(dal =>
            {
                var item = dal.SalesReason.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesReason;
        }

        public List<SalesReason> SalesReasonListAll()
        {
            var getSalesReason = Execute<List<SalesReason>>(dal =>
            {
                var item = dal.SalesReason;
                return item.ToList();
            });
            return getSalesReason;
        }

        public bool SalesReasonUpdate(SalesReason salesreason)
        {
             return Execute<bool>(dal =>
            {
                SalesReason salesreasonUpdate = dal.SalesReason.Where(x => x.SalesReasonID == salesreason.SalesReasonID).FirstOrDefault();
                if (salesreasonUpdate != null)
                {
                    salesreasonUpdate.SalesReasonID = salesreason.SalesReasonID;
                    salesreasonUpdate.Name = salesreason.Name;
                    salesreasonUpdate.ReasonType = salesreason.ReasonType;
                    salesreasonUpdate.ModifiedDate = salesreason.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesReasonAdd(SalesReason salesreason)
        {
            return Execute<bool>(dal =>
            {
                SalesReason salesreasonAdd = dal.SalesReason.Where(x => x.SalesReasonID == salesreason.SalesReasonID).FirstOrDefault();
                if (salesreasonAdd != null)
                {
                    dal.SalesReason.InsertOnSubmit(salesreasonAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesReasonDelete(SalesReason salesreason)
        {
            return Execute<bool>(dal =>
            {
                SalesReason salesreasonDelete = dal.SalesReason.Where(x => x.SalesReasonID == salesreason.SalesReasonID).FirstOrDefault();
                if (salesreasonDelete != null)
                {
                    dal.SalesReason.DeleteOnSubmit(salesreasonDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

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

        public List<SalesPersonQuotaHistory> SalesPersonQuotaHistoryList()
        {
            var getSalesPersonQuotaHistory = Execute<List<SalesPersonQuotaHistory>>(dal =>
            {
                var item = dal.SalesPersonQuotaHistory.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesPersonQuotaHistory;
        }

        public List<SalesPersonQuotaHistory> SalesPersonQuotaHistoryListAll()
        {
            var getSalesPersonQuotaHistory = Execute<List<SalesPersonQuotaHistory>>(dal =>
            {
                var item = dal.SalesPersonQuotaHistory;
                return item.ToList();
            });
            return getSalesPersonQuotaHistory;
        }

        public bool SalesPersonQuotaHistoryUpdate(SalesPersonQuotaHistory salespersonquotahistory)
        {
             return Execute<bool>(dal =>
            {
                SalesPersonQuotaHistory salespersonquotahistoryUpdate = dal.SalesPersonQuotaHistory.Where(x => x.BusinessEntityID == salespersonquotahistory.BusinessEntityID).FirstOrDefault();
                if (salespersonquotahistoryUpdate != null)
                {
                    salespersonquotahistoryUpdate.BusinessEntityID = salespersonquotahistory.BusinessEntityID;
                    salespersonquotahistoryUpdate.QuotaDate = salespersonquotahistory.QuotaDate;
                    salespersonquotahistoryUpdate.SalesQuota = salespersonquotahistory.SalesQuota;
                    salespersonquotahistoryUpdate.rowguid = salespersonquotahistory.rowguid;
                    salespersonquotahistoryUpdate.ModifiedDate = salespersonquotahistory.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesPersonQuotaHistoryAdd(SalesPersonQuotaHistory salespersonquotahistory)
        {
            return Execute<bool>(dal =>
            {
                SalesPersonQuotaHistory salespersonquotahistoryAdd = dal.SalesPersonQuotaHistory.Where(x => x.BusinessEntityID == salespersonquotahistory.BusinessEntityID).FirstOrDefault();
                if (salespersonquotahistoryAdd != null)
                {
                    dal.SalesPersonQuotaHistory.InsertOnSubmit(salespersonquotahistoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesPersonQuotaHistoryDelete(SalesPersonQuotaHistory salespersonquotahistory)
        {
            return Execute<bool>(dal =>
            {
                SalesPersonQuotaHistory salespersonquotahistoryDelete = dal.SalesPersonQuotaHistory.Where(x => x.BusinessEntityID == salespersonquotahistory.BusinessEntityID).FirstOrDefault();
                if (salespersonquotahistoryDelete != null)
                {
                    dal.SalesPersonQuotaHistory.DeleteOnSubmit(salespersonquotahistoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

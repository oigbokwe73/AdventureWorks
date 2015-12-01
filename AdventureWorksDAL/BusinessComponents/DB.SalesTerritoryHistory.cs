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

        public List<SalesTerritoryHistory> SalesTerritoryHistoryList()
        {
            var getSalesTerritoryHistory = Execute<List<SalesTerritoryHistory>>(dal =>
            {
                var item = dal.SalesTerritoryHistory.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesTerritoryHistory;
        }

        public List<SalesTerritoryHistory> SalesTerritoryHistoryListAll()
        {
            var getSalesTerritoryHistory = Execute<List<SalesTerritoryHistory>>(dal =>
            {
                var item = dal.SalesTerritoryHistory;
                return item.ToList();
            });
            return getSalesTerritoryHistory;
        }

        public bool SalesTerritoryHistoryUpdate(SalesTerritoryHistory salesterritoryhistory)
        {
            return Execute<bool>(dal =>
            {
                SalesTerritoryHistory salesterritoryhistoryUpdate = dal.SalesTerritoryHistory.Where(x => x.BusinessEntityID == salesterritoryhistory.BusinessEntityID).FirstOrDefault();
                if (salesterritoryhistoryUpdate != null)
                {
                    salesterritoryhistoryUpdate.BusinessEntityID = salesterritoryhistory.BusinessEntityID;
                    salesterritoryhistoryUpdate.TerritoryID = salesterritoryhistory.TerritoryID;
                    salesterritoryhistoryUpdate.StartDate = salesterritoryhistory.StartDate;
                    salesterritoryhistoryUpdate.EndDate = salesterritoryhistory.EndDate;
                    salesterritoryhistoryUpdate.rowguid = salesterritoryhistory.rowguid;
                    salesterritoryhistoryUpdate.ModifiedDate = salesterritoryhistory.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesTerritoryHistoryAdd(SalesTerritoryHistory salesterritoryhistory)
        {
            return Execute<bool>(dal =>
            {
                SalesTerritoryHistory salesterritoryhistoryAdd = dal.SalesTerritoryHistory.Where(x => x.BusinessEntityID == salesterritoryhistory.BusinessEntityID).FirstOrDefault();
                if (salesterritoryhistoryAdd != null)
                {
                    dal.SalesTerritoryHistory.InsertOnSubmit(salesterritoryhistoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesTerritoryHistoryDelete(SalesTerritoryHistory salesterritoryhistory)
        {
            return Execute<bool>(dal =>
            {
                SalesTerritoryHistory salesterritoryhistoryDelete = dal.SalesTerritoryHistory.Where(x => x.BusinessEntityID == salesterritoryhistory.BusinessEntityID).FirstOrDefault();
                if (salesterritoryhistoryDelete != null)
                {
                    dal.SalesTerritoryHistory.DeleteOnSubmit(salesterritoryhistoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

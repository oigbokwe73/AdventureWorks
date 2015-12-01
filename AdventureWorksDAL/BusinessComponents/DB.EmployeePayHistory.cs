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

        public List<EmployeePayHistory> EmployeePayHistoryList()
        {
            var getEmployeePayHistory = Execute<List<EmployeePayHistory>>(dal =>
            {
                var item = dal.EmployeePayHistory.Skip(0).Take(100);
                return item.ToList();
            });
            return getEmployeePayHistory;
        }

        public List<EmployeePayHistory> EmployeePayHistoryListAll()
        {
            var getEmployeePayHistory = Execute<List<EmployeePayHistory>>(dal =>
            {
                var item = dal.EmployeePayHistory;
                return item.ToList();
            });
            return getEmployeePayHistory;
        }

        public bool EmployeePayHistoryUpdate(EmployeePayHistory employeepayhistory)
        {
            return Execute<bool>(dal =>
           {
               EmployeePayHistory employeepayhistoryUpdate = dal.EmployeePayHistory.Where(x => x.BusinessEntityID == employeepayhistory.BusinessEntityID).FirstOrDefault();
               if (employeepayhistoryUpdate != null)
               {
                   employeepayhistoryUpdate.BusinessEntityID = employeepayhistory.BusinessEntityID;
                   employeepayhistoryUpdate.RateChangeDate = employeepayhistory.RateChangeDate;
                   employeepayhistoryUpdate.Rate = employeepayhistory.Rate;
                   employeepayhistoryUpdate.PayFrequency = employeepayhistory.PayFrequency;
                   employeepayhistoryUpdate.ModifiedDate = employeepayhistory.ModifiedDate;
                   dal.SubmitChanges();
                   return true;
               }
               return false;
           });
        }
        public bool EmployeePayHistoryAdd(EmployeePayHistory employeepayhistory)
        {
            return Execute<bool>(dal =>
            {
                EmployeePayHistory employeepayhistoryAdd = dal.EmployeePayHistory.Where(x => x.BusinessEntityID == employeepayhistory.BusinessEntityID).FirstOrDefault();
                if (employeepayhistoryAdd != null)
                {
                    dal.EmployeePayHistory.InsertOnSubmit(employeepayhistoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool EmployeePayHistoryDelete(EmployeePayHistory employeepayhistory)
        {
            return Execute<bool>(dal =>
            {
                EmployeePayHistory employeepayhistoryDelete = dal.EmployeePayHistory.Where(x => x.BusinessEntityID == employeepayhistory.BusinessEntityID).FirstOrDefault();
                if (employeepayhistoryDelete != null)
                {
                    dal.EmployeePayHistory.DeleteOnSubmit(employeepayhistoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

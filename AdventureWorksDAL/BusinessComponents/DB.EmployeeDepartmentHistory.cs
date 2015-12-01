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

        public List<EmployeeDepartmentHistory> EmployeeDepartmentHistoryList()
        {
            var getEmployeeDepartmentHistory = Execute<List<EmployeeDepartmentHistory>>(dal =>
            {
                var item = dal.EmployeeDepartmentHistory.Skip(0).Take(100);
                return item.ToList();
            });
            return getEmployeeDepartmentHistory;
        }

        public List<EmployeeDepartmentHistory> EmployeeDepartmentHistoryListAll()
        {
            var getEmployeeDepartmentHistory = Execute<List<EmployeeDepartmentHistory>>(dal =>
            {
                var item = dal.EmployeeDepartmentHistory;
                return item.ToList();
            });
            return getEmployeeDepartmentHistory;
        }

        public bool EmployeeDepartmentHistoryUpdate(EmployeeDepartmentHistory employeedepartmenthistory)
        {
            return Execute<bool>(dal =>
           {
               EmployeeDepartmentHistory employeedepartmenthistoryUpdate = dal.EmployeeDepartmentHistory.Where(x => x.BusinessEntityID == employeedepartmenthistory.BusinessEntityID).FirstOrDefault();
               if (employeedepartmenthistoryUpdate != null)
               {
                   employeedepartmenthistoryUpdate.BusinessEntityID = employeedepartmenthistory.BusinessEntityID;
                   employeedepartmenthistoryUpdate.DepartmentID = employeedepartmenthistory.DepartmentID;
                   employeedepartmenthistoryUpdate.ShiftID = employeedepartmenthistory.ShiftID;
                   employeedepartmenthistoryUpdate.StartDate = employeedepartmenthistory.StartDate;
                   employeedepartmenthistoryUpdate.EndDate = employeedepartmenthistory.EndDate;
                   employeedepartmenthistoryUpdate.ModifiedDate = employeedepartmenthistory.ModifiedDate;
                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool EmployeeDepartmentHistoryAdd(EmployeeDepartmentHistory employeedepartmenthistory)
        {
            return Execute<bool>(dal =>
            {
                EmployeeDepartmentHistory employeedepartmenthistoryAdd = dal.EmployeeDepartmentHistory.Where(x => x.BusinessEntityID == employeedepartmenthistory.BusinessEntityID).FirstOrDefault();
                if (employeedepartmenthistoryAdd != null)
                {
                    dal.EmployeeDepartmentHistory.InsertOnSubmit(employeedepartmenthistoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool EmployeeDepartmentHistoryDelete(EmployeeDepartmentHistory employeedepartmenthistory)
        {
            return Execute<bool>(dal =>
            {
                EmployeeDepartmentHistory employeedepartmenthistoryDelete = dal.EmployeeDepartmentHistory.Where(x => x.BusinessEntityID == employeedepartmenthistory.BusinessEntityID).FirstOrDefault();
                if (employeedepartmenthistoryDelete != null)
                {
                    dal.EmployeeDepartmentHistory.DeleteOnSubmit(employeedepartmenthistoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

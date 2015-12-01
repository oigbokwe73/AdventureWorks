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

        public List<ErrorLog> ErrorLogList()
        {
            var getErrorLog = Execute<List<ErrorLog>>(dal =>
            {
                var item = dal.ErrorLog.Skip(0).Take(100);
                return item.ToList();
            });
            return getErrorLog;
        }

        public List<ErrorLog> ErrorLogListAll()
        {
            var getErrorLog = Execute<List<ErrorLog>>(dal =>
            {
                var item = dal.ErrorLog;
                return item.ToList();
            });
            return getErrorLog;
        }

        public bool ErrorLogUpdate(ErrorLog errorlog)
        {
            return Execute<bool>(dal =>
           {
               ErrorLog errorlogUpdate = dal.ErrorLog.Where(x => x.ErrorLogID == errorlog.ErrorLogID).FirstOrDefault();
               if (errorlogUpdate != null)
               {
                   errorlogUpdate.ErrorLogID = errorlog.ErrorLogID;
                   errorlogUpdate.ErrorTime = errorlog.ErrorTime;
                   errorlogUpdate.UserName = errorlog.UserName;
                   errorlogUpdate.ErrorNumber = errorlog.ErrorNumber;
                   errorlogUpdate.ErrorSeverity = errorlog.ErrorSeverity;
                   errorlogUpdate.ErrorState = errorlog.ErrorState;
                   errorlogUpdate.ErrorProcedure = errorlog.ErrorProcedure;
                   errorlogUpdate.ErrorLine = errorlog.ErrorLine;
                   errorlogUpdate.ErrorMessage = errorlog.ErrorMessage;
                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool ErrorLogAdd(ErrorLog errorlog)
        {
            return Execute<bool>(dal =>
            {
                ErrorLog errorlogAdd = dal.ErrorLog.Where(x => x.ErrorLogID == errorlog.ErrorLogID).FirstOrDefault();
                if (errorlogAdd != null)
                {
                    dal.ErrorLog.InsertOnSubmit(errorlogAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ErrorLogDelete(ErrorLog errorlog)
        {
            return Execute<bool>(dal =>
            {
                ErrorLog errorlogDelete = dal.ErrorLog.Where(x => x.ErrorLogID == errorlog.ErrorLogID).FirstOrDefault();
                if (errorlogDelete != null)
                {
                    dal.ErrorLog.DeleteOnSubmit(errorlogDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

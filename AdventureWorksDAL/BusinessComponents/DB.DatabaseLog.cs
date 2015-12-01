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

        public List<DatabaseLog> DatabaseLogList()
        {
            var getDatabaseLog = Execute<List<DatabaseLog>>(dal =>
            {
                var item = dal.DatabaseLog.Skip(0).Take(100);
                return item.ToList();
            });
            return getDatabaseLog;
        }

        public List<DatabaseLog> DatabaseLogListAll()
        {
            var getDatabaseLog = Execute<List<DatabaseLog>>(dal =>
            {
                var item = dal.DatabaseLog;
                return item.ToList();
            });
            return getDatabaseLog;
        }

        public bool DatabaseLogUpdate(DatabaseLog databaselog)
        {
            return Execute<bool>(dal =>
            {
                DatabaseLog databaselogUpdate = dal.DatabaseLog.Where(x => x.DatabaseLogID == databaselog.DatabaseLogID).FirstOrDefault();
                if (databaselogUpdate != null)
                {
                    databaselogUpdate.DatabaseLogID = databaselog.DatabaseLogID;
                    databaselogUpdate.PostTime = databaselog.PostTime;
                    databaselogUpdate.DatabaseUser = databaselog.DatabaseUser;
                    databaselogUpdate.Event = databaselog.Event;
                    databaselogUpdate.Schema = databaselog.Schema;
                    databaselogUpdate.Object = databaselog.Object;
                    databaselogUpdate.TSQL = databaselog.TSQL;
                    databaselogUpdate.XmlEvent = databaselog.XmlEvent;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool DatabaseLogAdd(DatabaseLog databaselog)
        {
            return Execute<bool>(dal =>
            {
                DatabaseLog databaselogAdd = dal.DatabaseLog.Where(x => x.DatabaseLogID == databaselog.DatabaseLogID).FirstOrDefault();
                if (databaselogAdd != null)
                {
                    dal.DatabaseLog.InsertOnSubmit(databaselogAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool DatabaseLogDelete(DatabaseLog databaselog)
        {
            return Execute<bool>(dal =>
            {
                DatabaseLog databaselogDelete = dal.DatabaseLog.Where(x => x.DatabaseLogID == databaselog.DatabaseLogID).FirstOrDefault();
                if (databaselogDelete != null)
                {
                    dal.DatabaseLog.DeleteOnSubmit(databaselogDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

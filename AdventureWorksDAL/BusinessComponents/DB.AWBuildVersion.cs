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

        public List<AWBuildVersion> AWBuildVersionList()
        {
            var getAWBuildVersion = Execute<List<AWBuildVersion>>(dal =>
            {
                var item = dal.AWBuildVersion.Skip(0).Take(100);
                return item.ToList();
            });
            return getAWBuildVersion;
        }

        public List<AWBuildVersion> AWBuildVersionListAll()
        {
            var getAWBuildVersion = Execute<List<AWBuildVersion>>(dal =>
            {
                var item = dal.AWBuildVersion;
                return item.ToList();
            });
            return getAWBuildVersion;
        }

        public bool AWBuildVersionUpdate(AWBuildVersion awbuildversion)
        {
            return Execute<bool>(dal =>
           {
               AWBuildVersion awbuildversionUpdate = dal.AWBuildVersion.Where(x => x.SystemInformationID == awbuildversion.SystemInformationID).FirstOrDefault();
               if (awbuildversionUpdate != null)
               {
                   awbuildversionUpdate.SystemInformationID = awbuildversion.SystemInformationID;
                   awbuildversionUpdate.Database_Version = awbuildversion.Database_Version;
                   awbuildversionUpdate.VersionDate = awbuildversion.VersionDate;
                   awbuildversionUpdate.ModifiedDate = awbuildversion.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool AWBuildVersionAdd(AWBuildVersion awbuildversion)
        {
            return Execute<bool>(dal =>
            {
                AWBuildVersion awbuildversionAdd = dal.AWBuildVersion.Where(x => x.SystemInformationID == awbuildversion.SystemInformationID).FirstOrDefault();
                if (awbuildversionAdd != null)
                {
                    dal.AWBuildVersion.InsertOnSubmit(awbuildversionAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool AWBuildVersionDelete(AWBuildVersion awbuildversion)
        {
            return Execute<bool>(dal =>
            {
                AWBuildVersion awbuildversionDelete = dal.AWBuildVersion.Where(x => x.SystemInformationID == awbuildversion.SystemInformationID).FirstOrDefault();
                if (awbuildversionDelete != null)
                {
                    dal.AWBuildVersion.DeleteOnSubmit(awbuildversionDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

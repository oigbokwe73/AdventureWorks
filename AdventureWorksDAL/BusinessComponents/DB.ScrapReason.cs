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

        public List<ScrapReason> ScrapReasonList()
        {
            var getScrapReason = Execute<List<ScrapReason>>(dal =>
            {
                var item = dal.ScrapReason.Skip(0).Take(100);
                return item.ToList();
            });
            return getScrapReason;
        }

        public List<ScrapReason> ScrapReasonListAll()
        {
            var getScrapReason = Execute<List<ScrapReason>>(dal =>
            {
                var item = dal.ScrapReason;
                return item.ToList();
            });
            return getScrapReason;
        }

        public bool ScrapReasonUpdate(ScrapReason scrapreason)
        {
            return Execute<bool>(dal =>
            {
                ScrapReason scrapreasonUpdate = dal.ScrapReason.Where(x => x.ScrapReasonID == scrapreason.ScrapReasonID).FirstOrDefault();
                if (scrapreasonUpdate != null)
                {
                    scrapreasonUpdate.ScrapReasonID = scrapreason.ScrapReasonID;
                    scrapreasonUpdate.Name = scrapreason.Name;
                    scrapreasonUpdate.ModifiedDate = scrapreason.ModifiedDate;
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ScrapReasonAdd(ScrapReason scrapreason)
        {
            return Execute<bool>(dal =>
            {
                ScrapReason scrapreasonAdd = dal.ScrapReason.Where(x => x.ScrapReasonID == scrapreason.ScrapReasonID).FirstOrDefault();
                if (scrapreasonAdd != null)
                {
                    dal.ScrapReason.InsertOnSubmit(scrapreasonAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ScrapReasonDelete(ScrapReason scrapreason)
        {
            return Execute<bool>(dal =>
            {
                ScrapReason scrapreasonDelete = dal.ScrapReason.Where(x => x.ScrapReasonID == scrapreason.ScrapReasonID).FirstOrDefault();
                if (scrapreasonDelete != null)
                {
                    dal.ScrapReason.DeleteOnSubmit(scrapreasonDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

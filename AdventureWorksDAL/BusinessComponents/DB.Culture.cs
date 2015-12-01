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

        public List<Culture> CultureList()
        {
            var getCulture = Execute<List<Culture>>(dal =>
            {
                var item = dal.Culture.Skip(0).Take(100);
                return item.ToList();
            });
            return getCulture;
        }

        public List<Culture> CultureListAll()
        {
            var getCulture = Execute<List<Culture>>(dal =>
            {
                var item = dal.Culture;
                return item.ToList();
            });
            return getCulture;
        }

        public bool CultureUpdate(Culture culture)
        {
            return Execute<bool>(dal =>
           {
               Culture cultureUpdate = dal.Culture.Where(x => x.CultureID == culture.CultureID).FirstOrDefault();
               if (cultureUpdate != null)
               {
                   cultureUpdate.CultureID = culture.CultureID;
                   cultureUpdate.Name = culture.Name;
                   cultureUpdate.ModifiedDate = culture.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool CultureAdd(Culture culture)
        {
            return Execute<bool>(dal =>
            {
                Culture cultureAdd = dal.Culture.Where(x => x.CultureID == culture.CultureID).FirstOrDefault();
                if (cultureAdd != null)
                {
                    dal.Culture.InsertOnSubmit(cultureAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CultureDelete(Culture culture)
        {
            return Execute<bool>(dal =>
            {
                Culture cultureDelete = dal.Culture.Where(x => x.CultureID == culture.CultureID).FirstOrDefault();
                if (cultureDelete != null)
                {
                    dal.Culture.DeleteOnSubmit(cultureDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

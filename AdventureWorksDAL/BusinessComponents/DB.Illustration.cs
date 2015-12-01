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

        public List<Illustration> IllustrationList()
        {
            var getIllustration = Execute<List<Illustration>>(dal =>
            {
                var item = dal.Illustration.Skip(0).Take(100);
                return item.ToList();
            });
            return getIllustration;
        }

        public List<Illustration> IllustrationListAll()
        {
            var getIllustration = Execute<List<Illustration>>(dal =>
            {
                var item = dal.Illustration;
                return item.ToList();
            });
            return getIllustration;
        }

        public bool IllustrationUpdate(Illustration illustration)
        {
            return Execute<bool>(dal =>
           {
               Illustration illustrationUpdate = dal.Illustration.Where(x => x.IllustrationID == illustration.IllustrationID).FirstOrDefault();
               if (illustrationUpdate != null)
               {
                   illustrationUpdate.IllustrationID = illustration.IllustrationID;
                   illustrationUpdate.Diagram = illustration.Diagram;
                   illustrationUpdate.ModifiedDate = illustration.ModifiedDate;
                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool IllustrationAdd(Illustration illustration)
        {
            return Execute<bool>(dal =>
            {
                Illustration illustrationAdd = dal.Illustration.Where(x => x.IllustrationID == illustration.IllustrationID).FirstOrDefault();
                if (illustrationAdd != null)
                {
                    dal.Illustration.InsertOnSubmit(illustrationAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool IllustrationDelete(Illustration illustration)
        {
            return Execute<bool>(dal =>
            {
                Illustration illustrationDelete = dal.Illustration.Where(x => x.IllustrationID == illustration.IllustrationID).FirstOrDefault();
                if (illustrationDelete != null)
                {
                    dal.Illustration.DeleteOnSubmit(illustrationDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

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

        public List<Illustration1> Illustration1List()
        {
            var getIllustration1 = Execute<List<Illustration1>>(dal =>
            {
                var item = dal.Illustration1.Skip(0).Take(100);
                return item.ToList();
            });
            return getIllustration1;
        }

        public List<Illustration1> Illustration1ListAll()
        {
            var getIllustration1 = Execute<List<Illustration1>>(dal =>
            {
                var item = dal.Illustration1;
                return item.ToList();
            });
            return getIllustration1;
        }

        public bool Illustration1Update(Illustration1 illustration1)
        {
             return Execute<bool>(dal =>
            {
                Illustration1 illustration1Update = dal.Illustration1.Where(x => x.IllustrationID == illustration1.IllustrationID).FirstOrDefault();
                if (illustration1Update != null)
                {
				    illustration1Update.IllustrationID=illustration1.IllustrationID;
illustration1Update.Diagram=illustration1.Diagram;
illustration1Update.ModifiedDate=illustration1.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool Illustration1Add(Illustration1 illustration1)
        {
            return Execute<bool>(dal =>
            {
                Illustration1 illustration1Add = dal.Illustration1.Where(x => x.IllustrationID == illustration1.IllustrationID).FirstOrDefault();
                if (illustration1Add != null)
                {
                    dal.Illustration1.InsertOnSubmit(illustration1Add);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool Illustration1Delete(Illustration1 illustration1)
        {
            return Execute<bool>(dal =>
            {
                Illustration1 illustration1Delete = dal.Illustration1.Where(x => x.IllustrationID == illustration1.IllustrationID).FirstOrDefault();
                if (illustration1Delete != null)
                {
                    dal.Illustration1.DeleteOnSubmit(illustration1Delete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

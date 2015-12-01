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

        public List<vProductAndDescription> vProductAndDescriptionList()
        {
            var getvProductAndDescription = Execute<List<vProductAndDescription>>(dal =>
            {
                var item = dal.vProductAndDescription.Skip(0).Take(100);
                return item.ToList();
            });
            return getvProductAndDescription;
        }

        public List<vProductAndDescription> vProductAndDescriptionListAll()
        {
            var getvProductAndDescription = Execute<List<vProductAndDescription>>(dal =>
            {
                var item = dal.vProductAndDescription;
                return item.ToList();
            });
            return getvProductAndDescription;
        }

        public bool vProductAndDescriptionUpdate(vProductAndDescription vproductanddescription)
        {
            return Execute<bool>(dal =>
           {
               vProductAndDescription vproductanddescriptionUpdate = dal.vProductAndDescription.Where(x => x.ProductID == vproductanddescription.ProductID).FirstOrDefault();
               if (vproductanddescriptionUpdate != null)
               {
                   vproductanddescriptionUpdate.ProductID = vproductanddescription.ProductID;
                   vproductanddescriptionUpdate.Name = vproductanddescription.Name;
                   vproductanddescriptionUpdate.ProductModel = vproductanddescription.ProductModel;
                   vproductanddescriptionUpdate.CultureID = vproductanddescription.CultureID;
                   vproductanddescriptionUpdate.Description = vproductanddescription.Description;
                   vproductanddescriptionUpdate.ThumbNailPhoto = vproductanddescription.ThumbNailPhoto;
                   vproductanddescriptionUpdate.ThumbnailPhotoFileName = vproductanddescription.ThumbnailPhotoFileName;
                   vproductanddescriptionUpdate.LargePhoto = vproductanddescription.LargePhoto;
                   vproductanddescriptionUpdate.LargePhotoFileName = vproductanddescription.LargePhotoFileName;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool vProductAndDescriptionAdd(vProductAndDescription vproductanddescription)
        {
            return Execute<bool>(dal =>
            {
                vProductAndDescription vproductanddescriptionAdd = dal.vProductAndDescription.Where(x => x.ProductID == vproductanddescription.ProductID).FirstOrDefault();
                if (vproductanddescriptionAdd != null)
                {
                    dal.vProductAndDescription.InsertOnSubmit(vproductanddescriptionAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool vProductAndDescriptionDelete(vProductAndDescription vproductanddescription)
        {
            return Execute<bool>(dal =>
            {
                vProductAndDescription vproductanddescriptionDelete = dal.vProductAndDescription.Where(x => x.ProductID == vproductanddescription.ProductID).FirstOrDefault();
                if (vproductanddescriptionDelete != null)
                {
                    dal.vProductAndDescription.DeleteOnSubmit(vproductanddescriptionDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

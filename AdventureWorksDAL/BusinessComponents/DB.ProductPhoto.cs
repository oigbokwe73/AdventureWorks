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

        public List<ProductPhoto> ProductPhotoList()
        {
            var getProductPhoto = Execute<List<ProductPhoto>>(dal =>
            {
                var item = dal.ProductPhoto.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductPhoto;
        }

        public List<ProductPhoto> ProductPhotoListAll()
        {
            var getProductPhoto = Execute<List<ProductPhoto>>(dal =>
            {
                var item = dal.ProductPhoto;
                return item.ToList();
            });
            return getProductPhoto;
        }

        public bool ProductPhotoUpdate(ProductPhoto productphoto)
        {
            return Execute<bool>(dal =>
            {
                ProductPhoto productphotoUpdate = dal.ProductPhoto.Where(x => x.ProductPhotoID == productphoto.ProductPhotoID).FirstOrDefault();
                if (productphotoUpdate != null)
                {
                    productphotoUpdate.ProductPhotoID = productphoto.ProductPhotoID;
                    productphotoUpdate.ThumbNailPhoto = productphoto.ThumbNailPhoto;
                    productphotoUpdate.ThumbnailPhotoFileName = productphoto.ThumbnailPhotoFileName;
                    productphotoUpdate.LargePhoto = productphoto.LargePhoto;
                    productphotoUpdate.LargePhotoFileName = productphoto.LargePhotoFileName;
                    productphotoUpdate.ModifiedDate = productphoto.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductPhotoAdd(ProductPhoto productphoto)
        {
            return Execute<bool>(dal =>
            {
                ProductPhoto productphotoAdd = dal.ProductPhoto.Where(x => x.ProductPhotoID == productphoto.ProductPhotoID).FirstOrDefault();
                if (productphotoAdd != null)
                {
                    dal.ProductPhoto.InsertOnSubmit(productphotoAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductPhotoDelete(ProductPhoto productphoto)
        {
            return Execute<bool>(dal =>
            {
                ProductPhoto productphotoDelete = dal.ProductPhoto.Where(x => x.ProductPhotoID == productphoto.ProductPhotoID).FirstOrDefault();
                if (productphotoDelete != null)
                {
                    dal.ProductPhoto.DeleteOnSubmit(productphotoDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

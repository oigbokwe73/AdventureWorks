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

        public List<ProductProductPhoto> ProductProductPhotoList()
        {
            var getProductProductPhoto = Execute<List<ProductProductPhoto>>(dal =>
            {
                var item = dal.ProductProductPhoto.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductProductPhoto;
        }

        public List<ProductProductPhoto> ProductProductPhotoListAll()
        {
            var getProductProductPhoto = Execute<List<ProductProductPhoto>>(dal =>
            {
                var item = dal.ProductProductPhoto;
                return item.ToList();
            });
            return getProductProductPhoto;
        }

        public bool ProductProductPhotoUpdate(ProductProductPhoto productproductphoto)
        {
            return Execute<bool>(dal =>
            {
                ProductProductPhoto productproductphotoUpdate = dal.ProductProductPhoto.Where(x => x.ProductID == productproductphoto.ProductID).FirstOrDefault();
                if (productproductphotoUpdate != null)
                {
                    productproductphotoUpdate.ProductID = productproductphoto.ProductID;
                    productproductphotoUpdate.ProductPhotoID = productproductphoto.ProductPhotoID;
                    productproductphotoUpdate.Primary = productproductphoto.Primary;
                    productproductphotoUpdate.ModifiedDate = productproductphoto.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductProductPhotoAdd(ProductProductPhoto productproductphoto)
        {
            return Execute<bool>(dal =>
            {
                ProductProductPhoto productproductphotoAdd = dal.ProductProductPhoto.Where(x => x.ProductID == productproductphoto.ProductID).FirstOrDefault();
                if (productproductphotoAdd != null)
                {
                    dal.ProductProductPhoto.InsertOnSubmit(productproductphotoAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductProductPhotoDelete(ProductProductPhoto productproductphoto)
        {
            return Execute<bool>(dal =>
            {
                ProductProductPhoto productproductphotoDelete = dal.ProductProductPhoto.Where(x => x.ProductID == productproductphoto.ProductID).FirstOrDefault();
                if (productproductphotoDelete != null)
                {
                    dal.ProductProductPhoto.DeleteOnSubmit(productproductphotoDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

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

        public List<ProductDescription> ProductDescriptionList()
        {
            var getProductDescription = Execute<List<ProductDescription>>(dal =>
            {
                var item = dal.ProductDescription.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductDescription;
        }

        public List<ProductDescription> ProductDescriptionListAll()
        {
            var getProductDescription = Execute<List<ProductDescription>>(dal =>
            {
                var item = dal.ProductDescription;
                return item.ToList();
            });
            return getProductDescription;
        }

        public bool ProductDescriptionUpdate(ProductDescription productdescription)
        {
             return Execute<bool>(dal =>
            {
                ProductDescription productdescriptionUpdate = dal.ProductDescription.Where(x => x.ProductDescriptionID == productdescription.ProductDescriptionID).FirstOrDefault();
                if (productdescriptionUpdate != null)
                {
				    productdescriptionUpdate.ProductDescriptionID=productdescription.ProductDescriptionID;
productdescriptionUpdate.Description=productdescription.Description;
productdescriptionUpdate.rowguid=productdescription.rowguid;
productdescriptionUpdate.ModifiedDate=productdescription.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool ProductDescriptionAdd(ProductDescription productdescription)
        {
            return Execute<bool>(dal =>
            {
                ProductDescription productdescriptionAdd = dal.ProductDescription.Where(x => x.ProductDescriptionID == productdescription.ProductDescriptionID).FirstOrDefault();
                if (productdescriptionAdd != null)
                {
                    dal.ProductDescription.InsertOnSubmit(productdescriptionAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductDescriptionDelete(ProductDescription productdescription)
        {
            return Execute<bool>(dal =>
            {
                ProductDescription productdescriptionDelete = dal.ProductDescription.Where(x => x.ProductDescriptionID == productdescription.ProductDescriptionID).FirstOrDefault();
                if (productdescriptionDelete != null)
                {
                    dal.ProductDescription.DeleteOnSubmit(productdescriptionDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

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

        public List<ProductModelIllustration> ProductModelIllustrationList()
        {
            var getProductModelIllustration = Execute<List<ProductModelIllustration>>(dal =>
            {
                var item = dal.ProductModelIllustration.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductModelIllustration;
        }

        public List<ProductModelIllustration> ProductModelIllustrationListAll()
        {
            var getProductModelIllustration = Execute<List<ProductModelIllustration>>(dal =>
            {
                var item = dal.ProductModelIllustration;
                return item.ToList();
            });
            return getProductModelIllustration;
        }

        public bool ProductModelIllustrationUpdate(ProductModelIllustration productmodelillustration)
        {
             return Execute<bool>(dal =>
            {
                ProductModelIllustration productmodelillustrationUpdate = dal.ProductModelIllustration.Where(x => x.ProductModelID == productmodelillustration.ProductModelID).FirstOrDefault();
                if (productmodelillustrationUpdate != null)
                {
				    productmodelillustrationUpdate.ProductModelID=productmodelillustration.ProductModelID;
productmodelillustrationUpdate.IllustrationID=productmodelillustration.IllustrationID;
productmodelillustrationUpdate.ModifiedDate=productmodelillustration.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool ProductModelIllustrationAdd(ProductModelIllustration productmodelillustration)
        {
            return Execute<bool>(dal =>
            {
                ProductModelIllustration productmodelillustrationAdd = dal.ProductModelIllustration.Where(x => x.ProductModelID == productmodelillustration.ProductModelID).FirstOrDefault();
                if (productmodelillustrationAdd != null)
                {
                    dal.ProductModelIllustration.InsertOnSubmit(productmodelillustrationAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductModelIllustrationDelete(ProductModelIllustration productmodelillustration)
        {
            return Execute<bool>(dal =>
            {
                ProductModelIllustration productmodelillustrationDelete = dal.ProductModelIllustration.Where(x => x.ProductModelID == productmodelillustration.ProductModelID).FirstOrDefault();
                if (productmodelillustrationDelete != null)
                {
                    dal.ProductModelIllustration.DeleteOnSubmit(productmodelillustrationDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

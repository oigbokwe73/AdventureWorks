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

        public List<ProductCategory> ProductCategoryList()
        {
            var getProductCategory = Execute<List<ProductCategory>>(dal =>
            {
                var item = dal.ProductCategory.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductCategory;
        }

        public List<ProductCategory> ProductCategoryListAll()
        {
            var getProductCategory = Execute<List<ProductCategory>>(dal =>
            {
                var item = dal.ProductCategory;
                return item.ToList();
            });
            return getProductCategory;
        }

        public bool ProductCategoryUpdate(ProductCategory productcategory)
        {
             return Execute<bool>(dal =>
            {
                ProductCategory productcategoryUpdate = dal.ProductCategory.Where(x => x.ProductCategoryID == productcategory.ProductCategoryID).FirstOrDefault();
                if (productcategoryUpdate != null)
                {
				    productcategoryUpdate.ProductCategoryID=productcategory.ProductCategoryID;
productcategoryUpdate.Name=productcategory.Name;
productcategoryUpdate.rowguid=productcategory.rowguid;
productcategoryUpdate.ModifiedDate=productcategory.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool ProductCategoryAdd(ProductCategory productcategory)
        {
            return Execute<bool>(dal =>
            {
                ProductCategory productcategoryAdd = dal.ProductCategory.Where(x => x.ProductCategoryID == productcategory.ProductCategoryID).FirstOrDefault();
                if (productcategoryAdd != null)
                {
                    dal.ProductCategory.InsertOnSubmit(productcategoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductCategoryDelete(ProductCategory productcategory)
        {
            return Execute<bool>(dal =>
            {
                ProductCategory productcategoryDelete = dal.ProductCategory.Where(x => x.ProductCategoryID == productcategory.ProductCategoryID).FirstOrDefault();
                if (productcategoryDelete != null)
                {
                    dal.ProductCategory.DeleteOnSubmit(productcategoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

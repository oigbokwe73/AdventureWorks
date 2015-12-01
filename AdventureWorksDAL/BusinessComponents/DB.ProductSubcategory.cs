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

        public List<ProductSubcategory> ProductSubcategoryList()
        {
            var getProductSubcategory = Execute<List<ProductSubcategory>>(dal =>
            {
                var item = dal.ProductSubcategory.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductSubcategory;
        }

        public List<ProductSubcategory> ProductSubcategoryListAll()
        {
            var getProductSubcategory = Execute<List<ProductSubcategory>>(dal =>
            {
                var item = dal.ProductSubcategory;
                return item.ToList();
            });
            return getProductSubcategory;
        }

        public bool ProductSubcategoryUpdate(ProductSubcategory productsubcategory)
        {
            return Execute<bool>(dal =>
            {
                ProductSubcategory productsubcategoryUpdate = dal.ProductSubcategory.Where(x => x.ProductSubcategoryID == productsubcategory.ProductSubcategoryID).FirstOrDefault();
                if (productsubcategoryUpdate != null)
                {
                    productsubcategoryUpdate.ProductSubcategoryID = productsubcategory.ProductSubcategoryID;
                    productsubcategoryUpdate.ProductCategoryID = productsubcategory.ProductCategoryID;
                    productsubcategoryUpdate.Name = productsubcategory.Name;
                    productsubcategoryUpdate.rowguid = productsubcategory.rowguid;
                    productsubcategoryUpdate.ModifiedDate = productsubcategory.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductSubcategoryAdd(ProductSubcategory productsubcategory)
        {
            return Execute<bool>(dal =>
            {
                ProductSubcategory productsubcategoryAdd = dal.ProductSubcategory.Where(x => x.ProductSubcategoryID == productsubcategory.ProductSubcategoryID).FirstOrDefault();
                if (productsubcategoryAdd != null)
                {
                    dal.ProductSubcategory.InsertOnSubmit(productsubcategoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductSubcategoryDelete(ProductSubcategory productsubcategory)
        {
            return Execute<bool>(dal =>
            {
                ProductSubcategory productsubcategoryDelete = dal.ProductSubcategory.Where(x => x.ProductSubcategoryID == productsubcategory.ProductSubcategoryID).FirstOrDefault();
                if (productsubcategoryDelete != null)
                {
                    dal.ProductSubcategory.DeleteOnSubmit(productsubcategoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

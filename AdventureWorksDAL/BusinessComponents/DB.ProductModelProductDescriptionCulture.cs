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

        public List<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultureList()
        {
            var getProductModelProductDescriptionCulture = Execute<List<ProductModelProductDescriptionCulture>>(dal =>
            {
                var item = dal.ProductModelProductDescriptionCulture.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductModelProductDescriptionCulture;
        }

        public List<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultureListAll()
        {
            var getProductModelProductDescriptionCulture = Execute<List<ProductModelProductDescriptionCulture>>(dal =>
            {
                var item = dal.ProductModelProductDescriptionCulture;
                return item.ToList();
            });
            return getProductModelProductDescriptionCulture;
        }

        public bool ProductModelProductDescriptionCultureUpdate(ProductModelProductDescriptionCulture productmodelproductdescriptionculture)
        {
            return Execute<bool>(dal =>
            {
                ProductModelProductDescriptionCulture productmodelproductdescriptioncultureUpdate = dal.ProductModelProductDescriptionCulture.Where(x => x.ProductModelID == productmodelproductdescriptionculture.ProductModelID).FirstOrDefault();
                if (productmodelproductdescriptioncultureUpdate != null)
                {
                    productmodelproductdescriptioncultureUpdate.ProductModelID = productmodelproductdescriptionculture.ProductModelID;
                    productmodelproductdescriptioncultureUpdate.ProductDescriptionID = productmodelproductdescriptionculture.ProductDescriptionID;
                    productmodelproductdescriptioncultureUpdate.CultureID = productmodelproductdescriptionculture.CultureID;
                    productmodelproductdescriptioncultureUpdate.ModifiedDate = productmodelproductdescriptionculture.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductModelProductDescriptionCultureAdd(ProductModelProductDescriptionCulture productmodelproductdescriptionculture)
        {
            return Execute<bool>(dal =>
            {
                ProductModelProductDescriptionCulture productmodelproductdescriptioncultureAdd = dal.ProductModelProductDescriptionCulture.Where(x => x.ProductModelID == productmodelproductdescriptionculture.ProductModelID).FirstOrDefault();
                if (productmodelproductdescriptioncultureAdd != null)
                {
                    dal.ProductModelProductDescriptionCulture.InsertOnSubmit(productmodelproductdescriptioncultureAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductModelProductDescriptionCultureDelete(ProductModelProductDescriptionCulture productmodelproductdescriptionculture)
        {
            return Execute<bool>(dal =>
            {
                ProductModelProductDescriptionCulture productmodelproductdescriptioncultureDelete = dal.ProductModelProductDescriptionCulture.Where(x => x.ProductModelID == productmodelproductdescriptionculture.ProductModelID).FirstOrDefault();
                if (productmodelproductdescriptioncultureDelete != null)
                {
                    dal.ProductModelProductDescriptionCulture.DeleteOnSubmit(productmodelproductdescriptioncultureDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

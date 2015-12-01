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

        public List<ProductModel> ProductModelList()
        {
            var getProductModel = Execute<List<ProductModel>>(dal =>
            {
                var item = dal.ProductModel.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductModel;
        }

        public List<ProductModel> ProductModelListAll()
        {
            var getProductModel = Execute<List<ProductModel>>(dal =>
            {
                var item = dal.ProductModel;
                return item.ToList();
            });
            return getProductModel;
        }

        public bool ProductModelUpdate(ProductModel productmodel)
        {
            return Execute<bool>(dal =>
            {
                ProductModel productmodelUpdate = dal.ProductModel.Where(x => x.ProductModelID == productmodel.ProductModelID).FirstOrDefault();
                if (productmodelUpdate != null)
                {
                    productmodelUpdate.ProductModelID = productmodel.ProductModelID;
                    productmodelUpdate.Name = productmodel.Name;
                    productmodelUpdate.CatalogDescription = productmodel.CatalogDescription;
                    productmodelUpdate.Instructions = productmodel.Instructions;
                    productmodelUpdate.rowguid = productmodel.rowguid;
                    productmodelUpdate.ModifiedDate = productmodel.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductModelAdd(ProductModel productmodel)
        {
            return Execute<bool>(dal =>
            {
                ProductModel productmodelAdd = dal.ProductModel.Where(x => x.ProductModelID == productmodel.ProductModelID).FirstOrDefault();
                if (productmodelAdd != null)
                {
                    dal.ProductModel.InsertOnSubmit(productmodelAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductModelDelete(ProductModel productmodel)
        {
            return Execute<bool>(dal =>
            {
                ProductModel productmodelDelete = dal.ProductModel.Where(x => x.ProductModelID == productmodel.ProductModelID).FirstOrDefault();
                if (productmodelDelete != null)
                {
                    dal.ProductModel.DeleteOnSubmit(productmodelDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

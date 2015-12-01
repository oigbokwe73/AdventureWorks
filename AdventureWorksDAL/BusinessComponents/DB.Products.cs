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
        public List<Product> ProductsGet()
        {
            var getProduct = Execute<List<Product>>(dal =>
            {
                var item = dal.Product.Skip(0).Take(100);
                return item.ToList();
            });
            return getProduct;
        }

        public bool ProductsUpdate(Product product)
        {
             return Execute<bool>(dal =>
            {
                Product productUpdate = dal.Product.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                if (productUpdate != null)
                {
                    productUpdate.BillOfMaterials = product.BillOfMaterials;
                    productUpdate.BillOfMaterials1 = product.BillOfMaterials1;
                    productUpdate.Class = product.Class;
                    productUpdate.Color = product.Color;
                    productUpdate.DaysToManufacture = product.DaysToManufacture;
                    productUpdate.DiscontinuedDate = product.DiscontinuedDate;
                    productUpdate.FinishedGoodsFlag = product.FinishedGoodsFlag;
                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool ProductsAdd(Product product)
        {
            return Execute<bool>(dal =>
            {
                Product productAdd = dal.Product.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                if (productAdd != null)
                {
                    product.rowguid = Guid.NewGuid();
                    dal.Product.InsertOnSubmit(product);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

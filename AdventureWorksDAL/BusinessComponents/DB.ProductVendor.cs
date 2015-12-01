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

        public List<ProductVendor> ProductVendorList()
        {
            var getProductVendor = Execute<List<ProductVendor>>(dal =>
            {
                var item = dal.ProductVendor.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductVendor;
        }

        public List<ProductVendor> ProductVendorListAll()
        {
            var getProductVendor = Execute<List<ProductVendor>>(dal =>
            {
                var item = dal.ProductVendor;
                return item.ToList();
            });
            return getProductVendor;
        }

        public bool ProductVendorUpdate(ProductVendor productvendor)
        {
            return Execute<bool>(dal =>
            {
                ProductVendor productvendorUpdate = dal.ProductVendor.Where(x => x.ProductID == productvendor.ProductID).FirstOrDefault();
                if (productvendorUpdate != null)
                {
                    productvendorUpdate.ProductID = productvendor.ProductID;
                    productvendorUpdate.BusinessEntityID = productvendor.BusinessEntityID;
                    productvendorUpdate.AverageLeadTime = productvendor.AverageLeadTime;
                    productvendorUpdate.StandardPrice = productvendor.StandardPrice;
                    productvendorUpdate.LastReceiptCost = productvendor.LastReceiptCost;
                    productvendorUpdate.LastReceiptDate = productvendor.LastReceiptDate;
                    productvendorUpdate.MinOrderQty = productvendor.MinOrderQty;
                    productvendorUpdate.MaxOrderQty = productvendor.MaxOrderQty;
                    productvendorUpdate.OnOrderQty = productvendor.OnOrderQty;
                    productvendorUpdate.UnitMeasureCode = productvendor.UnitMeasureCode;
                    productvendorUpdate.ModifiedDate = productvendor.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductVendorAdd(ProductVendor productvendor)
        {
            return Execute<bool>(dal =>
            {
                ProductVendor productvendorAdd = dal.ProductVendor.Where(x => x.ProductID == productvendor.ProductID).FirstOrDefault();
                if (productvendorAdd != null)
                {
                    dal.ProductVendor.InsertOnSubmit(productvendorAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductVendorDelete(ProductVendor productvendor)
        {
            return Execute<bool>(dal =>
            {
                ProductVendor productvendorDelete = dal.ProductVendor.Where(x => x.ProductID == productvendor.ProductID).FirstOrDefault();
                if (productvendorDelete != null)
                {
                    dal.ProductVendor.DeleteOnSubmit(productvendorDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

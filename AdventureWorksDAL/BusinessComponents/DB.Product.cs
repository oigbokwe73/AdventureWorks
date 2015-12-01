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

        public List<Product> ProductList()
        {
            var getProduct = Execute<List<Product>>(dal =>
            {
                var item = dal.Product.Skip(0).Take(100);
                return item.ToList();
            });
            return getProduct;
        }

        public List<Product> ProductListAll()
        {
            var getProduct = Execute<List<Product>>(dal =>
            {
                var item = dal.Product;
                return item.ToList();
            });
            return getProduct;
        }

        public bool ProductUpdate(Product product)
        {
            return Execute<bool>(dal =>
            {
                Product productUpdate = dal.Product.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                if (productUpdate != null)
                {
                    productUpdate.ProductID = product.ProductID;
                    productUpdate.Name = product.Name;
                    productUpdate.ProductNumber = product.ProductNumber;
                    productUpdate.MakeFlag = product.MakeFlag;
                    productUpdate.FinishedGoodsFlag = product.FinishedGoodsFlag;
                    productUpdate.Color = product.Color;
                    productUpdate.SafetyStockLevel = product.SafetyStockLevel;
                    productUpdate.ReorderPoint = product.ReorderPoint;
                    productUpdate.StandardCost = product.StandardCost;
                    productUpdate.ListPrice = product.ListPrice;
                    productUpdate.Size = product.Size;
                    productUpdate.SizeUnitMeasureCode = product.SizeUnitMeasureCode;
                    productUpdate.WeightUnitMeasureCode = product.WeightUnitMeasureCode;
                    productUpdate.Weight = product.Weight;
                    productUpdate.DaysToManufacture = product.DaysToManufacture;
                    productUpdate.ProductLine = product.ProductLine;
                    productUpdate.Class = product.Class;
                    productUpdate.Style = product.Style;
                    productUpdate.ProductSubcategoryID = product.ProductSubcategoryID;
                    productUpdate.ProductModelID = product.ProductModelID;
                    productUpdate.SellStartDate = product.SellStartDate;
                    productUpdate.SellEndDate = product.SellEndDate;
                    productUpdate.DiscontinuedDate = product.DiscontinuedDate;
                    productUpdate.rowguid = product.rowguid;
                    productUpdate.ModifiedDate = product.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductAdd(Product product)
        {
            return Execute<bool>(dal =>
            {
                Product productAdd = dal.Product.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                if (productAdd != null)
                {
                    dal.Product.InsertOnSubmit(productAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductDelete(Product product)
        {
            return Execute<bool>(dal =>
            {
                Product productDelete = dal.Product.Where(x => x.ProductID == product.ProductID).FirstOrDefault();
                if (productDelete != null)
                {
                    dal.Product.DeleteOnSubmit(productDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

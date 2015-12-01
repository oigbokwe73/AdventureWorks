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

        public List<ProductListPriceHistory> ProductListPriceHistoryList()
        {
            var getProductListPriceHistory = Execute<List<ProductListPriceHistory>>(dal =>
            {
                var item = dal.ProductListPriceHistory.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductListPriceHistory;
        }

        public List<ProductListPriceHistory> ProductListPriceHistoryListAll()
        {
            var getProductListPriceHistory = Execute<List<ProductListPriceHistory>>(dal =>
            {
                var item = dal.ProductListPriceHistory;
                return item.ToList();
            });
            return getProductListPriceHistory;
        }

        public bool ProductListPriceHistoryUpdate(ProductListPriceHistory productlistpricehistory)
        {
            return Execute<bool>(dal =>
           {
               ProductListPriceHistory productlistpricehistoryUpdate = dal.ProductListPriceHistory.Where(x => x.ProductID == productlistpricehistory.ProductID).FirstOrDefault();
               if (productlistpricehistoryUpdate != null)
               {
                   productlistpricehistoryUpdate.ProductID = productlistpricehistory.ProductID;
                   productlistpricehistoryUpdate.StartDate = productlistpricehistory.StartDate;
                   productlistpricehistoryUpdate.EndDate = productlistpricehistory.EndDate;
                   productlistpricehistoryUpdate.ListPrice = productlistpricehistory.ListPrice;
                   productlistpricehistoryUpdate.ModifiedDate = productlistpricehistory.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool ProductListPriceHistoryAdd(ProductListPriceHistory productlistpricehistory)
        {
            return Execute<bool>(dal =>
            {
                ProductListPriceHistory productlistpricehistoryAdd = dal.ProductListPriceHistory.Where(x => x.ProductID == productlistpricehistory.ProductID).FirstOrDefault();
                if (productlistpricehistoryAdd != null)
                {
                    dal.ProductListPriceHistory.InsertOnSubmit(productlistpricehistoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductListPriceHistoryDelete(ProductListPriceHistory productlistpricehistory)
        {
            return Execute<bool>(dal =>
            {
                ProductListPriceHistory productlistpricehistoryDelete = dal.ProductListPriceHistory.Where(x => x.ProductID == productlistpricehistory.ProductID).FirstOrDefault();
                if (productlistpricehistoryDelete != null)
                {
                    dal.ProductListPriceHistory.DeleteOnSubmit(productlistpricehistoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

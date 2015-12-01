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

        public List<ProductCostHistory> ProductCostHistoryList()
        {
            var getProductCostHistory = Execute<List<ProductCostHistory>>(dal =>
            {
                var item = dal.ProductCostHistory.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductCostHistory;
        }

        public List<ProductCostHistory> ProductCostHistoryListAll()
        {
            var getProductCostHistory = Execute<List<ProductCostHistory>>(dal =>
            {
                var item = dal.ProductCostHistory;
                return item.ToList();
            });
            return getProductCostHistory;
        }

        public bool ProductCostHistoryUpdate(ProductCostHistory productcosthistory)
        {
             return Execute<bool>(dal =>
            {
                ProductCostHistory productcosthistoryUpdate = dal.ProductCostHistory.Where(x => x.ProductID == productcosthistory.ProductID).FirstOrDefault();
                if (productcosthistoryUpdate != null)
                {
				    productcosthistoryUpdate.ProductID=productcosthistory.ProductID;
productcosthistoryUpdate.StartDate=productcosthistory.StartDate;
productcosthistoryUpdate.EndDate=productcosthistory.EndDate;
productcosthistoryUpdate.StandardCost=productcosthistory.StandardCost;
productcosthistoryUpdate.ModifiedDate=productcosthistory.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool ProductCostHistoryAdd(ProductCostHistory productcosthistory)
        {
            return Execute<bool>(dal =>
            {
                ProductCostHistory productcosthistoryAdd = dal.ProductCostHistory.Where(x => x.ProductID == productcosthistory.ProductID).FirstOrDefault();
                if (productcosthistoryAdd != null)
                {
                    dal.ProductCostHistory.InsertOnSubmit(productcosthistoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductCostHistoryDelete(ProductCostHistory productcosthistory)
        {
            return Execute<bool>(dal =>
            {
                ProductCostHistory productcosthistoryDelete = dal.ProductCostHistory.Where(x => x.ProductID == productcosthistory.ProductID).FirstOrDefault();
                if (productcosthistoryDelete != null)
                {
                    dal.ProductCostHistory.DeleteOnSubmit(productcosthistoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

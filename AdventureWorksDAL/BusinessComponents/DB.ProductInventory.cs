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

        public List<ProductInventory> ProductInventoryList()
        {
            var getProductInventory = Execute<List<ProductInventory>>(dal =>
            {
                var item = dal.ProductInventory.Skip(0).Take(100);
                return item.ToList();
            });
            return getProductInventory;
        }

        public List<ProductInventory> ProductInventoryListAll()
        {
            var getProductInventory = Execute<List<ProductInventory>>(dal =>
            {
                var item = dal.ProductInventory;
                return item.ToList();
            });
            return getProductInventory;
        }

        public bool ProductInventoryUpdate(ProductInventory productinventory)
        {
             return Execute<bool>(dal =>
            {
                ProductInventory productinventoryUpdate = dal.ProductInventory.Where(x => x.ProductID == productinventory.ProductID).FirstOrDefault();
                if (productinventoryUpdate != null)
                {
				    productinventoryUpdate.ProductID=productinventory.ProductID;
productinventoryUpdate.LocationID=productinventory.LocationID;
productinventoryUpdate.Shelf=productinventory.Shelf;
productinventoryUpdate.Bin=productinventory.Bin;
productinventoryUpdate.Quantity=productinventory.Quantity;
productinventoryUpdate.rowguid=productinventory.rowguid;
productinventoryUpdate.ModifiedDate=productinventory.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool ProductInventoryAdd(ProductInventory productinventory)
        {
            return Execute<bool>(dal =>
            {
                ProductInventory productinventoryAdd = dal.ProductInventory.Where(x => x.ProductID == productinventory.ProductID).FirstOrDefault();
                if (productinventoryAdd != null)
                {
                    dal.ProductInventory.InsertOnSubmit(productinventoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ProductInventoryDelete(ProductInventory productinventory)
        {
            return Execute<bool>(dal =>
            {
                ProductInventory productinventoryDelete = dal.ProductInventory.Where(x => x.ProductID == productinventory.ProductID).FirstOrDefault();
                if (productinventoryDelete != null)
                {
                    dal.ProductInventory.DeleteOnSubmit(productinventoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

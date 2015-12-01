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

        public List<Store> StoreList()
        {
            return Execute<List<Store>>(dal =>
            {
                return dal.Store.Skip(0).Take(100).ToList();
               
            });
        }

        public List<Store> StoreListAll()
        {
            var getStore = Execute<List<Store>>(dal =>
            {
                var item = dal.Store;
                return item.ToList();
            });
            return getStore;
        }

        public bool StoreUpdate(Store store)
        {
            return Execute<bool>(dal =>
            {
                Store storeUpdate = dal.Store.Where(x => x.BusinessEntityID == store.BusinessEntityID).FirstOrDefault();
                if (storeUpdate != null)
                {
                    storeUpdate.BusinessEntityID = store.BusinessEntityID;
                    storeUpdate.Name = store.Name;
                    storeUpdate.SalesPersonID = store.SalesPersonID;
                    storeUpdate.Demographics = store.Demographics;
                    storeUpdate.rowguid = store.rowguid;
                    storeUpdate.ModifiedDate = store.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool StoreAdd(Store store)
        {
            return Execute<bool>(dal =>
            {
                Store storeAdd = dal.Store.Where(x => x.BusinessEntityID == store.BusinessEntityID).FirstOrDefault();
                if (storeAdd != null)
                {
                    dal.Store.InsertOnSubmit(storeAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool StoreDelete(Store store)
        {
            return Execute<bool>(dal =>
            {
                Store storeDelete = dal.Store.Where(x => x.BusinessEntityID == store.BusinessEntityID).FirstOrDefault();
                if (storeDelete != null)
                {
                    dal.Store.DeleteOnSubmit(storeDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

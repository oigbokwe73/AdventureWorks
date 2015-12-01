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

        public List<BusinessEntityAddress> BusinessEntityAddressList()
        {
            var getBusinessEntityAddress = Execute<List<BusinessEntityAddress>>(dal =>
            {
                var item = dal.BusinessEntityAddress.Skip(0).Take(100);
                return item.ToList();
            });
            return getBusinessEntityAddress;
        }

        public List<BusinessEntityAddress> BusinessEntityAddressListAll()
        {
            var getBusinessEntityAddress = Execute<List<BusinessEntityAddress>>(dal =>
            {
                var item = dal.BusinessEntityAddress;
                return item.ToList();
            });
            return getBusinessEntityAddress;
        }

        public bool BusinessEntityAddressUpdate(BusinessEntityAddress businessentityaddress)
        {
            return Execute<bool>(dal =>
           {
               BusinessEntityAddress businessentityaddressUpdate = dal.BusinessEntityAddress.Where(x => x.BusinessEntityID == businessentityaddress.BusinessEntityID).FirstOrDefault();
               if (businessentityaddressUpdate != null)
               {
                   businessentityaddressUpdate.BusinessEntityID = businessentityaddress.BusinessEntityID;
                   businessentityaddressUpdate.AddressID = businessentityaddress.AddressID;
                   businessentityaddressUpdate.AddressTypeID = businessentityaddress.AddressTypeID;
                   businessentityaddressUpdate.rowguid = businessentityaddress.rowguid;
                   businessentityaddressUpdate.ModifiedDate = businessentityaddress.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool BusinessEntityAddressAdd(BusinessEntityAddress businessentityaddress)
        {
            return Execute<bool>(dal =>
            {
                BusinessEntityAddress businessentityaddressAdd = dal.BusinessEntityAddress.Where(x => x.BusinessEntityID == businessentityaddress.BusinessEntityID).FirstOrDefault();
                if (businessentityaddressAdd != null)
                {
                    dal.BusinessEntityAddress.InsertOnSubmit(businessentityaddressAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool BusinessEntityAddressDelete(BusinessEntityAddress businessentityaddress)
        {
            return Execute<bool>(dal =>
            {
                BusinessEntityAddress businessentityaddressDelete = dal.BusinessEntityAddress.Where(x => x.BusinessEntityID == businessentityaddress.BusinessEntityID).FirstOrDefault();
                if (businessentityaddressDelete != null)
                {
                    dal.BusinessEntityAddress.DeleteOnSubmit(businessentityaddressDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

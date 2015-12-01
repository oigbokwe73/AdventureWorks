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

        public List<Vendor> VendorList()
        {
            var getVendor = Execute<List<Vendor>>(dal =>
            {
                var item = dal.Vendor.Skip(0).Take(100);
                return item.ToList();
            });
            return getVendor;
        }

        public List<Vendor> VendorListAll()
        {
            var getVendor = Execute<List<Vendor>>(dal =>
            {
                var item = dal.Vendor;
                return item.ToList();
            });
            return getVendor;
        }

        public bool VendorUpdate(Vendor vendor)
        {
            return Execute<bool>(dal =>
           {
               Vendor vendorUpdate = dal.Vendor.Where(x => x.BusinessEntityID == vendor.BusinessEntityID).FirstOrDefault();
               if (vendorUpdate != null)
               {
                   vendorUpdate.BusinessEntityID = vendor.BusinessEntityID;
                   vendorUpdate.AccountNumber = vendor.AccountNumber;
                   vendorUpdate.Name = vendor.Name;
                   vendorUpdate.CreditRating = vendor.CreditRating;
                   vendorUpdate.PreferredVendorStatus = vendor.PreferredVendorStatus;
                   vendorUpdate.ActiveFlag = vendor.ActiveFlag;
                   vendorUpdate.PurchasingWebServiceURL = vendor.PurchasingWebServiceURL;
                   vendorUpdate.ModifiedDate = vendor.ModifiedDate;
                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool VendorAdd(Vendor vendor)
        {
            return Execute<bool>(dal =>
            {
                Vendor vendorAdd = dal.Vendor.Where(x => x.BusinessEntityID == vendor.BusinessEntityID).FirstOrDefault();
                if (vendorAdd != null)
                {
                    dal.Vendor.InsertOnSubmit(vendorAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool VendorDelete(Vendor vendor)
        {
            return Execute<bool>(dal =>
            {
                Vendor vendorDelete = dal.Vendor.Where(x => x.BusinessEntityID == vendor.BusinessEntityID).FirstOrDefault();
                if (vendorDelete != null)
                {
                    dal.Vendor.DeleteOnSubmit(vendorDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

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

        public List<BusinessEntityContact> BusinessEntityContactList()
        {
            var getBusinessEntityContact = Execute<List<BusinessEntityContact>>(dal =>
            {
                var item = dal.BusinessEntityContact.Skip(0).Take(100);
                return item.ToList();
            });
            return getBusinessEntityContact;
        }

        public List<BusinessEntityContact> BusinessEntityContactListAll()
        {
            var getBusinessEntityContact = Execute<List<BusinessEntityContact>>(dal =>
            {
                var item = dal.BusinessEntityContact;
                return item.ToList();
            });
            return getBusinessEntityContact;
        }

        public bool BusinessEntityContactUpdate(BusinessEntityContact businessentitycontact)
        {
            return Execute<bool>(dal =>
           {
               BusinessEntityContact businessentitycontactUpdate = dal.BusinessEntityContact.Where(x => x.BusinessEntityID == businessentitycontact.BusinessEntityID).FirstOrDefault();
               if (businessentitycontactUpdate != null)
               {
                   businessentitycontactUpdate.BusinessEntityID = businessentitycontact.BusinessEntityID;
                   businessentitycontactUpdate.PersonID = businessentitycontact.PersonID;
                   businessentitycontactUpdate.ContactTypeID = businessentitycontact.ContactTypeID;
                   businessentitycontactUpdate.rowguid = businessentitycontact.rowguid;
                   businessentitycontactUpdate.ModifiedDate = businessentitycontact.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool BusinessEntityContactAdd(BusinessEntityContact businessentitycontact)
        {
            return Execute<bool>(dal =>
            {
                BusinessEntityContact businessentitycontactAdd = dal.BusinessEntityContact.Where(x => x.BusinessEntityID == businessentitycontact.BusinessEntityID).FirstOrDefault();
                if (businessentitycontactAdd != null)
                {
                    dal.BusinessEntityContact.InsertOnSubmit(businessentitycontactAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool BusinessEntityContactDelete(BusinessEntityContact businessentitycontact)
        {
            return Execute<bool>(dal =>
            {
                BusinessEntityContact businessentitycontactDelete = dal.BusinessEntityContact.Where(x => x.BusinessEntityID == businessentitycontact.BusinessEntityID).FirstOrDefault();
                if (businessentitycontactDelete != null)
                {
                    dal.BusinessEntityContact.DeleteOnSubmit(businessentitycontactDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

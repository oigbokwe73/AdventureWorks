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

        public List<EmailAddress> EmailAddressList()
        {
            var getEmailAddress = Execute<List<EmailAddress>>(dal =>
            {
                var item = dal.EmailAddress.Skip(0).Take(100);
                return item.ToList();
            });
            return getEmailAddress;
        }

        public List<EmailAddress> EmailAddressListAll()
        {
            var getEmailAddress = Execute<List<EmailAddress>>(dal =>
            {
                var item = dal.EmailAddress;
                return item.ToList();
            });
            return getEmailAddress;
        }

        public bool EmailAddressUpdate(EmailAddress emailaddress)
        {
            return Execute<bool>(dal =>
            {
                EmailAddress emailaddressUpdate = dal.EmailAddress.Where(x => x.BusinessEntityID == emailaddress.BusinessEntityID).FirstOrDefault();
                if (emailaddressUpdate != null)
                {
                    emailaddressUpdate.BusinessEntityID = emailaddress.BusinessEntityID;
                    emailaddressUpdate.EmailAddressID = emailaddress.EmailAddressID;
                    emailaddressUpdate.EmailAddress1 = emailaddress.EmailAddress1;
                    emailaddressUpdate.rowguid = emailaddress.rowguid;
                    emailaddressUpdate.ModifiedDate = emailaddress.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool EmailAddressAdd(EmailAddress emailaddress)
        {
            return Execute<bool>(dal =>
            {
                EmailAddress emailaddressAdd = dal.EmailAddress.Where(x => x.BusinessEntityID == emailaddress.BusinessEntityID).FirstOrDefault();
                if (emailaddressAdd != null)
                {
                    dal.EmailAddress.InsertOnSubmit(emailaddressAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool EmailAddressDelete(EmailAddress emailaddress)
        {
            return Execute<bool>(dal =>
            {
                EmailAddress emailaddressDelete = dal.EmailAddress.Where(x => x.BusinessEntityID == emailaddress.BusinessEntityID).FirstOrDefault();
                if (emailaddressDelete != null)
                {
                    dal.EmailAddress.DeleteOnSubmit(emailaddressDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

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

        public List<PersonPhone> PersonPhoneList()
        {
            var getPersonPhone = Execute<List<PersonPhone>>(dal =>
            {
                var item = dal.PersonPhone.Skip(0).Take(100);
                return item.ToList();
            });
            return getPersonPhone;
        }

        public List<PersonPhone> PersonPhoneListAll()
        {
            var getPersonPhone = Execute<List<PersonPhone>>(dal =>
            {
                var item = dal.PersonPhone;
                return item.ToList();
            });
            return getPersonPhone;
        }

        public bool PersonPhoneUpdate(PersonPhone personphone)
        {
             return Execute<bool>(dal =>
            {
                PersonPhone personphoneUpdate = dal.PersonPhone.Where(x => x.BusinessEntityID == personphone.BusinessEntityID).FirstOrDefault();
                if (personphoneUpdate != null)
                {
				    personphoneUpdate.BusinessEntityID=personphone.BusinessEntityID;
personphoneUpdate.PhoneNumber=personphone.PhoneNumber;
personphoneUpdate.PhoneNumberTypeID=personphone.PhoneNumberTypeID;
personphoneUpdate.ModifiedDate=personphone.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool PersonPhoneAdd(PersonPhone personphone)
        {
            return Execute<bool>(dal =>
            {
                PersonPhone personphoneAdd = dal.PersonPhone.Where(x => x.BusinessEntityID == personphone.BusinessEntityID).FirstOrDefault();
                if (personphoneAdd != null)
                {
                    dal.PersonPhone.InsertOnSubmit(personphoneAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PersonPhoneDelete(PersonPhone personphone)
        {
            return Execute<bool>(dal =>
            {
                PersonPhone personphoneDelete = dal.PersonPhone.Where(x => x.BusinessEntityID == personphone.BusinessEntityID).FirstOrDefault();
                if (personphoneDelete != null)
                {
                    dal.PersonPhone.DeleteOnSubmit(personphoneDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

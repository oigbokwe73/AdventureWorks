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

        public List<PhoneNumberType> PhoneNumberTypeList()
        {
            var getPhoneNumberType = Execute<List<PhoneNumberType>>(dal =>
            {
                var item = dal.PhoneNumberType.Skip(0).Take(100);
                return item.ToList();
            });
            return getPhoneNumberType;
        }

        public List<PhoneNumberType> PhoneNumberTypeListAll()
        {
            var getPhoneNumberType = Execute<List<PhoneNumberType>>(dal =>
            {
                var item = dal.PhoneNumberType;
                return item.ToList();
            });
            return getPhoneNumberType;
        }

        public bool PhoneNumberTypeUpdate(PhoneNumberType phonenumbertype)
        {
             return Execute<bool>(dal =>
            {
                PhoneNumberType phonenumbertypeUpdate = dal.PhoneNumberType.Where(x => x.PhoneNumberTypeID == phonenumbertype.PhoneNumberTypeID).FirstOrDefault();
                if (phonenumbertypeUpdate != null)
                {
				    phonenumbertypeUpdate.PhoneNumberTypeID=phonenumbertype.PhoneNumberTypeID;
phonenumbertypeUpdate.Name=phonenumbertype.Name;
phonenumbertypeUpdate.ModifiedDate=phonenumbertype.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool PhoneNumberTypeAdd(PhoneNumberType phonenumbertype)
        {
            return Execute<bool>(dal =>
            {
                PhoneNumberType phonenumbertypeAdd = dal.PhoneNumberType.Where(x => x.PhoneNumberTypeID == phonenumbertype.PhoneNumberTypeID).FirstOrDefault();
                if (phonenumbertypeAdd != null)
                {
                    dal.PhoneNumberType.InsertOnSubmit(phonenumbertypeAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PhoneNumberTypeDelete(PhoneNumberType phonenumbertype)
        {
            return Execute<bool>(dal =>
            {
                PhoneNumberType phonenumbertypeDelete = dal.PhoneNumberType.Where(x => x.PhoneNumberTypeID == phonenumbertype.PhoneNumberTypeID).FirstOrDefault();
                if (phonenumbertypeDelete != null)
                {
                    dal.PhoneNumberType.DeleteOnSubmit(phonenumbertypeDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

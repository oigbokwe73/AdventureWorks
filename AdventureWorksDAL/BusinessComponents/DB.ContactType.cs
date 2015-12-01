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

        public List<ContactType> ContactTypeList()
        {
            List<ContactType> getContactType = new List<ContactType>();
            getContactType = Execute<List<ContactType>>(dal =>
            {
                var item = dal.ContactType.Skip(0).Take(100).ToList();
                return item;
            });
            return getContactType;
        }

        public List<ContactType> ContactTypeListAll()
        {
            var getContactType = Execute<List<ContactType>>(dal =>
            {
                var item = dal.ContactType;
                return item.ToList();
            });
            return getContactType;
        }

        public bool ContactTypeUpdate(ContactType contacttype)
        {
            return Execute<bool>(dal =>
            {
                ContactType contacttypeUpdate = dal.ContactType.Where(x => x.ContactTypeID == contacttype.ContactTypeID).FirstOrDefault();
                if (contacttypeUpdate != null)
                {
                    contacttypeUpdate.ContactTypeID = contacttype.ContactTypeID;
                    contacttypeUpdate.Name = contacttype.Name;
                    contacttypeUpdate.ModifiedDate = contacttype.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ContactTypeAdd(ContactType contacttype)
        {
            return Execute<bool>(dal =>
            {
                ContactType contacttypeAdd = dal.ContactType.Where(x => x.ContactTypeID == contacttype.ContactTypeID).FirstOrDefault();
                if (contacttypeAdd != null)
                {
                    dal.ContactType.InsertOnSubmit(contacttypeAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ContactTypeDelete(ContactType contacttype)
        {
            return Execute<bool>(dal =>
            {
                ContactType contacttypeDelete = dal.ContactType.Where(x => x.ContactTypeID == contacttype.ContactTypeID).FirstOrDefault();
                if (contacttypeDelete != null)
                {
                    dal.ContactType.DeleteOnSubmit(contacttypeDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

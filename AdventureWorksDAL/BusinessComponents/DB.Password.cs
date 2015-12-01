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

        public List<Password> PasswordList()
        {
            var getPassword = Execute<List<Password>>(dal =>
            {
                var item = dal.Password.Skip(0).Take(100);
                return item.ToList();
            });
            return getPassword;
        }

        public List<Password> PasswordListAll()
        {
            var getPassword = Execute<List<Password>>(dal =>
            {
                var item = dal.Password;
                return item.ToList();
            });
            return getPassword;
        }

        public bool PasswordUpdate(Password password)
        {
            return Execute<bool>(dal =>
            {
                Password passwordUpdate = dal.Password.Where(x => x.BusinessEntityID == password.BusinessEntityID).FirstOrDefault();
                if (passwordUpdate != null)
                {
                    passwordUpdate.BusinessEntityID = password.BusinessEntityID;
                    passwordUpdate.PasswordHash = password.PasswordHash;
                    passwordUpdate.PasswordSalt = password.PasswordSalt;
                    passwordUpdate.rowguid = password.rowguid;
                    passwordUpdate.ModifiedDate = password.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PasswordAdd(Password password)
        {
            return Execute<bool>(dal =>
            {
                Password passwordAdd = dal.Password.Where(x => x.BusinessEntityID == password.BusinessEntityID).FirstOrDefault();
                if (passwordAdd != null)
                {
                    dal.Password.InsertOnSubmit(passwordAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PasswordDelete(Password password)
        {
            return Execute<bool>(dal =>
            {
                Password passwordDelete = dal.Password.Where(x => x.BusinessEntityID == password.BusinessEntityID).FirstOrDefault();
                if (passwordDelete != null)
                {
                    dal.Password.DeleteOnSubmit(passwordDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

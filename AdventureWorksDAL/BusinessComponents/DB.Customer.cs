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

        public List<Customer> CustomerList()
        {
            var getCustomer = Execute<List<Customer>>(dal =>
            {
                var item = dal.Customer.Skip(0).Take(100);
                return item.ToList();
            });
            return getCustomer;
        }

        public List<Customer> CustomerListAll()
        {
            var getCustomer = Execute<List<Customer>>(dal =>
            {
                var item = dal.Customer;
                return item.ToList();
            });
            return getCustomer;
        }

        public bool CustomerUpdate(Customer customer)
        {
            return Execute<bool>(dal =>
           {
               Customer customerUpdate = dal.Customer.Where(x => x.CustomerID == customer.CustomerID).FirstOrDefault();
               if (customerUpdate != null)
               {
                   customerUpdate.CustomerID = customer.CustomerID;
                   customerUpdate.PersonID = customer.PersonID;
                   customerUpdate.StoreID = customer.StoreID;
                   customerUpdate.TerritoryID = customer.TerritoryID;
                   customerUpdate.AccountNumber = customer.AccountNumber;
                   customerUpdate.rowguid = customer.rowguid;
                   customerUpdate.ModifiedDate = customer.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool CustomerAdd(Customer customer)
        {
            return Execute<bool>(dal =>
            {
                Customer customerAdd = dal.Customer.Where(x => x.CustomerID == customer.CustomerID).FirstOrDefault();
                if (customerAdd != null)
                {
                    dal.Customer.InsertOnSubmit(customerAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CustomerDelete(Customer customer)
        {
            return Execute<bool>(dal =>
            {
                Customer customerDelete = dal.Customer.Where(x => x.CustomerID == customer.CustomerID).FirstOrDefault();
                if (customerDelete != null)
                {
                    dal.Customer.DeleteOnSubmit(customerDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

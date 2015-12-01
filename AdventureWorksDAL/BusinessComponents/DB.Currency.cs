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

        public List<Currency> CurrencyList()
        {
            var getCurrency = Execute<List<Currency>>(dal =>
            {
                var item = dal.Currency.Skip(0).Take(100);
                return item.ToList();
            });
            return getCurrency;
        }

        public List<Currency> CurrencyListAll()
        {
            var getCurrency = Execute<List<Currency>>(dal =>
            {
                var item = dal.Currency;
                return item.ToList();
            });
            return getCurrency;
        }

        public bool CurrencyUpdate(Currency currency)
        {
            return Execute<bool>(dal =>
           {
               Currency currencyUpdate = dal.Currency.Where(x => x.CurrencyCode == currency.CurrencyCode).FirstOrDefault();
               if (currencyUpdate != null)
               {
                   currencyUpdate.CurrencyCode = currency.CurrencyCode;
                   currencyUpdate.Name = currency.Name;
                   currencyUpdate.ModifiedDate = currency.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool CurrencyAdd(Currency currency)
        {
            return Execute<bool>(dal =>
            {
                Currency currencyAdd = dal.Currency.Where(x => x.CurrencyCode == currency.CurrencyCode).FirstOrDefault();
                if (currencyAdd != null)
                {
                    dal.Currency.InsertOnSubmit(currencyAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CurrencyDelete(Currency currency)
        {
            return Execute<bool>(dal =>
            {
                Currency currencyDelete = dal.Currency.Where(x => x.CurrencyCode == currency.CurrencyCode).FirstOrDefault();
                if (currencyDelete != null)
                {
                    dal.Currency.DeleteOnSubmit(currencyDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

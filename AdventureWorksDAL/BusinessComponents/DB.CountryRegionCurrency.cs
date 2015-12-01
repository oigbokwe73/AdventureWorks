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

        public List<CountryRegionCurrency> CountryRegionCurrencyList()
        {
            var getCountryRegionCurrency = Execute<List<CountryRegionCurrency>>(dal =>
            {
                var item = dal.CountryRegionCurrency.Skip(0).Take(100);
                return item.ToList();
            });
            return getCountryRegionCurrency;
        }

        public List<CountryRegionCurrency> CountryRegionCurrencyListAll()
        {
            var getCountryRegionCurrency = Execute<List<CountryRegionCurrency>>(dal =>
            {
                var item = dal.CountryRegionCurrency;
                return item.ToList();
            });
            return getCountryRegionCurrency;
        }

        public bool CountryRegionCurrencyUpdate(CountryRegionCurrency countryregioncurrency)
        {
            return Execute<bool>(dal =>
           {
               CountryRegionCurrency countryregioncurrencyUpdate = dal.CountryRegionCurrency.Where(x => x.CountryRegionCode == countryregioncurrency.CountryRegionCode).FirstOrDefault();
               if (countryregioncurrencyUpdate != null)
               {
                   countryregioncurrencyUpdate.CountryRegionCode = countryregioncurrency.CountryRegionCode;
                   countryregioncurrencyUpdate.CurrencyCode = countryregioncurrency.CurrencyCode;
                   countryregioncurrencyUpdate.ModifiedDate = countryregioncurrency.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool CountryRegionCurrencyAdd(CountryRegionCurrency countryregioncurrency)
        {
            return Execute<bool>(dal =>
            {
                CountryRegionCurrency countryregioncurrencyAdd = dal.CountryRegionCurrency.Where(x => x.CountryRegionCode == countryregioncurrency.CountryRegionCode).FirstOrDefault();
                if (countryregioncurrencyAdd != null)
                {
                    dal.CountryRegionCurrency.InsertOnSubmit(countryregioncurrencyAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CountryRegionCurrencyDelete(CountryRegionCurrency countryregioncurrency)
        {
            return Execute<bool>(dal =>
            {
                CountryRegionCurrency countryregioncurrencyDelete = dal.CountryRegionCurrency.Where(x => x.CountryRegionCode == countryregioncurrency.CountryRegionCode).FirstOrDefault();
                if (countryregioncurrencyDelete != null)
                {
                    dal.CountryRegionCurrency.DeleteOnSubmit(countryregioncurrencyDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

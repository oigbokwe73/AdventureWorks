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

        public List<CurrencyRate> CurrencyRateList()
        {
            var getCurrencyRate = Execute<List<CurrencyRate>>(dal =>
            {
                var item = dal.CurrencyRate.Skip(0).Take(100);
                return item.ToList();
            });
            return getCurrencyRate;
        }

        public List<CurrencyRate> CurrencyRateListAll()
        {
            var getCurrencyRate = Execute<List<CurrencyRate>>(dal =>
            {
                var item = dal.CurrencyRate;
                return item.ToList();
            });
            return getCurrencyRate;
        }

        public bool CurrencyRateUpdate(CurrencyRate currencyrate)
        {
            return Execute<bool>(dal =>
           {
               CurrencyRate currencyrateUpdate = dal.CurrencyRate.Where(x => x.CurrencyRateID == currencyrate.CurrencyRateID).FirstOrDefault();
               if (currencyrateUpdate != null)
               {
                   currencyrateUpdate.CurrencyRateID = currencyrate.CurrencyRateID;
                   currencyrateUpdate.CurrencyRateDate = currencyrate.CurrencyRateDate;
                   currencyrateUpdate.FromCurrencyCode = currencyrate.FromCurrencyCode;
                   currencyrateUpdate.ToCurrencyCode = currencyrate.ToCurrencyCode;
                   currencyrateUpdate.AverageRate = currencyrate.AverageRate;
                   currencyrateUpdate.EndOfDayRate = currencyrate.EndOfDayRate;
                   currencyrateUpdate.ModifiedDate = currencyrate.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool CurrencyRateAdd(CurrencyRate currencyrate)
        {
            return Execute<bool>(dal =>
            {
                CurrencyRate currencyrateAdd = dal.CurrencyRate.Where(x => x.CurrencyRateID == currencyrate.CurrencyRateID).FirstOrDefault();
                if (currencyrateAdd != null)
                {
                    dal.CurrencyRate.InsertOnSubmit(currencyrateAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CurrencyRateDelete(CurrencyRate currencyrate)
        {
            return Execute<bool>(dal =>
            {
                CurrencyRate currencyrateDelete = dal.CurrencyRate.Where(x => x.CurrencyRateID == currencyrate.CurrencyRateID).FirstOrDefault();
                if (currencyrateDelete != null)
                {
                    dal.CurrencyRate.DeleteOnSubmit(currencyrateDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

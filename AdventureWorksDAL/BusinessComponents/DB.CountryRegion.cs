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

        public List<CountryRegion> CountryRegionList()
        {
            var getCountryRegion = Execute<List<CountryRegion>>(dal =>
            {
                var item = dal.CountryRegion.Skip(0).Take(100);
                return item.ToList();
            });
            return getCountryRegion;
        }

        public List<CountryRegion> CountryRegionListAll()
        {
            var getCountryRegion = Execute<List<CountryRegion>>(dal =>
            {
                var item = dal.CountryRegion;
                return item.ToList();
            });
            return getCountryRegion;
        }

        public bool CountryRegionUpdate(CountryRegion countryregion)
        {
            return Execute<bool>(dal =>
            {
                CountryRegion countryregionUpdate = dal.CountryRegion.Where(x => x.CountryRegionCode == countryregion.CountryRegionCode).FirstOrDefault();
                if (countryregionUpdate != null)
                {
                    countryregionUpdate.CountryRegionCode = countryregion.CountryRegionCode;
                    countryregionUpdate.Name = countryregion.Name;
                    countryregionUpdate.ModifiedDate = countryregion.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CountryRegionAdd(CountryRegion countryregion)
        {
            return Execute<bool>(dal =>
            {
                CountryRegion countryregionAdd = dal.CountryRegion.Where(x => x.CountryRegionCode == countryregion.CountryRegionCode).FirstOrDefault();
                if (countryregionAdd != null)
                {
                    dal.CountryRegion.InsertOnSubmit(countryregionAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CountryRegionDelete(CountryRegion countryregion)
        {
            return Execute<bool>(dal =>
            {
                CountryRegion countryregionDelete = dal.CountryRegion.Where(x => x.CountryRegionCode == countryregion.CountryRegionCode).FirstOrDefault();
                if (countryregionDelete != null)
                {
                    dal.CountryRegion.DeleteOnSubmit(countryregionDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

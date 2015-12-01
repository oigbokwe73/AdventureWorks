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

        public List<StateProvince> StateProvinceList()
        {
            var getStateProvince = Execute<List<StateProvince>>(dal =>
            {
                var item = dal.StateProvince.Skip(0).Take(100);
                return item.ToList();
            });
            return getStateProvince;
        }

        public List<StateProvince> StateProvinceListAll()
        {
            var getStateProvince = Execute<List<StateProvince>>(dal =>
            {
                var item = dal.StateProvince;
                return item.ToList();
            });
            return getStateProvince;
        }

        public bool StateProvinceUpdate(StateProvince stateprovince)
        {
            return Execute<bool>(dal =>
            {
                StateProvince stateprovinceUpdate = dal.StateProvince.Where(x => x.StateProvinceID == stateprovince.StateProvinceID).FirstOrDefault();
                if (stateprovinceUpdate != null)
                {
                    stateprovinceUpdate.StateProvinceID = stateprovince.StateProvinceID;
                    stateprovinceUpdate.StateProvinceCode = stateprovince.StateProvinceCode;
                    stateprovinceUpdate.CountryRegionCode = stateprovince.CountryRegionCode;
                    stateprovinceUpdate.IsOnlyStateProvinceFlag = stateprovince.IsOnlyStateProvinceFlag;
                    stateprovinceUpdate.Name = stateprovince.Name;
                    stateprovinceUpdate.TerritoryID = stateprovince.TerritoryID;
                    stateprovinceUpdate.rowguid = stateprovince.rowguid;
                    stateprovinceUpdate.ModifiedDate = stateprovince.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool StateProvinceAdd(StateProvince stateprovince)
        {
            return Execute<bool>(dal =>
            {
                StateProvince stateprovinceAdd = dal.StateProvince.Where(x => x.StateProvinceID == stateprovince.StateProvinceID).FirstOrDefault();
                if (stateprovinceAdd != null)
                {
                    dal.StateProvince.InsertOnSubmit(stateprovinceAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool StateProvinceDelete(StateProvince stateprovince)
        {
            return Execute<bool>(dal =>
            {
                StateProvince stateprovinceDelete = dal.StateProvince.Where(x => x.StateProvinceID == stateprovince.StateProvinceID).FirstOrDefault();
                if (stateprovinceDelete != null)
                {
                    dal.StateProvince.DeleteOnSubmit(stateprovinceDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

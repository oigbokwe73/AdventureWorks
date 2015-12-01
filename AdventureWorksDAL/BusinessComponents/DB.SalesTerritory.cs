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

        public List<SalesTerritory> SalesTerritoryList()
        {
            var getSalesTerritory = Execute<List<SalesTerritory>>(dal =>
            {
                var item = dal.SalesTerritory.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesTerritory;
        }

        public List<SalesTerritory> SalesTerritoryListAll()
        {
            var getSalesTerritory = Execute<List<SalesTerritory>>(dal =>
            {
                var item = dal.SalesTerritory;
                return item.ToList();
            });
            return getSalesTerritory;
        }

        public bool SalesTerritoryUpdate(SalesTerritory salesterritory)
        {
            return Execute<bool>(dal =>
            {
                SalesTerritory salesterritoryUpdate = dal.SalesTerritory.Where(x => x.TerritoryID == salesterritory.TerritoryID).FirstOrDefault();
                if (salesterritoryUpdate != null)
                {
                    salesterritoryUpdate.TerritoryID = salesterritory.TerritoryID;
                    salesterritoryUpdate.Name = salesterritory.Name;
                    salesterritoryUpdate.CountryRegionCode = salesterritory.CountryRegionCode;
                    salesterritoryUpdate.Group = salesterritory.Group;
                    salesterritoryUpdate.SalesYTD = salesterritory.SalesYTD;
                    salesterritoryUpdate.SalesLastYear = salesterritory.SalesLastYear;
                    salesterritoryUpdate.CostYTD = salesterritory.CostYTD;
                    salesterritoryUpdate.CostLastYear = salesterritory.CostLastYear;
                    salesterritoryUpdate.rowguid = salesterritory.rowguid;
                    salesterritoryUpdate.ModifiedDate = salesterritory.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesTerritoryAdd(SalesTerritory salesterritory)
        {
            return Execute<bool>(dal =>
            {
                SalesTerritory salesterritoryAdd = dal.SalesTerritory.Where(x => x.TerritoryID == salesterritory.TerritoryID).FirstOrDefault();
                if (salesterritoryAdd != null)
                {
                    dal.SalesTerritory.InsertOnSubmit(salesterritoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesTerritoryDelete(SalesTerritory salesterritory)
        {
            return Execute<bool>(dal =>
            {
                SalesTerritory salesterritoryDelete = dal.SalesTerritory.Where(x => x.TerritoryID == salesterritory.TerritoryID).FirstOrDefault();
                if (salesterritoryDelete != null)
                {
                    dal.SalesTerritory.DeleteOnSubmit(salesterritoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

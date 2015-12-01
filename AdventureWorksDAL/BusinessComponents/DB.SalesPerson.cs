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

        public List<SalesPerson> SalesPersonList()
        {
            var getSalesPerson = Execute<List<SalesPerson>>(dal =>
            {
                var item = dal.SalesPerson.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesPerson;
        }

        public List<SalesPerson> SalesPersonListAll()
        {
            var getSalesPerson = Execute<List<SalesPerson>>(dal =>
            {
                var item = dal.SalesPerson;
                return item.ToList();
            });
            return getSalesPerson;
        }

        public bool SalesPersonUpdate(SalesPerson salesperson)
        {
             return Execute<bool>(dal =>
            {
                SalesPerson salespersonUpdate = dal.SalesPerson.Where(x => x.BusinessEntityID == salesperson.BusinessEntityID).FirstOrDefault();
                if (salespersonUpdate != null)
                {
                    salespersonUpdate.BusinessEntityID = salesperson.BusinessEntityID;
                    salespersonUpdate.TerritoryID = salesperson.TerritoryID;
                    salespersonUpdate.SalesQuota = salesperson.SalesQuota;
                    salespersonUpdate.Bonus = salesperson.Bonus;
                    salespersonUpdate.CommissionPct = salesperson.CommissionPct;
                    salespersonUpdate.SalesYTD = salesperson.SalesYTD;
                    salespersonUpdate.SalesLastYear = salesperson.SalesLastYear;
                    salespersonUpdate.rowguid = salesperson.rowguid;
                    salespersonUpdate.ModifiedDate = salesperson.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesPersonAdd(SalesPerson salesperson)
        {
            return Execute<bool>(dal =>
            {
                SalesPerson salespersonAdd = dal.SalesPerson.Where(x => x.BusinessEntityID == salesperson.BusinessEntityID).FirstOrDefault();
                if (salespersonAdd != null)
                {
                    dal.SalesPerson.InsertOnSubmit(salespersonAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesPersonDelete(SalesPerson salesperson)
        {
            return Execute<bool>(dal =>
            {
                SalesPerson salespersonDelete = dal.SalesPerson.Where(x => x.BusinessEntityID == salesperson.BusinessEntityID).FirstOrDefault();
                if (salespersonDelete != null)
                {
                    dal.SalesPerson.DeleteOnSubmit(salespersonDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

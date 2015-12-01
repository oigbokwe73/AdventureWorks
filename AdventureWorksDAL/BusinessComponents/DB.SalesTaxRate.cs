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

        public List<SalesTaxRate> SalesTaxRateList()
        {
            var getSalesTaxRate = Execute<List<SalesTaxRate>>(dal =>
            {
                var item = dal.SalesTaxRate.Skip(0).Take(100);
                return item.ToList();
            });
            return getSalesTaxRate;
        }

        public List<SalesTaxRate> SalesTaxRateListAll()
        {
            var getSalesTaxRate = Execute<List<SalesTaxRate>>(dal =>
            {
                var item = dal.SalesTaxRate;
                return item.ToList();
            });
            return getSalesTaxRate;
        }

        public bool SalesTaxRateUpdate(SalesTaxRate salestaxrate)
        {
             return Execute<bool>(dal =>
            {
                SalesTaxRate salestaxrateUpdate = dal.SalesTaxRate.Where(x => x.SalesTaxRateID == salestaxrate.SalesTaxRateID).FirstOrDefault();
                if (salestaxrateUpdate != null)
                {
                    salestaxrateUpdate.SalesTaxRateID = salestaxrate.SalesTaxRateID;
                    salestaxrateUpdate.StateProvinceID = salestaxrate.StateProvinceID;
                    salestaxrateUpdate.TaxType = salestaxrate.TaxType;
                    salestaxrateUpdate.TaxRate = salestaxrate.TaxRate;
                    salestaxrateUpdate.Name = salestaxrate.Name;
                    salestaxrateUpdate.rowguid = salestaxrate.rowguid;
                    salestaxrateUpdate.ModifiedDate = salestaxrate.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesTaxRateAdd(SalesTaxRate salestaxrate)
        {
            return Execute<bool>(dal =>
            {
                SalesTaxRate salestaxrateAdd = dal.SalesTaxRate.Where(x => x.SalesTaxRateID == salestaxrate.SalesTaxRateID).FirstOrDefault();
                if (salestaxrateAdd != null)
                {
                    dal.SalesTaxRate.InsertOnSubmit(salestaxrateAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SalesTaxRateDelete(SalesTaxRate salestaxrate)
        {
            return Execute<bool>(dal =>
            {
                SalesTaxRate salestaxrateDelete = dal.SalesTaxRate.Where(x => x.SalesTaxRateID == salestaxrate.SalesTaxRateID).FirstOrDefault();
                if (salestaxrateDelete != null)
                {
                    dal.SalesTaxRate.DeleteOnSubmit(salestaxrateDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

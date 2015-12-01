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

        public List<UnitMeasure> UnitMeasureList()
        {
            var getUnitMeasure = Execute<List<UnitMeasure>>(dal =>
            {
                var item = dal.UnitMeasure.Skip(0).Take(100);
                return item.ToList();
            });
            return getUnitMeasure;
        }

        public List<UnitMeasure> UnitMeasureListAll()
        {
            var getUnitMeasure = Execute<List<UnitMeasure>>(dal =>
            {
                var item = dal.UnitMeasure;
                return item.ToList();
            });
            return getUnitMeasure;
        }

        public bool UnitMeasureUpdate(UnitMeasure unitmeasure)
        {
            return Execute<bool>(dal =>
            {
                UnitMeasure unitmeasureUpdate = dal.UnitMeasure.Where(x => x.UnitMeasureCode == unitmeasure.UnitMeasureCode).FirstOrDefault();
                if (unitmeasureUpdate != null)
                {
                    unitmeasureUpdate.UnitMeasureCode = unitmeasure.UnitMeasureCode;
                    unitmeasureUpdate.Name = unitmeasure.Name;
                    unitmeasureUpdate.ModifiedDate = unitmeasure.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool UnitMeasureAdd(UnitMeasure unitmeasure)
        {
            return Execute<bool>(dal =>
            {
                UnitMeasure unitmeasureAdd = dal.UnitMeasure.Where(x => x.UnitMeasureCode == unitmeasure.UnitMeasureCode).FirstOrDefault();
                if (unitmeasureAdd != null)
                {
                    dal.UnitMeasure.InsertOnSubmit(unitmeasureAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool UnitMeasureDelete(UnitMeasure unitmeasure)
        {
            return Execute<bool>(dal =>
            {
                UnitMeasure unitmeasureDelete = dal.UnitMeasure.Where(x => x.UnitMeasureCode == unitmeasure.UnitMeasureCode).FirstOrDefault();
                if (unitmeasureDelete != null)
                {
                    dal.UnitMeasure.DeleteOnSubmit(unitmeasureDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

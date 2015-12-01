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

        public List<BillOfMaterial> BillOfMaterialList()
        {
            var getBillOfMaterial = Execute<List<BillOfMaterial>>(dal =>
            {
                var item = dal.BillOfMaterial.Skip(0).Take(100);
                return item.ToList();
            });
            return getBillOfMaterial;
        }

        public List<BillOfMaterial> BillOfMaterialListAll()
        {
            var getBillOfMaterial = Execute<List<BillOfMaterial>>(dal =>
            {
                var item = dal.BillOfMaterial;
                return item.ToList();
            });
            return getBillOfMaterial;
        }

        public bool BillOfMaterialUpdate(BillOfMaterial billofmaterial)
        {
            return Execute<bool>(dal =>
           {
               BillOfMaterial billofmaterialUpdate = dal.BillOfMaterial.Where(x => x.BillOfMaterialsID == billofmaterial.BillOfMaterialsID).FirstOrDefault();
               if (billofmaterialUpdate != null)
               {
                   billofmaterialUpdate.BillOfMaterialsID = billofmaterial.BillOfMaterialsID;
                   billofmaterialUpdate.ProductAssemblyID = billofmaterial.ProductAssemblyID;
                   billofmaterialUpdate.ComponentID = billofmaterial.ComponentID;
                   billofmaterialUpdate.StartDate = billofmaterial.StartDate;
                   billofmaterialUpdate.EndDate = billofmaterial.EndDate;
                   billofmaterialUpdate.UnitMeasureCode = billofmaterial.UnitMeasureCode;
                   billofmaterialUpdate.BOMLevel = billofmaterial.BOMLevel;
                   billofmaterialUpdate.PerAssemblyQty = billofmaterial.PerAssemblyQty;
                   billofmaterialUpdate.ModifiedDate = billofmaterial.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool BillOfMaterialAdd(BillOfMaterial billofmaterial)
        {
            return Execute<bool>(dal =>
            {
                BillOfMaterial billofmaterialAdd = dal.BillOfMaterial.Where(x => x.BillOfMaterialsID == billofmaterial.BillOfMaterialsID).FirstOrDefault();
                if (billofmaterialAdd != null)
                {
                    dal.BillOfMaterial.InsertOnSubmit(billofmaterialAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool BillOfMaterialDelete(BillOfMaterial billofmaterial)
        {
            return Execute<bool>(dal =>
            {
                BillOfMaterial billofmaterialDelete = dal.BillOfMaterial.Where(x => x.BillOfMaterialsID == billofmaterial.BillOfMaterialsID).FirstOrDefault();
                if (billofmaterialDelete != null)
                {
                    dal.BillOfMaterial.DeleteOnSubmit(billofmaterialDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

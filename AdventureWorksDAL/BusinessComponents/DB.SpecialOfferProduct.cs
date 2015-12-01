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

        public List<SpecialOfferProduct> SpecialOfferProductList()
        {
            var getSpecialOfferProduct = Execute<List<SpecialOfferProduct>>(dal =>
            {
                var item = dal.SpecialOfferProduct.Skip(0).Take(100);
                return item.ToList();
            });
            return getSpecialOfferProduct;
        }

        public List<SpecialOfferProduct> SpecialOfferProductListAll()
        {
            var getSpecialOfferProduct = Execute<List<SpecialOfferProduct>>(dal =>
            {
                var item = dal.SpecialOfferProduct;
                return item.ToList();
            });
            return getSpecialOfferProduct;
        }

        public bool SpecialOfferProductUpdate(SpecialOfferProduct specialofferproduct)
        {
            return Execute<bool>(dal =>
            {
                SpecialOfferProduct specialofferproductUpdate = dal.SpecialOfferProduct.Where(x => x.SpecialOfferID == specialofferproduct.SpecialOfferID).FirstOrDefault();
                if (specialofferproductUpdate != null)
                {
                    specialofferproductUpdate.SpecialOfferID = specialofferproduct.SpecialOfferID;
                    specialofferproductUpdate.ProductID = specialofferproduct.ProductID;
                    specialofferproductUpdate.rowguid = specialofferproduct.rowguid;
                    specialofferproductUpdate.ModifiedDate = specialofferproduct.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SpecialOfferProductAdd(SpecialOfferProduct specialofferproduct)
        {
            return Execute<bool>(dal =>
            {
                SpecialOfferProduct specialofferproductAdd = dal.SpecialOfferProduct.Where(x => x.SpecialOfferID == specialofferproduct.SpecialOfferID).FirstOrDefault();
                if (specialofferproductAdd != null)
                {
                    dal.SpecialOfferProduct.InsertOnSubmit(specialofferproductAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SpecialOfferProductDelete(SpecialOfferProduct specialofferproduct)
        {
            return Execute<bool>(dal =>
            {
                SpecialOfferProduct specialofferproductDelete = dal.SpecialOfferProduct.Where(x => x.SpecialOfferID == specialofferproduct.SpecialOfferID).FirstOrDefault();
                if (specialofferproductDelete != null)
                {
                    dal.SpecialOfferProduct.DeleteOnSubmit(specialofferproductDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

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

        public List<SpecialOffer> SpecialOfferList()
        {
            var getSpecialOffer = Execute<List<SpecialOffer>>(dal =>
            {
                var item = dal.SpecialOffer.Skip(0).Take(100);
                return item.ToList();
            });
            return getSpecialOffer;
        }

        public List<SpecialOffer> SpecialOfferListAll()
        {
            var getSpecialOffer = Execute<List<SpecialOffer>>(dal =>
            {
                var item = dal.SpecialOffer;
                return item.ToList();
            });
            return getSpecialOffer;
        }

        public bool SpecialOfferUpdate(SpecialOffer specialoffer)
        {
            return Execute<bool>(dal =>
            {
                SpecialOffer specialofferUpdate = dal.SpecialOffer.Where(x => x.SpecialOfferID == specialoffer.SpecialOfferID).FirstOrDefault();
                if (specialofferUpdate != null)
                {
                    specialofferUpdate.SpecialOfferID = specialoffer.SpecialOfferID;
                    specialofferUpdate.Description = specialoffer.Description;
                    specialofferUpdate.DiscountPct = specialoffer.DiscountPct;
                    specialofferUpdate.Type = specialoffer.Type;
                    specialofferUpdate.Category = specialoffer.Category;
                    specialofferUpdate.StartDate = specialoffer.StartDate;
                    specialofferUpdate.EndDate = specialoffer.EndDate;
                    specialofferUpdate.MinQty = specialoffer.MinQty;
                    specialofferUpdate.MaxQty = specialoffer.MaxQty;
                    specialofferUpdate.rowguid = specialoffer.rowguid;
                    specialofferUpdate.ModifiedDate = specialoffer.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SpecialOfferAdd(SpecialOffer specialoffer)
        {
            return Execute<bool>(dal =>
            {
                SpecialOffer specialofferAdd = dal.SpecialOffer.Where(x => x.SpecialOfferID == specialoffer.SpecialOfferID).FirstOrDefault();
                if (specialofferAdd != null)
                {
                    dal.SpecialOffer.InsertOnSubmit(specialofferAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool SpecialOfferDelete(SpecialOffer specialoffer)
        {
            return Execute<bool>(dal =>
            {
                SpecialOffer specialofferDelete = dal.SpecialOffer.Where(x => x.SpecialOfferID == specialoffer.SpecialOfferID).FirstOrDefault();
                if (specialofferDelete != null)
                {
                    dal.SpecialOffer.DeleteOnSubmit(specialofferDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

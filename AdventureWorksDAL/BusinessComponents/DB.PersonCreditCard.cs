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

        public List<PersonCreditCard> PersonCreditCardList()
        {
            var getPersonCreditCard = Execute<List<PersonCreditCard>>(dal =>
            {
                var item = dal.PersonCreditCard.Skip(0).Take(100);
                return item.ToList();
            });
            return getPersonCreditCard;
        }

        public List<PersonCreditCard> PersonCreditCardListAll()
        {
            var getPersonCreditCard = Execute<List<PersonCreditCard>>(dal =>
            {
                var item = dal.PersonCreditCard;
                return item.ToList();
            });
            return getPersonCreditCard;
        }

        public bool PersonCreditCardUpdate(PersonCreditCard personcreditcard)
        {
             return Execute<bool>(dal =>
            {
                PersonCreditCard personcreditcardUpdate = dal.PersonCreditCard.Where(x => x.BusinessEntityID == personcreditcard.BusinessEntityID).FirstOrDefault();
                if (personcreditcardUpdate != null)
                {
				    personcreditcardUpdate.BusinessEntityID=personcreditcard.BusinessEntityID;
personcreditcardUpdate.CreditCardID=personcreditcard.CreditCardID;
personcreditcardUpdate.ModifiedDate=personcreditcard.ModifiedDate;

                    dal.SubmitChanges();
                    return  true;
                }
                return false;

            });
        }
        public bool PersonCreditCardAdd(PersonCreditCard personcreditcard)
        {
            return Execute<bool>(dal =>
            {
                PersonCreditCard personcreditcardAdd = dal.PersonCreditCard.Where(x => x.BusinessEntityID == personcreditcard.BusinessEntityID).FirstOrDefault();
                if (personcreditcardAdd != null)
                {
                    dal.PersonCreditCard.InsertOnSubmit(personcreditcardAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool PersonCreditCardDelete(PersonCreditCard personcreditcard)
        {
            return Execute<bool>(dal =>
            {
                PersonCreditCard personcreditcardDelete = dal.PersonCreditCard.Where(x => x.BusinessEntityID == personcreditcard.BusinessEntityID).FirstOrDefault();
                if (personcreditcardDelete != null)
                {
                    dal.PersonCreditCard.DeleteOnSubmit(personcreditcardDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

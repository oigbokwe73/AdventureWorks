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

        public List<CreditCard> CreditCardList()
        {
            var getCreditCard = Execute<List<CreditCard>>(dal =>
            {
                var item = dal.CreditCard.Skip(0).Take(100);
                return item.ToList();
            });
            return getCreditCard;
        }

        public List<CreditCard> CreditCardListAll()
        {
            var getCreditCard = Execute<List<CreditCard>>(dal =>
            {
                var item = dal.CreditCard;
                return item.ToList();
            });
            return getCreditCard;
        }

        public bool CreditCardUpdate(CreditCard creditcard)
        {
            return Execute<bool>(dal =>
           {
               CreditCard creditcardUpdate = dal.CreditCard.Where(x => x.CreditCardID == creditcard.CreditCardID).FirstOrDefault();
               if (creditcardUpdate != null)
               {
                   creditcardUpdate.CreditCardID = creditcard.CreditCardID;
                   creditcardUpdate.CardType = creditcard.CardType;
                   creditcardUpdate.CardNumber = creditcard.CardNumber;
                   creditcardUpdate.ExpMonth = creditcard.ExpMonth;
                   creditcardUpdate.ExpYear = creditcard.ExpYear;
                   creditcardUpdate.ModifiedDate = creditcard.ModifiedDate;
                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool CreditCardAdd(CreditCard creditcard)
        {
            return Execute<bool>(dal =>
            {
                CreditCard creditcardAdd = dal.CreditCard.Where(x => x.CreditCardID == creditcard.CreditCardID).FirstOrDefault();
                if (creditcardAdd != null)
                {
                    dal.CreditCard.InsertOnSubmit(creditcardAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool CreditCardDelete(CreditCard creditcard)
        {
            return Execute<bool>(dal =>
            {
                CreditCard creditcardDelete = dal.CreditCard.Where(x => x.CreditCardID == creditcard.CreditCardID).FirstOrDefault();
                if (creditcardDelete != null)
                {
                    dal.CreditCard.DeleteOnSubmit(creditcardDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

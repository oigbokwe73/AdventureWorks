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

        public List<ShoppingCartItem> ShoppingCartItemList()
        {
            var getShoppingCartItem = Execute<List<ShoppingCartItem>>(dal =>
            {
                var item = dal.ShoppingCartItem.Skip(0).Take(100);
                return item.ToList();
            });
            return getShoppingCartItem;
        }

        public List<ShoppingCartItem> ShoppingCartItemListAll()
        {
            var getShoppingCartItem = Execute<List<ShoppingCartItem>>(dal =>
            {
                var item = dal.ShoppingCartItem;
                return item.ToList();
            });
            return getShoppingCartItem;
        }

        public bool ShoppingCartItemUpdate(ShoppingCartItem shoppingcartitem)
        {
            return Execute<bool>(dal =>
           {
               ShoppingCartItem shoppingcartitemUpdate = dal.ShoppingCartItem.Where(x => x.ShoppingCartItemID == shoppingcartitem.ShoppingCartItemID).FirstOrDefault();
               if (shoppingcartitemUpdate != null)
               {
                   shoppingcartitemUpdate.ShoppingCartItemID = shoppingcartitem.ShoppingCartItemID;
                   shoppingcartitemUpdate.ShoppingCartID = shoppingcartitem.ShoppingCartID;
                   shoppingcartitemUpdate.Quantity = shoppingcartitem.Quantity;
                   shoppingcartitemUpdate.ProductID = shoppingcartitem.ProductID;
                   shoppingcartitemUpdate.DateCreated = shoppingcartitem.DateCreated;
                   shoppingcartitemUpdate.ModifiedDate = shoppingcartitem.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool ShoppingCartItemAdd(ShoppingCartItem shoppingcartitem)
        {
            return Execute<bool>(dal =>
            {
                ShoppingCartItem shoppingcartitemAdd = dal.ShoppingCartItem.Where(x => x.ShoppingCartItemID == shoppingcartitem.ShoppingCartItemID).FirstOrDefault();
                if (shoppingcartitemAdd != null)
                {
                    dal.ShoppingCartItem.InsertOnSubmit(shoppingcartitemAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ShoppingCartItemDelete(ShoppingCartItem shoppingcartitem)
        {
            return Execute<bool>(dal =>
            {
                ShoppingCartItem shoppingcartitemDelete = dal.ShoppingCartItem.Where(x => x.ShoppingCartItemID == shoppingcartitem.ShoppingCartItemID).FirstOrDefault();
                if (shoppingcartitemDelete != null)
                {
                    dal.ShoppingCartItem.DeleteOnSubmit(shoppingcartitemDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

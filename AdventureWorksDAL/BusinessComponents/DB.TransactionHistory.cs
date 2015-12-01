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

        public List<TransactionHistory> TransactionHistoryList()
        {
            var getTransactionHistory = Execute<List<TransactionHistory>>(dal =>
            {
                var item = dal.TransactionHistory.Skip(0).Take(100);
                return item.ToList();
            });
            return getTransactionHistory;
        }

        public List<TransactionHistory> TransactionHistoryListAll()
        {
            var getTransactionHistory = Execute<List<TransactionHistory>>(dal =>
            {
                var item = dal.TransactionHistory;
                return item.ToList();
            });
            return getTransactionHistory;
        }

        public bool TransactionHistoryUpdate(TransactionHistory transactionhistory)
        {
            return Execute<bool>(dal =>
            {
                TransactionHistory transactionhistoryUpdate = dal.TransactionHistory.Where(x => x.TransactionID == transactionhistory.TransactionID).FirstOrDefault();
                if (transactionhistoryUpdate != null)
                {
                    transactionhistoryUpdate.TransactionID = transactionhistory.TransactionID;
                    transactionhistoryUpdate.ProductID = transactionhistory.ProductID;
                    transactionhistoryUpdate.ReferenceOrderID = transactionhistory.ReferenceOrderID;
                    transactionhistoryUpdate.ReferenceOrderLineID = transactionhistory.ReferenceOrderLineID;
                    transactionhistoryUpdate.TransactionDate = transactionhistory.TransactionDate;
                    transactionhistoryUpdate.TransactionType = transactionhistory.TransactionType;
                    transactionhistoryUpdate.Quantity = transactionhistory.Quantity;
                    transactionhistoryUpdate.ActualCost = transactionhistory.ActualCost;
                    transactionhistoryUpdate.ModifiedDate = transactionhistory.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool TransactionHistoryAdd(TransactionHistory transactionhistory)
        {
            return Execute<bool>(dal =>
            {
                TransactionHistory transactionhistoryAdd = dal.TransactionHistory.Where(x => x.TransactionID == transactionhistory.TransactionID).FirstOrDefault();
                if (transactionhistoryAdd != null)
                {
                    dal.TransactionHistory.InsertOnSubmit(transactionhistoryAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool TransactionHistoryDelete(TransactionHistory transactionhistory)
        {
            return Execute<bool>(dal =>
            {
                TransactionHistory transactionhistoryDelete = dal.TransactionHistory.Where(x => x.TransactionID == transactionhistory.TransactionID).FirstOrDefault();
                if (transactionhistoryDelete != null)
                {
                    dal.TransactionHistory.DeleteOnSubmit(transactionhistoryDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

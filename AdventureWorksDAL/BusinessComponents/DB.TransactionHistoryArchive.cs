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

        public List<TransactionHistoryArchive> TransactionHistoryArchiveList()
        {
            var getTransactionHistoryArchive = Execute<List<TransactionHistoryArchive>>(dal =>
            {
                var item = dal.TransactionHistoryArchive.Skip(0).Take(100);
                return item.ToList();
            });
            return getTransactionHistoryArchive;
        }

        public List<TransactionHistoryArchive> TransactionHistoryArchiveListAll()
        {
            var getTransactionHistoryArchive = Execute<List<TransactionHistoryArchive>>(dal =>
            {
                var item = dal.TransactionHistoryArchive;
                return item.ToList();
            });
            return getTransactionHistoryArchive;
        }

        public bool TransactionHistoryArchiveUpdate(TransactionHistoryArchive transactionhistoryarchive)
        {
            return Execute<bool>(dal =>
            {
                TransactionHistoryArchive transactionhistoryarchiveUpdate = dal.TransactionHistoryArchive.Where(x => x.TransactionID == transactionhistoryarchive.TransactionID).FirstOrDefault();
                if (transactionhistoryarchiveUpdate != null)
                {
                    transactionhistoryarchiveUpdate.TransactionID = transactionhistoryarchive.TransactionID;
                    transactionhistoryarchiveUpdate.ProductID = transactionhistoryarchive.ProductID;
                    transactionhistoryarchiveUpdate.ReferenceOrderID = transactionhistoryarchive.ReferenceOrderID;
                    transactionhistoryarchiveUpdate.ReferenceOrderLineID = transactionhistoryarchive.ReferenceOrderLineID;
                    transactionhistoryarchiveUpdate.TransactionDate = transactionhistoryarchive.TransactionDate;
                    transactionhistoryarchiveUpdate.TransactionType = transactionhistoryarchive.TransactionType;
                    transactionhistoryarchiveUpdate.Quantity = transactionhistoryarchive.Quantity;
                    transactionhistoryarchiveUpdate.ActualCost = transactionhistoryarchive.ActualCost;
                    transactionhistoryarchiveUpdate.ModifiedDate = transactionhistoryarchive.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool TransactionHistoryArchiveAdd(TransactionHistoryArchive transactionhistoryarchive)
        {
            return Execute<bool>(dal =>
            {
                TransactionHistoryArchive transactionhistoryarchiveAdd = dal.TransactionHistoryArchive.Where(x => x.TransactionID == transactionhistoryarchive.TransactionID).FirstOrDefault();
                if (transactionhistoryarchiveAdd != null)
                {
                    dal.TransactionHistoryArchive.InsertOnSubmit(transactionhistoryarchiveAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool TransactionHistoryArchiveDelete(TransactionHistoryArchive transactionhistoryarchive)
        {
            return Execute<bool>(dal =>
            {
                TransactionHistoryArchive transactionhistoryarchiveDelete = dal.TransactionHistoryArchive.Where(x => x.TransactionID == transactionhistoryarchive.TransactionID).FirstOrDefault();
                if (transactionhistoryarchiveDelete != null)
                {
                    dal.TransactionHistoryArchive.DeleteOnSubmit(transactionhistoryarchiveDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

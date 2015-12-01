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

        public List<WorkOrder> WorkOrderList()
        {
            var getWorkOrder = Execute<List<WorkOrder>>(dal =>
            {
                var item = dal.WorkOrder.Skip(0).Take(100);
                return item.ToList();
            });
            return getWorkOrder;
        }

        public List<WorkOrder> WorkOrderListAll()
        {
            var getWorkOrder = Execute<List<WorkOrder>>(dal =>
            {
                var item = dal.WorkOrder;
                return item.ToList();
            });
            return getWorkOrder;
        }

        public bool WorkOrderUpdate(WorkOrder workorder)
        {
            return Execute<bool>(dal =>
            {
                WorkOrder workorderUpdate = dal.WorkOrder.Where(x => x.WorkOrderID == workorder.WorkOrderID).FirstOrDefault();
                if (workorderUpdate != null)
                {
                    workorderUpdate.WorkOrderID = workorder.WorkOrderID;
                    workorderUpdate.ProductID = workorder.ProductID;
                    workorderUpdate.OrderQty = workorder.OrderQty;
                    workorderUpdate.StockedQty = workorder.StockedQty;
                    workorderUpdate.ScrappedQty = workorder.ScrappedQty;
                    workorderUpdate.StartDate = workorder.StartDate;
                    workorderUpdate.EndDate = workorder.EndDate;
                    workorderUpdate.DueDate = workorder.DueDate;
                    workorderUpdate.ScrapReasonID = workorder.ScrapReasonID;
                    workorderUpdate.ModifiedDate = workorder.ModifiedDate;

                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool WorkOrderAdd(WorkOrder workorder)
        {
            return Execute<bool>(dal =>
            {
                WorkOrder workorderAdd = dal.WorkOrder.Where(x => x.WorkOrderID == workorder.WorkOrderID).FirstOrDefault();
                if (workorderAdd != null)
                {
                    dal.WorkOrder.InsertOnSubmit(workorderAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool WorkOrderDelete(WorkOrder workorder)
        {
            return Execute<bool>(dal =>
            {
                WorkOrder workorderDelete = dal.WorkOrder.Where(x => x.WorkOrderID == workorder.WorkOrderID).FirstOrDefault();
                if (workorderDelete != null)
                {
                    dal.WorkOrder.DeleteOnSubmit(workorderDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }

    }
}

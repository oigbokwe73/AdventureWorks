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

        public List<WorkOrderRouting> WorkOrderRoutingList()
        {
            var getWorkOrderRouting = Execute<List<WorkOrderRouting>>(dal =>
            {
                var item = dal.WorkOrderRouting.Skip(0).Take(100);
                return item.ToList();
            });
            return getWorkOrderRouting;
        }

        public List<WorkOrderRouting> WorkOrderRoutingListAll()
        {
            var getWorkOrderRouting = Execute<List<WorkOrderRouting>>(dal =>
            {
                var item = dal.WorkOrderRouting;
                return item.ToList();
            });
            return getWorkOrderRouting;
        }

        public bool WorkOrderRoutingUpdate(WorkOrderRouting workorderrouting)
        {
            return Execute<bool>(dal =>
           {
               WorkOrderRouting workorderroutingUpdate = dal.WorkOrderRouting.Where(x => x.WorkOrderID == workorderrouting.WorkOrderID).FirstOrDefault();
               if (workorderroutingUpdate != null)
               {
                   workorderroutingUpdate.WorkOrderID = workorderrouting.WorkOrderID;
                   workorderroutingUpdate.ProductID = workorderrouting.ProductID;
                   workorderroutingUpdate.OperationSequence = workorderrouting.OperationSequence;
                   workorderroutingUpdate.LocationID = workorderrouting.LocationID;
                   workorderroutingUpdate.ScheduledStartDate = workorderrouting.ScheduledStartDate;
                   workorderroutingUpdate.ScheduledEndDate = workorderrouting.ScheduledEndDate;
                   workorderroutingUpdate.ActualStartDate = workorderrouting.ActualStartDate;
                   workorderroutingUpdate.ActualEndDate = workorderrouting.ActualEndDate;
                   workorderroutingUpdate.ActualResourceHrs = workorderrouting.ActualResourceHrs;
                   workorderroutingUpdate.PlannedCost = workorderrouting.PlannedCost;
                   workorderroutingUpdate.ActualCost = workorderrouting.ActualCost;
                   workorderroutingUpdate.ModifiedDate = workorderrouting.ModifiedDate;
                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool WorkOrderRoutingAdd(WorkOrderRouting workorderrouting)
        {
            return Execute<bool>(dal =>
            {
                WorkOrderRouting workorderroutingAdd = dal.WorkOrderRouting.Where(x => x.WorkOrderID == workorderrouting.WorkOrderID).FirstOrDefault();
                if (workorderroutingAdd != null)
                {
                    dal.WorkOrderRouting.InsertOnSubmit(workorderroutingAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool WorkOrderRoutingDelete(WorkOrderRouting workorderrouting)
        {
            return Execute<bool>(dal =>
            {
                WorkOrderRouting workorderroutingDelete = dal.WorkOrderRouting.Where(x => x.WorkOrderID == workorderrouting.WorkOrderID).FirstOrDefault();
                if (workorderroutingDelete != null)
                {
                    dal.WorkOrderRouting.DeleteOnSubmit(workorderroutingDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

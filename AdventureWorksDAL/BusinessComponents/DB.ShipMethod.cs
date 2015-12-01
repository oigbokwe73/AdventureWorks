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

        public List<ShipMethod> ShipMethodList()
        {
            var getShipMethod = Execute<List<ShipMethod>>(dal =>
            {
                var item = dal.ShipMethod.Skip(0).Take(100);
                return item.ToList();
            });
            return getShipMethod;
        }

        public List<ShipMethod> ShipMethodListAll()
        {
            var getShipMethod = Execute<List<ShipMethod>>(dal =>
            {
                var item = dal.ShipMethod;
                return item.ToList();
            });
            return getShipMethod;
        }

        public bool ShipMethodUpdate(ShipMethod shipmethod)
        {
            return Execute<bool>(dal =>
           {
               ShipMethod shipmethodUpdate = dal.ShipMethod.Where(x => x.ShipMethodID == shipmethod.ShipMethodID).FirstOrDefault();
               if (shipmethodUpdate != null)
               {
                   shipmethodUpdate.ShipMethodID = shipmethod.ShipMethodID;
                   shipmethodUpdate.Name = shipmethod.Name;
                   shipmethodUpdate.ShipBase = shipmethod.ShipBase;
                   shipmethodUpdate.ShipRate = shipmethod.ShipRate;
                   shipmethodUpdate.rowguid = shipmethod.rowguid;
                   shipmethodUpdate.ModifiedDate = shipmethod.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool ShipMethodAdd(ShipMethod shipmethod)
        {
            return Execute<bool>(dal =>
            {
                ShipMethod shipmethodAdd = dal.ShipMethod.Where(x => x.ShipMethodID == shipmethod.ShipMethodID).FirstOrDefault();
                if (shipmethodAdd != null)
                {
                    dal.ShipMethod.InsertOnSubmit(shipmethodAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool ShipMethodDelete(ShipMethod shipmethod)
        {
            return Execute<bool>(dal =>
            {
                ShipMethod shipmethodDelete = dal.ShipMethod.Where(x => x.ShipMethodID == shipmethod.ShipMethodID).FirstOrDefault();
                if (shipmethodDelete != null)
                {
                    dal.ShipMethod.DeleteOnSubmit(shipmethodDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

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

        public List<Location> LocationList()
        {
            var getLocation = Execute<List<Location>>(dal =>
            {
                var item = dal.Location.Skip(0).Take(100);
                return item.ToList();
            });
            return getLocation;
        }

        public List<Location> LocationListAll()
        {
            var getLocation = Execute<List<Location>>(dal =>
            {
                var item = dal.Location;
                return item.ToList();
            });
            return getLocation;
        }

        public bool LocationUpdate(Location location)
        {
            return Execute<bool>(dal =>
           {
               Location locationUpdate = dal.Location.Where(x => x.LocationID == location.LocationID).FirstOrDefault();
               if (locationUpdate != null)
               {
                   locationUpdate.LocationID = location.LocationID;
                   locationUpdate.Name = location.Name;
                   locationUpdate.CostRate = location.CostRate;
                   locationUpdate.Availability = location.Availability;
                   locationUpdate.ModifiedDate = location.ModifiedDate;

                   dal.SubmitChanges();
                   return true;
               }
               return false;

           });
        }
        public bool LocationAdd(Location location)
        {
            return Execute<bool>(dal =>
            {
                Location locationAdd = dal.Location.Where(x => x.LocationID == location.LocationID).FirstOrDefault();
                if (locationAdd != null)
                {
                    dal.Location.InsertOnSubmit(locationAdd);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
        public bool LocationDelete(Location location)
        {
            return Execute<bool>(dal =>
            {
                Location locationDelete = dal.Location.Where(x => x.LocationID == location.LocationID).FirstOrDefault();
                if (locationDelete != null)
                {
                    dal.Location.DeleteOnSubmit(locationDelete);
                    dal.SubmitChanges();
                    return true;
                }
                return false;

            });
        }
 
    }
}

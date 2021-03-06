using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdventureWorks.StoreFront;

namespace AdventureWorks.Controllers
{
    public class EmployeeDepartmentHistoryController : ApiController
    {
		StoreServiceClient adventureWorks_BC = new StoreServiceClient();
        // GET api/awbuildversion
        public EmployeeDepartmentHistory[] Get()
        {
            return adventureWorks_BC.EmployeeDepartmentHistoryList();
        }

        // GET api/awbuildversion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/awbuildversion
        public void Post(EmployeeDepartmentHistory value)
        {
            adventureWorks_BC.EmployeeDepartmentHistoryAdd(value);
        }

        // PUT api/awbuildversion/5
        public void Put(EmployeeDepartmentHistory value)
        {
            var GetActionType = Request.Headers.Where(x => x.Key.Equals("ActionType")).FirstOrDefault();

            if (GetActionType.Key != null)
            {
                if (GetActionType.Value.ToList()[0].Equals("DELETE"))
                    adventureWorks_BC.EmployeeDepartmentHistoryDelete(value);
                if (GetActionType.Value.ToList()[0].Equals("UPDATE"))
                    adventureWorks_BC.EmployeeDepartmentHistoryUpdate(value);
            }
        }
       
    }
}

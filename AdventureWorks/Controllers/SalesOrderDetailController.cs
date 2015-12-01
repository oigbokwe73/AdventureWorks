using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdventureWorks.StoreFront;

namespace AdventureWorks.Controllers
{
    public class SalesOrderDetailController : ApiController
    {
		StoreServiceClient adventureWorks_BC = new StoreServiceClient();
        // GET api/awbuildversion
        public SalesOrderDetail[] Get()
        {
            return adventureWorks_BC.SalesOrderDetailList();
        }

        // GET api/awbuildversion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/awbuildversion
        public void Post(SalesOrderDetail value)
        {
            adventureWorks_BC.SalesOrderDetailAdd(value);
        }

        // PUT api/awbuildversion/5
        public void Put(SalesOrderDetail value)
        {
            var GetActionType = Request.Headers.Where(x => x.Key.Equals("ActionType")).FirstOrDefault();

            if (GetActionType.Key != null)
            {
                if (GetActionType.Value.ToList()[0].Equals("DELETE"))
                    adventureWorks_BC.SalesOrderDetailDelete(value);
                if (GetActionType.Value.ToList()[0].Equals("UPDATE"))
                    adventureWorks_BC.SalesOrderDetailUpdate(value);
            }
        }
       
    }
}

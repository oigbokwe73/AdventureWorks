using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdventureWorks.StoreFront;

namespace AdventureWorks.Controllers
{
    public class PurchaseOrderHeaderController : ApiController
    {
		StoreServiceClient adventureWorks_BC = new StoreServiceClient();
        // GET api/awbuildversion
        public PurchaseOrderHeader[] Get()
        {
            return adventureWorks_BC.PurchaseOrderHeaderList();
        }

        // GET api/awbuildversion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/awbuildversion
        public void Post(PurchaseOrderHeader value)
        {
            adventureWorks_BC.PurchaseOrderHeaderAdd(value);
        }

        // PUT api/awbuildversion/5
        public void Put(PurchaseOrderHeader value)
        {
            var GetActionType = Request.Headers.Where(x => x.Key.Equals("ActionType")).FirstOrDefault();

            if (GetActionType.Key != null)
            {
                if (GetActionType.Value.ToList()[0].Equals("DELETE"))
                    adventureWorks_BC.PurchaseOrderHeaderDelete(value);
                if (GetActionType.Value.ToList()[0].Equals("UPDATE"))
                    adventureWorks_BC.PurchaseOrderHeaderUpdate(value);
            }
        }
       
    }
}

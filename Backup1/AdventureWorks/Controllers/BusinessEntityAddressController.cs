using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdventureWorks.StoreFront;

namespace AdventureWorks.Controllers
{
    public class BusinessEntityAddressController : ApiController
    {
		StoreServiceClient adventureWorks_BC = new StoreServiceClient();
        // GET api/awbuildversion
        public BusinessEntityAddress[] Get()
        {
            return adventureWorks_BC.BusinessEntityAddressList();
        }

        // GET api/awbuildversion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/awbuildversion
        public void Post(BusinessEntityAddress value)
        {
            adventureWorks_BC.BusinessEntityAddressAdd(value);
        }

        // PUT api/awbuildversion/5
        public void Put(BusinessEntityAddress value)
        {
            var GetActionType = Request.Headers.Where(x => x.Key.Equals("ActionType")).FirstOrDefault();

            if (GetActionType.Key != null)
            {
                if (GetActionType.Value.ToList()[0].Equals("DELETE"))
                    adventureWorks_BC.BusinessEntityAddressDelete(value);
                if (GetActionType.Value.ToList()[0].Equals("UPDATE"))
                    adventureWorks_BC.BusinessEntityAddressUpdate(value);
            }
        }
       
    }
}

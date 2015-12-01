using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdventureWorks.StoreFront;

namespace AdventureWorks.Controllers
{
    public class ProductController : ApiController
    {
		StoreServiceClient adventureWorks_BC = new StoreServiceClient();
        // GET api/awbuildversion
        public Product[] Get()
        {
            return adventureWorks_BC.ProductListAll();
        }

        // GET api/awbuildversion/5
        public Product[] Get(int id)
        {
            return adventureWorks_BC.ProductListAll().Where(x => x.ProductID == id).ToArray();
        }

        // POST api/awbuildversion
        public void Post(Product value)
        {
            adventureWorks_BC.ProductAdd(value);
        }

        // PUT api/awbuildversion/5
        public void Put(Product value)
        {
            var GetActionType = Request.Headers.Where(x => x.Key.Equals("ActionType")).FirstOrDefault();

            if (GetActionType.Key != null)
            {
                if (GetActionType.Value.ToList()[0].Equals("DELETE"))
                    adventureWorks_BC.ProductDelete(value);
                if (GetActionType.Value.ToList()[0].Equals("UPDATE"))
                    adventureWorks_BC.ProductUpdate(value);
            }
        }
       
    }
}

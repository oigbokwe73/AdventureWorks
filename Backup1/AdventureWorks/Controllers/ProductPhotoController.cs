using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdventureWorks.StoreFront;

namespace AdventureWorks.Controllers
{
    public class ProductPhotoController : ApiController
    {
		StoreServiceClient adventureWorks_BC = new StoreServiceClient();
        // GET api/awbuildversion
        public ProductPhoto[] Get()
        {
            return adventureWorks_BC.ProductPhotoListAll().Where(x=> !x.ThumbnailPhotoFileName.Equals("no_image_available_small.gif")).ToArray();
        }

        // GET api/awbuildversion/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/awbuildversion
        public void Post(ProductPhoto value)
        {
            adventureWorks_BC.ProductPhotoAdd(value);
        }

        // PUT api/awbuildversion/5
        public void Put(ProductPhoto value)
        {
            var GetActionType = Request.Headers.Where(x => x.Key.Equals("ActionType")).FirstOrDefault();

            if (GetActionType.Key != null)
            {
                if (GetActionType.Value.ToList()[0].Equals("DELETE"))
                    adventureWorks_BC.ProductPhotoDelete(value);
                if (GetActionType.Value.ToList()[0].Equals("UPDATE"))
                    adventureWorks_BC.ProductPhotoUpdate(value);
            }
        }
       
    }
}

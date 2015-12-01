using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdventureWorksDAL.DataContext;
using System.Configuration;

namespace AdventureWorksDAL.BusinessComponents
{
    public partial class AdventureWorksDataContext : BaseContext
    {
        public AdventureWorksDataContext()
        {
             Initialize(ConfigurationManager.AppSettings["AdventureWorksConnectionString"]); 
                                                           
        }


    }   
}

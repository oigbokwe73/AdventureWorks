using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorksDAL
{
    public partial class SpecialOffer
    {
        public int SpecialOfferID { get; set; }
        public string  Description { get; set; }
        public decimal DiscountPct { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? MinQty { get; set; }
        public int? MaxQty { get; set; }
    }
}
    
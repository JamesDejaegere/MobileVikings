using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MV.WebApi.JsonObject
{
    public class Price_Plan_Details
    {
        public List<Price_Plan_Price> prices { get; set; }
        public List<Price_Plan_Bundle> bundles { get; set; }
        public string name { get; set; }
        public string top_up_amount { get; set; }
    }
}

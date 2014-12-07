using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MV.WebApi.JsonObject
{
    public class Sim_Balance_Bundle
    {
        public string valid_until { get; set; }
        public string valid_from { get; set; }
        public int value { get; set; }
        public int assigned { get; set; }
        public string used { get; set; }
        public string type { get; set; }
    }
}

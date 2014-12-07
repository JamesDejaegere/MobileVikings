using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MV.WebApi.JsonObject
{
    public class Sim_Balance
    {
        public string valid_until { get; set; }
        public int sms { get; set; }
        public int sms_super_on_net_max { get; set; }
        public int voice_super_on_net { get; set; }
        public string credits { get; set; }
        public List<Sim_Balance_Bundle> bundles { get; set; }
        public bool is_expired { get; set; }
        public int sms_super_on_net { get; set; }
        public int voice_super_on_net_max { get; set; }
        public int data { get; set; }
    }
}

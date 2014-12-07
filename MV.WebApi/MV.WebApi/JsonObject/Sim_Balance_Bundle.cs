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

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("type:\t" + this.type);
            sb.AppendLine("valid_from:\t" + this.valid_from);
            sb.AppendLine("valid_until:\t" + this.valid_until);
            sb.AppendLine("assigned:\t" + this.assigned);
            sb.AppendLine("value:\t" + this.value);
            sb.AppendLine("used:\t" + this.used);
            return sb.ToString();
        }
    }
}

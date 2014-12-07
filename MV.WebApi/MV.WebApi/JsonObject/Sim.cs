using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MV.WebApi.JsonObject
{
    public class Sim
    {
        public string msisdn { get; set; }
        public string alias { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.alias + " :: " + this.msisdn);
            return sb.ToString();
        }
    }
}

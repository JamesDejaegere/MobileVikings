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

        public string CreditVolume
        {
            get
            {
                return credits + " €";
            }
        }
        public string DataVolume
        {
            get
            {
                double value = data;
                Int16 exp = 0;
                string unit = string.Empty;
                while (value > 1024)
                {
                    exp += 1;
                    value /= 1024;
                }
                switch (exp)
                {
                    case 1:
                        unit = "KB";
                        break;
                    case 2:
                        unit = "MB";
                        break;
                    case 3:
                        unit = "GB";
                        break;
                    case 4:
                        unit = "TB";
                        break;
                    case 5:
                        unit = "PB";
                        break;
                    default:
                        break;
                }
                return value.ToString("000.00") + " " + unit;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("valid until:\t" + this.valid_until);
            sb.AppendLine("sms:\t" + this.sms);
            sb.AppendLine("sms_super_on_net_max:\t" + this.sms_super_on_net_max);
            sb.AppendLine("voice_super_on_net:\t" + this.voice_super_on_net);
            sb.AppendLine("credits:\t" + this.CreditVolume);
            sb.AppendLine("is_expired:\t" + this.is_expired);
            sb.AppendLine("sms_super_on_net:\t" + this.sms_super_on_net);
            sb.AppendLine("voice_super_on_net_max:\t" + this.voice_super_on_net_max);
            sb.AppendLine("data:\t" + this.DataVolume);
            sb.AppendLine("bundles:\t" + this.bundles.Count);
            foreach (var bundle in this.bundles)
            {
                sb.AppendLine("\t" + bundle);
            }
            return sb.ToString();
        }
    }
}

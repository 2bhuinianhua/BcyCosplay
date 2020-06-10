using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class AtUserInfo
    {
        [JsonProperty("at_uname")]
        public string AtUname { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("uname")]
        public string Uname { get; set; }
    }
}

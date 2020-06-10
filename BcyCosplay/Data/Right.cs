using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class Right
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("rid")]
        public long Rid { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("type")]
        public long Type { get; set; }

        [JsonProperty("expire_time")]
        public long ExpireTime { get; set; }

        [JsonProperty("extra")]
        public Uri Extra { get; set; }

        [JsonProperty("status")]
        public long Status { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("own")]
        public bool Own { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class TopListItemInfoTopListDetail
    {
        [JsonProperty("ttype_set")]
        public TypeSet TtypeSet { get; set; }

        [JsonProperty("sub_type_set")]
        public TypeSet SubTypeSet { get; set; }

        [JsonProperty("stime")]
        public long Stime { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("wave", NullValueHandling = NullValueHandling.Ignore)]
        public string Wave { get; set; }
    }
}

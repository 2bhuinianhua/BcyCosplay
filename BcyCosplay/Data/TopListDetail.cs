using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class TopListDetail
    {
        [JsonProperty("rank")]
        public long Rank { get; set; }

        [JsonProperty("top_list_name")]
        public string TopListName { get; set; }

        [JsonProperty("bcy_url")]
        public string BcyUrl { get; set; }
    }
}

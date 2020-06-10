using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class TopListItemInfoItem
    {
        [JsonProperty("tl_type")]
        public TlType TlType { get; set; }

        [JsonProperty("since")]
        public string Since { get; set; }

        [JsonProperty("item_detail")]
        public ItemDetail ItemDetail { get; set; }

        [JsonProperty("top_list_detail")]
        public TopListItemInfoTopListDetail TopListDetail { get; set; }
    }
}

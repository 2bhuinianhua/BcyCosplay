using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class TopListItemInfoData
    {
        [JsonProperty("top_list_item_info")]
        public TopListItemInfoItem[] TopListItemInfo { get; set; }
    }
}

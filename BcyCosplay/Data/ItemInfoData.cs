using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class ItemInfoData
    {
        [JsonProperty("item_info")]
        public Item[] ItemInfo { get; set; }
    }
}

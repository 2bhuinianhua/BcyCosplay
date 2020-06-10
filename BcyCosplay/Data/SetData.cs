using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class SetData
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("set_post_prev")]
        public string SetPostPrev { get; set; }

        [JsonProperty("set_post_next")]
        public IntString SetPostNext { get; set; }

        [JsonProperty("post_pos")]
        public long PostPos { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("subscribed")]
        public bool Subscribed { get; set; }

        [JsonProperty("subscribe_num")]
        public long SubscribeNum { get; set; }

        [JsonProperty("item_set_id")]
        public long ItemSetId { get; set; }
    }
}

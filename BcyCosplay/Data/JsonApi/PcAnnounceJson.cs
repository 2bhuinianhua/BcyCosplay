using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class PcAnnounceJson
    {
        [JsonProperty("atype")]
        public long Atype { get; set; }

        [JsonProperty("aid")]
        public long Aid { get; set; }

        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("ctime")]
        public long Ctime { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("readStatus")]
        public long ReadStatus { get; set; }

        public static PcAnnounceJson[] FromJson(string json) => JsonConvert.DeserializeObject<PcAnnounceJson[]>(json, BcyJsonConverter.Settings);
    }
}

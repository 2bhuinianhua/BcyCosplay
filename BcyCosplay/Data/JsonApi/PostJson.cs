using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class PostJson
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public ItemsCountData Data { get; set; }

        public static PostJson FromJson(string json) => JsonConvert.DeserializeObject<PostJson>(json, BcyJsonConverter.Settings);
    }
}

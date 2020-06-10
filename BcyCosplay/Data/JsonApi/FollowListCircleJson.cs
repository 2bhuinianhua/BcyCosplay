using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class FollowListCircleJson
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public UserFollowCirclesData Data { get; set; }

        public static FollowListCircleJson FromJson(string json) => JsonConvert.DeserializeObject<FollowListCircleJson>(json, BcyJsonConverter.Settings);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class FavorJson
    {
        [JsonProperty("data")]
        public ListData Data { get; set; }

        [JsonProperty("code")]
        public long Code { get; set; }

        public static FavorJson FromJson(string json) => JsonConvert.DeserializeObject<FavorJson>(json, BcyJsonConverter.Settings);

    }
}

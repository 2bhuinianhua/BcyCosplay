using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class GetMyCollectionListJson
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public CollectionsData Data { get; set; }

        public static GetMyCollectionListJson FromJson(string json) => JsonConvert.DeserializeObject<GetMyCollectionListJson>(json, BcyJsonConverter.Settings);
    }
}

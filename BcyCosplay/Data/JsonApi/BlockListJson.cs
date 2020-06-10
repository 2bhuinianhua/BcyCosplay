using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class BlockListJson
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public UserHashData Data { get; set; }

        public static BlockListJson FromJson(string json) => JsonConvert.DeserializeObject<BlockListJson>(json, BcyJsonConverter.Settings);

        public static async Task<BlockListJson> get(string uid, int page)
        {
            var s = await bcy.blockList(uid, page);
            return FromJson(s);
        }

        public static async Task<BlockListJson> getAll(string uid)
        {
            int page = 1;

            string s = await bcy.blockList(uid, page++);
            var r = FromJson(s);

            s = await bcy.blockList(uid, page++);
            while (s.Length > bcy.noneLen)
            {
                r.Data.UserHash = r.Data.UserHash.Union(FromJson(s).Data.UserHash).ToArray();
                s = await bcy.blockList(uid, page++);
            }
            return r;
        }
    }
}

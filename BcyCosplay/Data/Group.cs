using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class Group
    {
        [JsonProperty("gid")]
        public long Gid { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("post_num")]
        public long PostNum { get; set; }

        [JsonProperty("member_num")]
        public long MemberNum { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public partial class User
    {
        [JsonProperty("uid")]
        public long Uid { get; set; }
    }
    public partial class User
    {
        [JsonProperty("uname")]
        public string Uname { get; set; }

        [JsonProperty("following")]
        public long Following { get; set; }

        [JsonProperty("follower")]
        public long Follower { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }
    }
}

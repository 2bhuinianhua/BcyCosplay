using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class UserFollowInfo
    {
        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("uname")]
        public string Uname { get; set; }

        [JsonProperty("avatar")]
        public Uri Avatar { get; set; }

        [JsonProperty("value_user")]
        public long ValueUser { get; set; }

        [JsonProperty("vu_description")]
        public string VuDescription { get; set; }

        [JsonProperty("utags")]
        public string[] Utags { get; set; }

        [JsonProperty("follow_state")]
        public FollowState FollowState { get; set; }

        [JsonProperty("rights")]
        public Right[] Rights { get; set; }

        [JsonProperty("self_intro")]
        public string SelfIntro { get; set; }
    }
}

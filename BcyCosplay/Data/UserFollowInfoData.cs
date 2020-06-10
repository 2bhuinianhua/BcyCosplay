using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class UserFollowInfoData
    {
        [JsonProperty("user_follow_info")]
        public UserFollowInfo[] UserFollowInfo { get; set; }
    }
}

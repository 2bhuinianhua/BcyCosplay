using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public partial class UserFollowCirclesData
    {
        [JsonProperty("user_follow_circles")]
        public UserFollowCircle[] UserFollowCircles { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class UserFollowCircle
    {
        [JsonProperty("circle_type")]
        public long CircleType { get; set; }

        [JsonProperty("circle_id")]
        public long CircleId { get; set; }

        [JsonProperty("circle_name")]
        public string CircleName { get; set; }

        [JsonProperty("updated_time")]
        public long UpdatedTime { get; set; }

        [JsonProperty("cover")]
        public Uri Cover { get; set; }
    }
}

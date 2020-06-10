using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class Collection
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("collection_id")]
        public long CollectionId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("collection_type")]
        public string CollectionType { get; set; }
    }
}

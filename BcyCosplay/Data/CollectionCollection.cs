using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class CollectionCollection
    {
        [JsonProperty("collection_id")]
        public long CollectionId { get; set; }

        [JsonProperty("uid")]
        public long Uid { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("cover_uri")]
        public string CoverUri { get; set; }

        [JsonProperty("pv")]
        public long Pv { get; set; }

        [JsonProperty("article_num")]
        public long ArticleNum { get; set; }

        [JsonProperty("mtime")]
        public long Mtime { get; set; }

        [JsonProperty("bSubscribed")]
        public bool BSubscribed { get; set; }

        [JsonProperty("bClosed")]
        public bool BClosed { get; set; }

        [JsonProperty("since")]
        public string Since { get; set; }

        [JsonProperty("tags")]
        public string[] Tags { get; set; }

        [JsonProperty("subscribe_num")]
        public long SubscribeNum { get; set; }

        [JsonProperty("audit_status")]
        public long AuditStatus { get; set; }
    }
}

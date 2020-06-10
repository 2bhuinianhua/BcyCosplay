using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class Tag
    {
        [JsonProperty("circle_id")]
        public long CircleId { get; set; }

        [JsonProperty("circle_name")]
        public string CircleName { get; set; }

        [JsonProperty("circle_type")]
        public long CircleType { get; set; }

        [JsonProperty("relative_wid")]
        public long RelativeWid { get; set; }

        [JsonProperty("creator_uid")]
        public long CreatorUid { get; set; }

        [JsonProperty("admin_uid")]
        public long AdminUid { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("intro")]
        public string Intro { get; set; }

        [JsonProperty("editor_status")]
        public long EditorStatus { get; set; }

        [JsonProperty("admin_status")]
        public long AdminStatus { get; set; }

        [JsonProperty("ctime")]
        public long Ctime { get; set; }

        [JsonProperty("rtime")]
        public long Rtime { get; set; }

        [JsonProperty("follow_count")]
        public long FollowCount { get; set; }

        [JsonProperty("follow_threshold")]
        public long FollowThreshold { get; set; }

        [JsonProperty("follow_status")]
        public bool FollowStatus { get; set; }

        [JsonProperty("post_count")]
        public long PostCount { get; set; }

        [JsonProperty("event_url")]
        public string EventUrl { get; set; }

        [JsonProperty("category")]
        public long Category { get; set; }

        [JsonProperty("area")]
        public long Area { get; set; }

        [JsonProperty("event_id")]
        public long EventId { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("stime")]
        public long Stime { get; set; }

        [JsonProperty("etime")]
        public long Etime { get; set; }

        [JsonProperty("ds_time")]
        public long DsTime { get; set; }

        [JsonProperty("de_time")]
        public long DeTime { get; set; }

        [JsonProperty("heatout_time")]
        public long HeatoutTime { get; set; }

        [JsonProperty("event_include")]
        public string EventInclude { get; set; }

        [JsonProperty("tpl_name")]
        public string TplName { get; set; }
    }
}

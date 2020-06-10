using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class VideoInfo
    {
        [JsonProperty("vid")]
        public string Vid { get; set; }

        [JsonProperty("duration")]
        public long Duration { get; set; }

        [JsonProperty("min_size")]
        public long MinSize { get; set; }

        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("danmaku_total")]
        public long DanmakuTotal { get; set; }

        [JsonProperty("visible_without_watermark")]
        public long VisibleWithoutWatermark { get; set; }

        [JsonProperty("danmaku_post")]
        public bool DanmakuPost { get; set; }

        [JsonProperty("danmaku_show")]
        public bool DanmakuShow { get; set; }
    }
}

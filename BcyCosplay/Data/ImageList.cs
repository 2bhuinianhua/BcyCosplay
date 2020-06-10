using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class ImageList
    {
        [JsonProperty("path")]
        public Uri Path { get; set; }

        [JsonProperty("type")]
        public ImageListType Type { get; set; }

        [JsonProperty("mid")]
        public long Mid { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }

        [JsonProperty("original_path")]
        public string OriginalPath { get; set; }

        [JsonProperty("ratio")]
        public double Ratio { get; set; }

        [JsonProperty("visible_level")]
        public string VisibleLevel { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }
    }
}

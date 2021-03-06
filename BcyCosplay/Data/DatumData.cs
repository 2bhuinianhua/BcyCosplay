﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public partial class DatumData
    {
        [JsonProperty("data")]
        public Datum[] Data { get; set; }

        [JsonProperty("items")]
        public Item[] Items { get; set; }

        [JsonProperty("total_count")]
        public long TotalCount { get; set; }
    }
}

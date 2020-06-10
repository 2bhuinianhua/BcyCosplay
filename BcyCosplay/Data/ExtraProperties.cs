﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class ExtraProperties
    {
        [JsonProperty("item_reply_disable")]
        public bool ItemReplyDisable { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace BcyCosplay.Data
{
    public class Prop
    {
        [JsonProperty("key")]
        public Key Key { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BcyCosplay.Data
{
    public class TypeSet
    {
        [JsonProperty("type")]
        public TypeSetType Type { get; set; }

        [JsonProperty("name")]
        public Name Name { get; set; }
    }
}

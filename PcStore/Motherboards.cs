using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore
{
    internal class Motherboards : Component
    {
        [JsonProperty("Socket")]
        public string? Socket { get; set; }


    }
}

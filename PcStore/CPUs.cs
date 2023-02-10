using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore
{
    internal class CPUs : Component
    {
        [JsonProperty("CPUs")]
        public string? Socket { get; set; }
       
        public string? SupportedMemory { get; set; }

    }
}

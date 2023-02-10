using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore
{
    
    internal class Memory : Component
    {
        [JsonProperty("Memory")]
        public string? Type { get; set; }
    

    
     
    }
}

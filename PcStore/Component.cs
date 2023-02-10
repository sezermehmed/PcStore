using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore
{
    internal class Component
    {
       
        public string? PartNumber { get; set; }
        public double Price { get; set; }
        public string? Name { get; set; }
        public string? ComponentType { get; internal set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;
using static System.Runtime.InteropServices.JavaScript.JSType;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;
using System.Runtime.CompilerServices;

namespace PcStore
{
    internal class InventoryLoader
    {
        public List<Component> LoadInventory()
        {
            string jsonString = File.ReadAllText("C:\\Users\\sezer\\source\\repos\\jsontry\\jsontry\\pc-store-inventory.json");
            // cpu object list created from json file 
            List<Component> components = JsonConvert.DeserializeObject<List<Component>>(jsonString);

            List <CPUs> cpu = JsonConvert.DeserializeObject<List<CPUs>>(jsonString);
            
            List<Memory> ddrMemories = JsonConvert.DeserializeObject<List<Memory>>(jsonString);
            List<Motherboards> motherBoards = JsonConvert.DeserializeObject<List<Motherboards>>(jsonString);
            Console.WriteLine(cpu);

            foreach (var item in cpu)
            {
                components.Add(item);
            }
            foreach (var item in ddrMemories)
            {
                components.Add(item);
            }
            foreach (var item in motherBoards)
            {
                components.Add(item);
            }

            return components;

        }
    }
}
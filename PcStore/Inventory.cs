using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore
{
    internal class Inventory
    {
       
        public List<Component> Components { get; set; }
        public List<CPUs> Cpus { get; set; }
        public List<Memory> DdrMemories { get; set; }
        public List<Motherboards> MotherBoards { get; set; }
        
    

        public Inventory(InventoryLoader inventoryLoader)
        {
            Components = new List<Component>();
            Cpus = new List<CPUs>();
            DdrMemories = new List<Memory>();
            MotherBoards = new List<Motherboards>();
        }



        //public Inventory(List<Component> components)
        //{
        //    Components = components;
        //}
        public Component GetAllTheComponents()
        {
            
            return Components.FirstOrDefault() ?? throw new Exception("Component not found");
        }

        public Component GetComponentByPartNumber(string partNumber)
        {
            return Components.FirstOrDefault(c => c.PartNumber == partNumber) ?? throw new Exception("Component not found");
        }

        public CPUs GetCpuByPartNumber(string partNumber)
        {
            
            return Cpus.FirstOrDefault(c => c.PartNumber == partNumber) ?? throw new Exception("Component not found");
        }

        public Memory GetDdrMemoryByPartNumber(string partNumber)
        {
            return DdrMemories.FirstOrDefault(c => c.PartNumber == partNumber) ?? throw new Exception("Component not found");
        }

        public Motherboards GetMotherBoardByPartNumber(string partNumber)
        {
            return MotherBoards.FirstOrDefault(c => c.PartNumber == partNumber) ?? throw new Exception("Component not found");
        }

        public void AddComponent(Component component)
        {
            Components.Add(component);
        }
        


        public bool ValidateConfiguration(CPUs cpu, Memory memory, Motherboards motherboard)
        {
            // Check if the components are compatible
            if (cpu.Socket != motherboard.Socket)
            {
                return false;
            }
            if (cpu.SupportedMemory != memory.Type)
            {
                return false;
            }
            return true;
        }

    }
}

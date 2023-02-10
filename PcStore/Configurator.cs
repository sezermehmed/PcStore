using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore
{
    internal class Configurator
    {
        private Dictionary<string, Component> _inventory;

        public Configurator(Dictionary<string, Component> inventory)
        {
            _inventory = inventory;
        }

        public CPUs? Cpu { get; private set; }
        public Memory? DdrMemory { get; private set; }
        public Motherboards? MotherBoard { get; private set; }
        public double Price { get; private set; }

        public List<Configurator> GenerateConfigurations(List<CPUs> cpus, List<Memory> memories, List<Motherboards> motherboards)
        {
            var configurations = new List<Configurator>();
            foreach (var cpu in cpus)
            {
                foreach (var memory in memories)

                {
                    foreach (var motherboard in motherboards)
                    {
                        if (cpu.Socket == motherboard.Socket && memory.Type == cpu.SupportedMemory)
                        {
                            configurations.Add(new Configurator(_inventory)
                            {
                                Cpu = cpu,
                                DdrMemory = memory,
                                MotherBoard = motherboard,
                                Price = GetPrice(cpu, memory, motherboard)
                            });
                        }
                    }
                }
            }
            return configurations;
        }

        public double GetPrice(CPUs cpu, Memory memory, Motherboards motherboard)
        {
            return _inventory[cpu.PartNumber].Price + _inventory[memory.PartNumber].Price + _inventory[motherboard.PartNumber].Price;
        }
    }
}

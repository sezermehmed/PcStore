using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcStore
{
    internal class ConfigurationValidator
    {
        public static bool Validate(CPUs cpu, Memory memory, Motherboards motherboard)
        {
            return ValidateCPUCompatibility(cpu, motherboard) && ValidateMemoryCompatibility(cpu, memory);
        }

        public static bool ValidateCPUCompatibility(CPUs cpu, Motherboards motherboard)
        {
            return cpu.Socket == motherboard.Socket;
        }

        public static bool ValidateMemoryCompatibility(CPUs cpu, Memory memory)
        {
            return cpu.SupportedMemory == memory.Type;
        }
        public static bool ValidateUniqueComponents(CPUs cpu, Memory memory, Motherboards motherboard)
        {
            return cpu.PartNumber != memory.PartNumber && cpu.PartNumber != motherboard.PartNumber && memory.PartNumber != motherboard.PartNumber;
        }
        // validate that ComponentTypes are not duplicate (same ComponentType can't be used twice)

        //public static bool ValidateUniqueComponentTypes(Cpu cpu, DdrMemory memory, MotherBoard motherboard)
        //{
        //    return cpu.ComponentType != memory.ComponentType && cpu.ComponentType != motherboard.ComponentType && memory.ComponentType != motherboard.ComponentType;
        //}




    }
}

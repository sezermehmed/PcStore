using System.Diagnostics.Metrics;
using System.Numerics;

namespace PcStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            InventoryLoader inventoryLoader = new InventoryLoader();
            Inventory inventory = new Inventory(inventoryLoader);
            Console.WriteLine(inventory);
            
            Console.WriteLine("Welcome to Pc Store!");
            Console.Write("Please enter part number(s): ");

            // string[] partNumber = Console.ReadLine().Split(",");
            string partNumber = Console.ReadLine();
            Inventory inventory1 = new Inventory(inventoryLoader);
            // inventory1.GetComponentByPartNumber(partNumber[0]);
            // get component from inventory class by part number
            //Console.WriteLine(inventory1.GetComponentByPartNumber(partNumber[0]));
            Console.WriteLine(inventory1.GetAllTheComponents());
            Console.WriteLine(inventory1.GetCpuByPartNumber(partNumber: partNumber));
            


            foreach (var item in partNumber) 
                Console.WriteLine(item);
            
        }
    }
}

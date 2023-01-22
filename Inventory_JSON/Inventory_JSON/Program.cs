using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_JSON;


namespace Inventory_JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Inventory Management ");
            const string INVENTORY_DATA_PATH = @"C:\AMD\RFP244\Object_Oriented_Programs_JSON\Inventory_JSON\Inventory_JSON\Inventory.json";
            InventoryManagement dataManagement = new InventoryManagement();
            InventoryData data = new InventoryData();
            const string INVENTORY_MANAGEMENT_PATH = @"C:\AMD\RFP244\Object_Oriented_Programs_JSON\Inventory_JSON\Inventory_JSON\InventoryList.json";
            InventoryManager manager = new InventoryManager();

            Console.WriteLine("1. Display the Inventory Data\n2. Add the Inventory Data\n3. Edit the Inventory Data\n4. Exit the Program");
            bool check = true;
            while (check)
            {
                Console.WriteLine("Choose your option: ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        dataManagement.DisplayInventory(INVENTORY_DATA_PATH);
                        break;
                    case 2:
                        Console.WriteLine("Enter the Inventory List and Name :");
                        string inventoryName1 = Console.ReadLine();
                        string grain1 = Console.ReadLine();
                        data.Name = Console.ReadLine();
                        data.Weight = Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg = Convert.ToInt32(Console.ReadLine());
                        manager.AddInventory(data, inventoryName1, INVENTORY_MANAGEMENT_PATH);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Inventory List and Grains :");
                        string inventoryName2 = Console.ReadLine();
                        string grain2 = Console.ReadLine();
                        manager.EditInventory(inventoryName2, grain2, INVENTORY_MANAGEMENT_PATH);
                        break;
                    case 4:
                        check = false;
                        break;
                    default:
                        Console.WriteLine("You chose the wrong option, please choose correctly");
                        break;

                }
            }

        }
    }
}
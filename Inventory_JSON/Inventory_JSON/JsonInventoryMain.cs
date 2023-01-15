using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_JSON
{
    internal class JsonInventoryMain
    {
        InventoryModal model = new InventoryModal();

        List<InventoryModal> list = new List<InventoryModal>();

        public void Convert(string jFilePath)
        {
            using (StreamReader file = new StreamReader(jFilePath))
            {
                var json = file.ReadToEnd();
                var items = JsonConvert.DeserializeObject<List<InventoryModal>>(json);
                Console.WriteLine("Items Price Weight TotalValue");
                foreach (var objects in items)
                {
                    double value = objects.price * objects.weight;
                    Console.WriteLine(objects.name + " -> " + objects.price + " -> " + objects.weight + " -> " + value);
                }

            }

        }
    }
}

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
            JsonInventoryMain Json = new JsonInventoryMain();

            Json.Convert("C:\\AMD\\RFP244\\Object_Oriented_Programs_JSON\\Inventory_JSON\\Inventory_JSON\\Inventory.json");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_JSON;


namespace Inventory_JSON.Stock
{
    class Program
    {
        static void Main(string[] args)
        {
            const string STOCK_DATA_PATH = @"C:\AMD\RFP244\Object_Oriented_Programs_JSON\Inventory_JSON\Inventory_JSON\StockJson.json";
            StockManager stockmanager = new StockManager();
            stockmanager.DisplayStock(STOCK_DATA_PATH);
        }
    }
}
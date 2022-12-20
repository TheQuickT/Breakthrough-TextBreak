using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakthrough_Text_Break
{
    public class Inventory
    {
        //create the inventory list
        public List<string> inventoryList = new List<string>();

        //create a method to add an item.
        //will require an input parameter
        public void AddInventoryItem(string _item)
        {
            inventoryList.Add(_item);
        }
    }
}

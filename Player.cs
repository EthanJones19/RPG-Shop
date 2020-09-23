using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;

        public Player()
        {
            _inventory = new Item[3];
            _gold = 100;
        }

        public Player(int moneyVal, int inventorySize)
        {
            _gold = moneyVal;
            _inventory = new Item[inventorySize];
        }

        
        public Item[] GetInventory()
        {
            return _inventory;
        }

        public bool Buy(Item item, int itemIndex)
        {
            if (itemIndex > 0 && itemIndex < _inventory.Length)
            {
                return true;
            }
            return false;

        }

        public int GetMoney()
        {
            return _gold;
        }


    }
}

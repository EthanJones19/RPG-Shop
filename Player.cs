using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _money;
        private Item[] _inventory;

        public Player()
        {
            _inventory = new Item[3];
            _money = 100;
        }

        public Player(int moneyVal, int inventorySize)
        {
            _money = moneyVal;
            _inventory = new Item[inventorySize];
        }

        public Item[] GetInventory()
        {
            return _inventory;
        }

        public bool Contains(int itemIndex)
        {



        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {

        private bool _gameOver;
        private Player _player;
        private Item _arrows;
        private Item _shield;
        private Item _gem;
        private Shop _shop;
        private Item[] _shopinventory;



        //Run the game
        public void Run()
        {
            Start();

            while (_gameOver == false)
            {
                Update();
            }

            End();

        }

        private void InitializeItems()
        {
            _arrows.cost = 20;
            _arrows.name = "20 Arrows";

            _shield.cost = 50;
            _shield.name = "Shield";

            _gem.cost = 40;
            _gem.name = "Health Gem";





        }
        public void PrintInventory(Item[] inventory)
        {
            for (int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].name + inventory[i].cost);
            }
        }

        private void OpenShopMenu()
        {
            Console.WriteLine("Welcome Stranger!");

            PrintInventory(_shopinventory);

            char input = Console.ReadKey().KeyChar;
            int itemIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        break;
                    }

                case '2':
                    {
                        itemIndex = 1;
                        break;
                    }

                case '3':
                    {
                        itemIndex = 2;
                        break;
                    }

                default:
                    {
                        return;
                    }

            }

            if (_player.GetGold() < _shopinventory[itemIndex].cost)
            {
                Console.WriteLine("You can't afford this.");
                return;
            }


            Console.WriteLine("Choose a slot to replace.");
            PrintInventory(_player.GetInventory());
            input = Console.ReadKey().KeyChar;

            int playerIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        playerIndex = 0;
                        break;
                    }
                case '2':
                    {
                        playerIndex = 1;
                        break;
                    }
                case '3':
                    {
                        playerIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }

            }

            _shop.Sell(_player, itemIndex, playerIndex);
        }
        
        //Performed once when the game begins
        public void Start()
        {
            _gameOver = false;
            _player = new Player();
            InitializeItems();
            _shopinventory = new Item[]{ _arrows, _shield, _gem };
            _shop = new Shop(_shopinventory);
        }

        //Repeated until the game ends
        public void Update()
        {

        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}

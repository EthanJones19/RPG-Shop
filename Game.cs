using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Game
    {
        Player player = new Player(100, 3);

        private bool _gameOver = false;
        private Player _player1;
        private Item _arrows;
        private Item _shield;
        private Item _gem;



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
        public Item PrintInventory(Item[])
        {

        }

        private void OpenShopMenu()
        {


        }

        //Performed once when the game begins
        public void Start()
        {
            
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

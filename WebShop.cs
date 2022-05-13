using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceIntro
{
    
    class WebShop
    {
        StoreInventory Inventory { get; set; }
        public List<Game> ShoppingCart { get; private set; }

        public WebShop()
        {
            Inventory = new StoreInventory();
            ShoppingCart = new List<Game>();

            while (true)
            {
                Console.WriteLine("Welcome to the shop! ");
                Console.WriteLine("1: Show all available games");
                Console.WriteLine("2: Show only physical games");
                Console.WriteLine("3: Show only downloadable games");

              HandleCommand();
            }
        }

        //TODO:
        void HandleCommand()
        {
            // Skal lese inn input fra brukere her
           var command =  Console.ReadLine();
           Inventory.PrintInventory(command); // Inventory skal printe ut informasjon basert på valget brukeren tok. 

            Console.WriteLine("input the ID of game you want to buy");
            var gameID = Console.ReadLine();
            var gameToBuy = Inventory.InventoryList.Find(x => x.Id == gameID);
            ShoppingCart.Add(gameToBuy);
            //Sjekk på om spillet skal shippes eller lastes ned
            if(gameToBuy is IDownloadable)
            {
                PrintDownloadMessage(gameToBuy.GameName);
            }
            else
            {
                PrintShippingMessage(gameToBuy.GameName);
            }
            //Print ut med Download eller shipping metoden under
        }
        private void PrintDownloadMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will now be downloaded..");
        }
        private void PrintShippingMessage(string gameName)
        {
            Console.WriteLine($"Game {gameName} will be shipped shortly..");
        }
    }
}

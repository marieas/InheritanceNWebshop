using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InheritanceIntro
{
    class StoreInventory
    {
        public List<Game> InventoryList { get; set; }
        public StoreInventory()
        {
            InventoryList = new List<Game>();
            InventoryList.Add(new PUBG());
            InventoryList.Add(new PokemonLetsGoEvee());
            InventoryList.Add(new CyberPunk());
            InventoryList.Add(new BattleField());
        }
        //StoreInventory skal også ha metoder for å printe ut spillinformasjon basert på brukerinput i consollen.
        //Fullfør også det som mangler for å printe ut infoen til hvert spill.

        public void PrintInventory(string command)
        {
            if (command == "1")
            {
                Print(InventoryList);
            }
            else if (command == "2")
            {
                Print(ListPhysicalItems());
            }
            else
            {
                Print(ListDownLoadable());
            }
        }

        private void Print(List<Game> inventoryList)
        {
           foreach(var game in inventoryList)
           {
                game.PrintGameNameAndPrice();
           }
        }

        public List<Game> ListPhysicalItems()
        {
            //for å finne alle elementene i InventoryList som selges i fysisk format
           return InventoryList.Where(item => item is IPhysical).ToList();
        }
        public List<Game> ListDownLoadable()
        {
            // for å finne alle elementene som selges som downloadable content.
            return InventoryList.Where(item => item is IDownloadable).ToList();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class GameData
    {
        static GameData data;
        GameData() { }

        public static GameData Data
        {
            get
            {
                if (data == null)
                {
                    data = new GameData();
                }
                return data;
            }            
        }

        static List<Action> actionsList = new List<Action>();
        static List<Item> itemList = new List<Item>();
        static List<Ennemy> ennemiesList = new List<Ennemy>();
        static Player hero = new Player("Hero", 100, 100, 10, 10, 5, 0, 1);

        public static Player Hero { get => hero; set => hero = value; }
        public static List<Action> ActionsList { get => actionsList; set => actionsList = value; }

        public static List<Ennemy> EnnemiesList { get => ennemiesList; set => ennemiesList = value; }        

        public static List<Item> ItemList { get => itemList; set => itemList = value;}

        public static void FillList()
        {
            ActionsList.Add(new InspectRoom()); //0
            ActionsList.Add(new MoveToAnotherRoom()); //1
            ActionsList.Add(new Fight()); //2
            ActionsList.Add(new PickUpItem()); //3
            ActionsList.Add(new Rest()); //4
            ActionsList.Add(new Use()); //5

            EnnemiesList.Add(new Ennemy("Goblin", 13, 13, 5, 10)); //0
            EnnemiesList.Add(new Ennemy("Skeleton", 20, 20, 7, 25)); //1
            EnnemiesList.Add(new Ennemy("Ghost", 16, 16, 10, 30)); //2
            EnnemiesList.Add(new Ennemy("Minotaure", 40, 40, 15, 90)); //3
            EnnemiesList.Add(new Ennemy("Warlock", 32, 32, 10, 50)); //4

            ItemList.Add(new PotionHeal("Healing potion", 15)); //0
            ItemList.Add(new PotionMaxHealth("Health potion", 10)); //1
            ItemList.Add(new PotionStrength("Strength potion", 10)); //2
            ItemList.Add(new PotionTechnique("Technique potion", 10)); //3
            ItemList.Add(new CoinsBag("Coin bag", 10)); //4
            ItemList.Add(new Weapon("Iron Sword", 10));
            ItemList.Add(new Armor("Iron Armor", 10));
        }

        public static void WrongChoice()
        {
            Console.WriteLine("\nYour choice must be valid !\n ");
            Console.ReadKey();
        }
    }
}

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

        public static GameData Data //singleton
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
        static Player hero = new Player("Hero", 150, 150, 50, 50, 30, 0, 1);

        public static Player Hero { get => hero; set => hero = value; }
        public static List<Action> ActionsList { get => actionsList; set => actionsList = value; }

        public static List<Ennemy> EnnemiesList { get => ennemiesList; set => ennemiesList = value; }        

        public static List<Item> ItemList { get => itemList; set => itemList = value;}

        public static void FillList() //the list of all the game's possible assets
        {
            ActionsList.Add(new InspectRoom()); //0
            ActionsList.Add(new MoveToAnotherRoom()); //1
            ActionsList.Add(new Fight()); //2
            ActionsList.Add(new PickUpItem()); //3
            ActionsList.Add(new Rest()); //4
            ActionsList.Add(new Use()); //5

            EnnemiesList.Add(new Ennemy("Goblin", 50, 30, 10, 10, RandomGenerators.Instance.RandomNumber(0,5))); //0
            EnnemiesList.Add(new Ennemy("Skeleton", 70, 70, 15, 25, RandomGenerators.Instance.RandomNumber(0, 10))); //1
            EnnemiesList.Add(new Ennemy("Ghost", 40, 20, 10, 30, 0)); //2
            EnnemiesList.Add(new Ennemy("Minotaure", 120, 120, 40, 150, RandomGenerators.Instance.RandomNumber(0, 100))); //3
            EnnemiesList.Add(new Ennemy("Warlock", 90, 50, 20, 50, RandomGenerators.Instance.RandomNumber(0, 150))); //4

            ItemList.Add(new PotionHeal("Healing potion", 15)); //0
            ItemList.Add(new PotionMaxHealth("Health potion", 10)); //1
            ItemList.Add(new PotionStrength("Strength potion", 10)); //2
            ItemList.Add(new PotionTechnique("Technique potion", 10)); //3
            ItemList.Add(new CoinsBag("Coin bag", 10)); //4

            ItemList.Add(new Weapon("Stone Sword", 7)); //5 
            ItemList.Add(new Weapon("Steel Sword", 15)); //6 
            ItemList.Add(new Weapon("Diamond Sword", 25)); //7

            ItemList.Add(new Armor("Light Armor", 5)); //8
            ItemList.Add(new Armor("Heavy Armor", 15)); //9
            ItemList.Add(new Armor("Obsidian Armor", 30)); //10
        }

        public static void ClearList() //clear all the list of the data's
        {
            ItemList.Clear();
            EnnemiesList.Clear();
        }

        public static void WrongChoice()
        {
            Console.WriteLine("\nYour choice must be valid !\n ");
            Console.ReadKey();
        }
    }
}

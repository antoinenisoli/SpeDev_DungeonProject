using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Program
    {                
        static void Main(string[] args)
        {
            GameData.FillList();
            Start();
            //test();
            
        }

        static void Start() //create a new room to explore
        {
            Console.Clear();            
            Player hero = GameData.Hero;
            Console.WriteLine("Welcome in the dungeon " + hero.Name + " !");
            Console.WriteLine("Be careful, you can find danger at any corner of this dark place...");
            Console.ReadKey();
            Action firstAction = new MoveToAnotherRoom();
            firstAction.Execute(hero, new Room(0, 0));
        }       
        
        static void test()
        {
            bool ok = false;
            Player hero = GameData.Hero;
            while (!ok)
            {
                Ennemy MOB01 = GameData.EnnemiesList[2];
                Ennemy mob2 = GameData.EnnemiesList[2];
                Console.WriteLine(hero.ShowCharacter());
                Console.WriteLine(MOB01.ShowCharacter());
                Console.WriteLine(mob2.ShowCharacter());
                hero.Attack(MOB01);
                GameData.ClearList();
                GameData.FillList();
            }
        }
    }
}

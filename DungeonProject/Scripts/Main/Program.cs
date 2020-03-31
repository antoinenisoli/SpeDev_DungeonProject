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

            /*bool ok = false;
            Player hero = GameData.Hero;
            while (!ok)
            {
                Ennemy mob = new Ennemy("mob", 1000, 1000, 20, 50, 50);
                Console.WriteLine(hero.ShowCharacter());
                Console.WriteLine(mob.ShowCharacter());
                hero.Attack(mob);
            }*/
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
    }
}

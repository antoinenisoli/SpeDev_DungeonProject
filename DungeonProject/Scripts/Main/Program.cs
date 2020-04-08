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
        }

        static void Start() //start the game
        {
            Console.Clear();            
            Player hero = GameData.Hero;
            Console.WriteLine("Welcome in the dungeon " + hero.Name + " !");
            Console.WriteLine("Be careful, you can find danger at any corner of this dark place...");
            Console.ReadKey();
            Action firstAction = new MoveToAnotherRoom();
            Room firstRoom = new Room(0, 0);
            firstAction.Execute(hero, firstRoom);
        }       
    }
}

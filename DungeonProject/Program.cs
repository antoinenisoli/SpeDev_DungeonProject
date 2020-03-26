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
            NewRoom();
        }

        static void NewRoom() //create a new room to explore
        {
            Console.Clear();
            Player hero = GameData.Hero;
            bool nextRoom = false;

            int randomEnnemies = RandomGenerators.Instance.RandomNumber(0, 5);
            int randomItems = RandomGenerators.Instance.RandomNumber(0, 5);
            Room currentRoom = new Room(randomEnnemies, randomItems);

            while (!nextRoom)
            {
                Console.Clear();
                Console.WriteLine("***************************************");
                Console.WriteLine(hero.ShowCharacter());
                hero.ShowInventory();
                Console.WriteLine("");

                Console.WriteLine("You traveled into a new room, what do you do ?");
                Console.WriteLine("0 : Inspect the room");
                Console.WriteLine("1 : Move to another room");
                Console.WriteLine("2 : Attack an ennemy");
                Console.WriteLine("3 : Pick up an item");
                Console.WriteLine("4 : Rest in a bed");
                Console.WriteLine("5 : Use a item from the inventory");

                string answer = Console.ReadLine();
                if (int.TryParse(answer, out int nombre) && nombre >= 0 && nombre <= GameData.ActionsList.Count)
                {
                    Action selectedAction = GameData.ActionsList[nombre];
                    selectedAction.Execute(hero, currentRoom);
                }
                else
                {
                    GameData.WrongChoice();
                }
            }
        }              
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class MoveToAnotherRoom : Action
    {
        public override void Execute(Player player, Room inRoom) //generate a new room and ask the player to chose an action
        {
            Console.Clear();
            Console.WriteLine("You arrived in a new room...");
            Console.ReadKey();

            int randomEnnemies = RandomGenerators.Instance.RandomNumber(0, 5);
            int randomItems = RandomGenerators.Instance.RandomNumber(0, 6);
            Room currentRoom = new Room(randomEnnemies, randomItems);

            bool turn = false;
            while (!turn)
            {
                Console.Clear();
                Console.WriteLine("***************************************");
                Console.WriteLine(player.ShowCharacter());
                player.ShowInventory();
                Action pickedAction = Menu.PickElementFromList<Action>(GameData.ActionsList, null);
                pickedAction.Execute(player, currentRoom);
            }
        }

        public override string ToString()
        {
            return "Move to another room";
        }
    }
}

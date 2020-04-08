using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class MoveToAnotherRoom : Action
    {
        List<string> directionsList = new List<string> //the possible directions
            {
                "North",
                "South",
                "East",
                "West"
            };

        public override void Execute(Player player, Room inRoom) //generate a new room and ask the player to chose an action
        {
            Console.Clear();                        
            Room currentRoom = GenerateRoom(5,6); //generate a new room with random ennemies and item
            currentRoom.Directions = RandomGenerators.Instance.RandomNumber(0, directionsList.Count);
            AssignDirections(currentRoom); //generate different directions to the room

            int pickedDirection = Menu.ChooseStrFromList(currentRoom.GetDirections(), "\nIn which direction do you want to go ?");
            string str = pickedDirection.ToString();
            Room pickedRoom = currentRoom.neighbors[directionsList[pickedDirection]];
            //Console.WriteLine(pickedRoom.ennemiesInRoom.Count);

            Console.WriteLine("You arrived in a new room...");
            Console.WriteLine("You have travelled " + GameData.RoomCount + " times.");
            GameData.RoomCount++;
            Console.WriteLine(GameData.ShowCoordinates());
            Console.ReadKey();            

            bool turn = false;
            while (!turn) //the player choose his action
            {
                Console.Clear();
                Console.WriteLine("***************************************");
                player.ShowCharacter();
                player.ShowInventory();
                Action pickedAction = Menu.PickElementFromList(GameData.ActionsList, "Which action do you want to execute ?");
                pickedAction.Execute(player, pickedRoom);
            }
        }

        void SetupRoom()
        {

        }

        void AssignDirections(Room currentRoom) //generate different directions to the room
        {
            for (int i = 0; i <= currentRoom.Directions; i++)
            {
                Room newRoom = GenerateRoom(5,6);
                currentRoom.AddNeighbor(directionsList[i], newRoom);
            }            
        }

        Room GenerateRoom(int maxEnnemies, int maxItems)
        {
            int randomEnnemies = RandomGenerators.Instance.RandomNumber(0, maxEnnemies);
            int randomItems = RandomGenerators.Instance.RandomNumber(0, maxItems);
            return new Room(randomEnnemies, randomItems);
        }

        public override string ToString()
        {
            return "Move to another room";
        }
    }
}

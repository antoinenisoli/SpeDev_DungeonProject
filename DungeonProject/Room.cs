using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Room
    {
        public List<Ennemy> ennemiesInRoom = new List<Ennemy>();
        public List<Item> itemsInRoom = new List<Item>();
        bool bed;
        public bool Bed { get => bed; set => bed = value; }

        public Room(int maxEnnemies, int maxItems)
        {
            for (int i = maxEnnemies; i > 0; i--)
            {
                ennemiesInRoom.Add(RandomGenerators.MobGenerator());
            }

            for (int i = maxItems; i > 0; i--)
            {
                itemsInRoom.Add(RandomGenerators.ItemGenerator());
            }

            GenerateBed();
        }        

        void GenerateBed()
        {
            int randomNumber = RandomGenerators.Instance.RandomNumber(0, 10);

            if (randomNumber > 5)
            {
                Bed = true;
            }
            else
            {
                Bed = false;
            }
        }
    }
}

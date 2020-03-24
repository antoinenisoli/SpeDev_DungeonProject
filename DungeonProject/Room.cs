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
        }        

        
    }
}

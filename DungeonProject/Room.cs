using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Room
    {
        Random rdm = new Random();
        public List<Ennemy> ennemiesInRoom = new List<Ennemy>();
        public List<Item> itemsInRoom = new List<Item>();
        int maxEnnemies = 0;
        int maxItems;
        int step;

        public Room(int ennemiesRange, int itemsRange)
        {
            step = 1;

            int randomMob = rdm.Next(0, ennemiesRange);
            if (randomMob >= 5)
            {
                maxEnnemies = 2;
            }
            else
            {
                maxEnnemies = 1;
            }

            int randomItem = rdm.Next(0, itemsRange);
            if (randomItem >= 5)
            {
                maxItems = 2;
            }
            else
            {
                maxItems = 1;
            }

            for (int i = maxEnnemies; i > 0; i--)
            {
                ennemiesInRoom.Add(MobGenerator());
                step++;
            }

            for (int i = maxItems; i > 0; i--)
            {
                itemsInRoom.Add(ItemGenerator());
            }
        }

        public Ennemy MobGenerator() //génére un ennemi aléatoire
        {            
            Ennemy mob = new Ennemy("Squelette 0", 5, 2, 10);
            return mob;
        }

        public Item ItemGenerator() //génére un objet
        {
            Item item = new Item("Objet 0", 5);
            return item;
        }

        public void InspectRoom()
        {
            Console.WriteLine("");
            Console.WriteLine("Cette piéce semble contenir ces ennemis :");

            foreach (Ennemy mob in ennemiesInRoom)
            {
                Console.WriteLine(mob.ShowCharacter());
            }

            Console.WriteLine("");
            Console.WriteLine("Cette piéce semble contenir ces objets :");

            foreach (Item item in itemsInRoom)
            {
                Console.WriteLine(item.ShowItem());
            }

            Console.WriteLine("");
            Console.ReadLine();
            Console.Clear();
        }
    }
}

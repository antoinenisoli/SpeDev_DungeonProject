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
        bool containExit;
        public bool ContainExit { get => containExit; set => containExit = value; }
        bool containBed;
        public bool ContainBed { get => containBed; set => containBed = value; }
        int directions;
        public int Directions { get => directions;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                directions = value;
            }
        }

        public Dictionary<string, Room> neighbors = new Dictionary<string, Room>();

        public Room(int maxEnnemies, int maxItems)
        {            
            for (int i = maxItems; i >= 0; i--)
            {
                itemsInRoom.Add(RandomGenerators.ItemGenerator());
            }

            for (int i = maxEnnemies; i >= 0; i--)
            {
                RandomMob();
            }

            ContainBed = GenerateComponent(20, 100);            
            if (GameData.RoomCount >= 3)
            {
                ContainExit = GenerateComponent(10, 100);                
            }
            else
            {
                ContainExit = false;
            }
        }

        public void AddNeighbor(string key, Room room)
        {
            neighbors.Add(key, room);
        }

        public List<string> GetDirections()
        {
            return neighbors.Keys.ToList();
        }
        
        public void RandomMob() //generate a new ennemy and give him some stuff and items
        {
            Ennemy enemy = RandomGenerators.MobGenerator();
            ennemiesInRoom.Add(enemy);

            for (int increment = 1; increment > 0; increment--)
            {
                Item item = RandomGenerators.ItemGenerator();
                enemy.Inventory.items.Add(item); //give items in the enemy's inventory
            }

            GiveRandomStuff(enemy, GameData.ArmorList);
            GiveRandomStuff(enemy, GameData.WeaponList);
        }

        public bool GenerateComponent(int randomRange, int maxRandom)
        {
            int randomNumber = RandomGenerators.Instance.RandomNumber(0, maxRandom);
            
            if (randomNumber <= randomRange)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void GiveRandomStuff(Ennemy enemy, List<Equipment> list)
        {
            int random01 = RandomGenerators.Instance.RandomNumber(0, 10); //give stuff to the enemy
            if (random01 >= 5)
            {
                int random02 = RandomGenerators.Instance.RandomNumber(0, list.Count); 
                Equipment randomStuff = list[random02];
                randomStuff.GiveTo(enemy);
            }            
        }
    }
}

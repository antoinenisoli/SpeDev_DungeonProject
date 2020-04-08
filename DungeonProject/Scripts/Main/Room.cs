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
            for (int i = maxItems; i > 0; i--)
            {
                itemsInRoom.Add(RandomGenerators.ItemGenerator());
            }

            for (int i = maxEnnemies; i > 0; i--)
            {
                RandomMob();
            }

            GenerateBed();
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

            int random01 = RandomGenerators.Instance.RandomNumber(8, 11); //give an armor to the enemy
            Item randomArmor = GameData.ItemList[random01];
            randomArmor.GiveTo(enemy);

            int random02 = RandomGenerators.Instance.RandomNumber(5, 8); //give a weapon to the enemy
            Item randomWeapon = GameData.ItemList[random02];
            randomWeapon.GiveTo(enemy);
        }

        void GenerateBed() //is ther a bed in the room ?
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

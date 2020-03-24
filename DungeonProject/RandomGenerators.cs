using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class RandomGenerators
    {
        static RandomGenerators instance;
        RandomGenerators() { }        

        public static RandomGenerators Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RandomGenerators();
                }
                return instance;
            }
        }

        Random rdm = new Random();

        public int RandomNumber(int a, int b)
        {           
            int result = rdm.Next(a, b);
            return result;
        }

        public static Ennemy MobGenerator() //génére un ennemi aléatoire
        {
            Ennemy mob = GameData.EnnemiesList[Instance.RandomNumber(0,5)];
            return mob;
        }

        public static Item ItemGenerator() //génére un objet aléatoire
        {
            Item item = GameData.ItemList[Instance.RandomNumber(0,5)];
            return item;
        }
    }
}

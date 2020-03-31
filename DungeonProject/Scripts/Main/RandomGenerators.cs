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

        public double RandomDouble(double min, double max)
        {
            double result = rdm.NextDouble() * (max - min) + min;

            return result;
        }

        public static int CalculatePercentage(int value, double percentage)
        {
            int multiply = (int)(value * Math.Round(percentage, 2));
            return multiply;
        }

        public static Ennemy MobGenerator() //génére un ennemi aléatoire
        {
            Ennemy mob = GameData.EnnemiesList[Instance.RandomNumber(0,GameData.EnnemiesList.Count)];
            return mob;
        }

        public static Item ItemGenerator() //génére un objet aléatoire
        {
            //Item item = GameData.ItemList[Instance.RandomNumber(0, GameData.EnnemiesList.Count)];
            Item item = GameData.ItemList[Instance.RandomNumber(5, 11)];
            return item;
        }
    }
}

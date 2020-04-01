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

        public static RandomGenerators Instance //singleton
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

        public int RandomNumber(int a, int b) //generate a random integer
        {           
            int result = rdm.Next(a, b);
            return result;
        }

        public double RandomDouble(double min, double max) //generate a random double
        {
            double result = rdm.NextDouble() * (max - min) + min;

            return result;
        }

        public static int CalculatePercentage(int value, double percentage) //calculate the percentage of a value 
        {
            int multiply = (int)(value * Math.Round(percentage, 2));
            return multiply;
        }

        public static Ennemy MobGenerator() //generate a random enemy from the data's list
        {
            Ennemy mob = GameData.EnnemiesList[Instance.RandomNumber(0,GameData.EnnemiesList.Count)];
            return mob.InstatiateCopy();
        }

        public static Item ItemGenerator() //generate a random item from the data's list
        {
            Item item = GameData.ItemList[Instance.RandomNumber(0, GameData.ItemList.Count)];
            return item;
        }
    }
}

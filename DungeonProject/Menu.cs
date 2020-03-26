using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Menu
    {
        public static T PickElementFromList<T>(List<T> choice, string msg)
        {
            List<string> labels = new List<string>();
            foreach (T elt in choice)
            {
                labels.Add(elt.ToString());
            }
            int choiceIndex = ChooseStrFromList(labels, msg);
            return choice[choiceIndex];
        }

        public static int ChooseStrFromList(List<string> choice, string msg)
        {
            Console.WriteLine(msg);
            int count = 1;
            foreach (string elt in choice)
            {
                Console.WriteLine(count.ToString() + " - " + elt);
                count++;
            }

            int userChoice = -1;            

            while (userChoice < 1 || userChoice > choice.Count)
            {
                Console.WriteLine("Choose a item between (1 - " + choice.Count + ")");
                //userChoice = int.Parse(Console.ReadLine());
                string s = Console.ReadLine();
                if (int.TryParse(s, out userChoice) && userChoice >= 0 && userChoice <= choice.Count)
                {
                    
                }
                else
                {
                    GameData.WrongChoice();
                }
            }
            return userChoice - 1;
        }
    }
}

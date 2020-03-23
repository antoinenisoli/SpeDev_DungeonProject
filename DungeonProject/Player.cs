using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    class Player : Character
    {
        public Random rdm = new Random();

        int xp;
        int currentLevel;
        int nextLevel = 100;

        public Player(string name, int maxHealth, int force, int xp, int currentLevel) : base(name, maxHealth, force)
        {
            this.xp = xp;
            this.currentLevel = currentLevel;
        }

        public override string ShowCharacter()
        {
            Console.WriteLine("");

            return 
            (
            "[ " + name + " : | PV = " + GetLife() + "/" + maxHealth + " | Force = " + force + " | Points d'exp = " + xp + " | Guerrier de niveau " + currentLevel + " ]"
            );
        }

        public override void ShowInventory()
        {
            inventory.ShowInventory();
        }

        public void GainXp(Ennemy mob)
        {
            int gain = mob.xpValue;
            Console.WriteLine("");
            Console.WriteLine(name + " gagne " + gain + " point d'exp !");
            Console.WriteLine("");
            xp += gain;

            if (xp >= nextLevel)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            Console.WriteLine("");
            Console.WriteLine("Félicitations ! " + name + " viens de gagner un niveau !");
            currentLevel++;
            xp = 0;

            Console.WriteLine("Augmenter quelle stat ? " + " Pv maximum = " + maxHealth + " Force = " + force);
            Console.WriteLine("A) Augmenter la force (Cette stat va gagner un bonus permanent de 1 à 4 points)");
            Console.WriteLine("B) Augmenter les pv max (Cette stat va gagner un bonus permanent de 10 à  points)");
            string entry = Console.ReadLine();

            if (string.IsNullOrEmpty(entry))
            {
                Console.WriteLine("Entrez un choix valide.");
            }
            else if (entry == "A" || entry == "a")
            {                
                int random = rdm.Next(1, 5);
                force += random;

                Console.WriteLine("Vous avez gagné " + random + " points de force supplémentaires");
            }
            else if (entry == "B" || entry == "b")
            {
                int random = rdm.Next(10, 21);
                maxHealth += random;

                Console.WriteLine("Vous avez gagné " + random + " points de vie max supplémentaires");
            }
        }
    }
}

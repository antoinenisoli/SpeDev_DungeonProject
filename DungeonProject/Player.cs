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

        public int XP { get => xp;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
            }
        }

        int currentLevel;

        public int CurrentLevel { get => currentLevel;
            set
            {
                if (value > 0)
                {
                    value = 0;
                }
            }
        }

        int nextLevel = 100;

        public int NextLevel { get => nextLevel;
        set
            {
                if (value > 0)
                {
                    value = 0;
                }
            }
        }

        public Player(string name, int currentHealth, int maxHealth, int force, int xp, int currentLevel) : base(name, currentHealth, maxHealth, force)
        {
            this.XP = xp;
            this.CurrentLevel = currentLevel;
        }

        public override string ShowCharacter()
        {
            Console.WriteLine("");

            return 
            (
            "[ " + Name + " : | PV = " + CurrentHealth + "/" + MaxHealth + " | Force = " + Force + " | Points d'exp = " + XP + " | Guerrier de niveau " + CurrentLevel + " ]"
            );
        }

        public void GainXp(Ennemy mob)
        {
            int gain = mob.xpValue;
            Console.WriteLine("");
            Console.WriteLine(name + " gagne " + gain + " point d'exp !");
            Console.WriteLine("");
            XP += gain;

            if (XP >= NextLevel)
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

            Console.WriteLine("Augmenter quelle stat ? " + " Pv maximum = " + MaxHealth + " Force = " + Force);
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
                Force += random;

                Console.WriteLine("Vous avez gagné " + random + " points de force supplémentaires");
            }
            else if (entry == "B" || entry == "b")
            {
                int random = rdm.Next(10, 21);
                MaxHealth += random;

                Console.WriteLine("Vous avez gagné " + random + " points de vie max supplémentaires");
            }
        }
    }
}

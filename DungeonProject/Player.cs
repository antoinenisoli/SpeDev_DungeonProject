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
        int currentPt;

        public int CurrentPT { get => currentPt;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                if (value > MaxPt)
                {
                    value = MaxPt;
                }

                currentPt = value;
            }
        }

        int maxPt;

        public int MaxPt { get => maxPt;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                maxPt = value;
            }
        }

        int xp;

        public int XP { get => xp;
            set
            {
                if (value < 0)
                {
                    value = 0;
                }

                xp = value;
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

                currentLevel = value;
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

                nextLevel = value;
            }
        }

        public Player(string name, int currentHealth, int maxHealth, int currentPt, int maxPt, int force, int xp, int currentLevel) : base(name, currentHealth, maxHealth, force)
        {
            this.MaxPt = maxPt;
            this.CurrentPT = currentPt;
            this.XP = xp;
            this.CurrentLevel = currentLevel;
        }

        public override string ShowCharacter()
        {
            Console.WriteLine("");

            return 
            (
            "[ " + Name + " : | PV = " + CurrentHealth + "/" + MaxHealth + " | PT = " + CurrentPT + "/" + MaxPt + 
            "\n| Force = " + Strength + " | Points d'exp = " + XP + "/" + NextLevel + " | Niveau " + CurrentLevel + " ]"
            );
        }

        public void GainXp(Ennemy mob)
        {
            int gain = mob.xpValue;
            Console.WriteLine("");
            Console.WriteLine(Name + " gagne " + gain + " point d'exp !");
            Console.WriteLine("");
            XP += gain;

            if (XP >= NextLevel)
            {
                LevelUp();
            }

            Console.ReadKey();
        }

        public void LevelUp()
        {
            Console.WriteLine("");
            Console.WriteLine("Félicitations ! " + Name + " viens de gagner un niveau !");
            currentLevel++;
            xp = 0;
            Console.ReadKey();

            Console.WriteLine("Augmenter quelle stat ? " + " Pv maximum = " + MaxHealth + " Force = " + Strength);
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
                Strength += random;

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

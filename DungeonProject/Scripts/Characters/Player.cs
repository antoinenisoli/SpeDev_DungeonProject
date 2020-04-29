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

                if (value >= NextLevel)
                {
                    LevelUp();
                    value = 0;
                }

                xp = value;
            }
        }

        int currentLevel;
        public int CurrentLevel { get => currentLevel;
            set
            {
                if (value < 0)
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
                if (value < 0)
                {
                    value = 0;
                }

                nextLevel = value;
            }
        }

        public Player(string name, int currentHealth, int maxHealth, int currentPt, int maxPt, int strength, int xp, int currentLevel) : base(name, currentHealth, maxHealth, strength) //build the player
        {
            this.MaxPt = maxPt;
            this.CurrentPT = currentPt;
            this.XP = xp;
            this.CurrentLevel = currentLevel;
        }

        public override void IsDead() //end the game if the player is dead
        {
            Console.WriteLine("");
            Console.WriteLine(Name + " is dead !");
            Console.WriteLine("GAME OVER");
            Console.WriteLine("");
            Console.ReadKey();
            Environment.Exit(0);
        }

        public override void ShowCharacter() //show the player's attributes
        {
            string description =
            "[ " + Name + " : | PV = " + CurrentHealth + "/" + MaxHealth + " | PT = " + CurrentPT + "/" + MaxPt +
            "\n| Strength = " + Strength + " | XP = " + XP + "/" + NextLevel + " | Level " + CurrentLevel + " ]";

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(description);
            Console.ResetColor();
        }

        public override string ToString()
        {
            ShowCharacter();
            return null;
        }

        public void GainXp(int gain) //the player win some xp
        {
            Console.WriteLine("\n" + Name + " has won " + gain + " xp !");
            XP += gain;

            Console.ReadKey();
        }        

        void FullRestore() //restore the player's statistics
        {
            CurrentPT = MaxPt;
            CurrentHealth = MaxHealth;
        }

        public void LevelUp() //the player reaches a new level, his attributes are increased by between 1 and 10%
        {
            Console.WriteLine("\nCongratulations ! " + Name + " has reach a new level !");
            Console.ReadKey();
            CurrentLevel++;
            NextLevel += 100; //increase the new max level            
            
            double random = RandomGenerators.Instance.RandomDouble(0.01, 0.1); //10% = 0.1; //1% = 0.01;
            MaxHealth += RandomGenerators.CalculatePercentage(MaxHealth,random);
            MaxPt += RandomGenerators.CalculatePercentage(MaxPt, random);
            Strength += RandomGenerators.CalculatePercentage(Strength, random);
            FullRestore();
            Console.WriteLine("His stats are increased by " + Math.Round(random, 2) * 100 + "% !");
        }        
    }
}

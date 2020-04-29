using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    abstract class Character
    {
        string name;
        int currentHealth;
        int maxHealth;
        int strength;
        bool inFight;
        public bool InFight { get => inFight; set => inFight = value; }
        Inventory inventory;
        public Inventory Inventory { get => inventory; set => inventory = value; }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }

            set
            {
                if (value <= 0)
                {
                    value = 0;
                    IsDead();
                }

                if (value > MaxHealth)
                {
                    value = MaxHealth;

                }

                currentHealth = value;
            }
        }
        public int MaxHealth { get => maxHealth;
            set
            {
                maxHealth = value;
            }
        }
        public int Strength { get => strength;
            set
            {
                if (strength < 0)
                {
                    value = 0;
                }

                strength = value;
            }
        }

        public Character(string name, int currentHealth, int maxHealth, int strength)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.CurrentHealth = currentHealth;
            this.Strength = strength;
            Inventory = new Inventory(this);
        }

        public virtual void IsDead()
        {

        }

        public virtual void ShowCharacter()
        {

        }

        public virtual void ShowInventory()
        {
            Inventory.ShowInventory();
        }
        
        public void Attack(Character target) //attack the target with a regular attack
        {
            if (CurrentHealth > 0)
            {
                double random = RandomGenerators.Instance.RandomDouble(0, 0.1); //10% = 0.1; //1% = 0.01;
                int total = ComputeDamages(target) + RandomGenerators.CalculatePercentage(ComputeDamages(target), random);

                if (total <= 0)
                {
                    Console.WriteLine("\n////////////");
                    Console.WriteLine(target.Name + " has completely absorbed the damages !");
                    Console.WriteLine("////////////");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\n" + Name + " attacks " + target.Name + " !");
                    Console.ReadKey();
                    target.TakeDamages(total);
                }
            }
        }

        public int ComputeDamages(Character target) //calculate the damage amount of the character's attack
        {
            return Inventory.CurrentWeapon.Value + strength - target.Inventory.CurrentArmor.Value;
        }

        public void TakeDamages(int amount)
        {
            Console.WriteLine("\n////////////");
            Console.WriteLine(Name + " receive " + amount + " damage points !");
            Console.WriteLine("////////////");
            Console.ReadKey();
            CurrentHealth -= amount;
        }
    }
}

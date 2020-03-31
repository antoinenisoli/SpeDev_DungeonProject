using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonProject
{
    abstract class Character
    {
        public Inventory inventory = new Inventory();

        private string name;
        private int currentHealth;
        private int maxHealth;
        private int strength;

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
        }

        public virtual void IsDead()
        {

        }

        public abstract string ShowCharacter();

        public virtual void ShowInventory()
        {
            inventory.ShowInventory();
        }
        
        public void Attack(Character target) //attack the target character
        {
            double random = RandomGenerators.Instance.RandomDouble(0, 0.1); //10% = 0.1; //1% = 0.01;
            int damage = (inventory.CurrentSword.Value + strength) - target.inventory.CurrentArmor.Value;
            int total = damage + RandomGenerators.CalculatePercentage(damage, random);

            Console.WriteLine("");
            Console.WriteLine("////////////");

            if (total <= 0)
            {
                Console.WriteLine(target.Name + " has completely absorbed the damages !");
            }
            else
            {               
                Console.WriteLine(Name + " inflige " + total + " points de dégâts à " + target.Name);                
                target.CurrentHealth -= damage;
            }

            Console.WriteLine("////////////");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}

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

        public string name;
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

        public Character(string name, int currentHealth, int maxHealth, int force)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.CurrentHealth = currentHealth;
            this.Strength = force;            
        }

        public void IsDead()
        {

        }

        public abstract string ShowCharacter();

        public void ShowInventory()
        {
            inventory.ShowInventory();
        }
        
        public void Attack(Character target)
        {
            int damage = strength;
            Console.WriteLine("");
            Console.WriteLine("////////////");
            Console.WriteLine(Name + " inflige " + damage + " points de dégâts à " + target.Name);
            Console.WriteLine("////////////");
            Console.WriteLine("");
            Console.ReadKey();
            target.CurrentHealth -= damage;
        }
    }
}

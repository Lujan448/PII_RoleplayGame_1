using System;
<<<<<<< HEAD
=======
using System.Collections.Generic;
>>>>>>> 5540056b7ff63c2156966a24b98c10b364fcf179

namespace ucudal
{
    public class Elf
    {
        private string name;
        public string Name 
        { 
            get {return name; } set {name = value; } 
        }

        private int attackValue;
        public int AttackValue 
        { 
            get {return attackValue; } set {attackValue = value;} 
        }

        private int defenseValue;
        public int DefenseValue 
        { 
            get {return defenseValue; } set { defenseValue = value;}
        }
<<<<<<< HEAD

=======
>>>>>>> 5540056b7ff63c2156966a24b98c10b364fcf179
        private int health;
        public int Health 
        { 
            get {return health; } 
            set 
            {
                if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            } 
        }

<<<<<<< HEAD
      
        public int MaxHealth { get; private set; }

    
        public PotionInventory Inventory { get; set; }
=======
>>>>>>> 5540056b7ff63c2156966a24b98c10b364fcf179

        public Elf(string name, int attackValue, int defenseValue, int health = 100)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
            this.Health = health;
<<<<<<< HEAD
            this.MaxHealth = health; 
            
        
            this.Inventory = new PotionInventory(); 
=======
>>>>>>> 5540056b7ff63c2156966a24b98c10b364fcf179
        }

        public bool IsAlive()
        {
            return this.Health > 0;
        }
    
        public void ReceiveAttack(int attackValue)
        {
            int damage = attackValue - this.DefenseValue;
            if (damage > 0) 
            {
                this.Health -= damage;
            }
        }

        public void AttackOthers(Elf target, Spear spear)
        {
<<<<<<< HEAD
       
            int totalDamage = this.AttackValue + spear.AttackValue;
            target.ReceiveAttack(totalDamage);
        }

        public void HealCompletely() => this.Health = this.MaxHealth;

        public void ReceiveHealing(int points)
        {
            this.Health += points; 
          
            if (this.Health > this.MaxHealth) 
            {
                this.Health = this.MaxHealth;
            }
=======
            target.ReceiveAttack(spear.AttackValue);
            
        }

        public void HealCompletely() => this.Health = 100;

        public void ReceiveHealing(int points)
        {
            this.Health += points; // el setter ya se encarga de no pasar de 0
>>>>>>> 5540056b7ff63c2156966a24b98c10b364fcf179
        }

        public void ThrowPotion(Potion potion, Elf target)
        {
<<<<<<< HEAD
           
            if (this.Inventory.Contains(potion))
            {
                target.ReceiveHealing(potion.HealingPower);
                this.Inventory.RemovePotion(potion);
                Console.WriteLine($"{this.Name} threw a potion at {target.Name}.");
=======
            if (potionInventory.Contains(potion))
            {
                target.ReceiveHealing(potion.HealingPower);
                potionInventory.Remove(potion);
>>>>>>> 5540056b7ff63c2156966a24b98c10b364fcf179
            }
        }
    }
}
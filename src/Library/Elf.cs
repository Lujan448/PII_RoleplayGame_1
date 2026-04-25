using System;

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

      
        public int MaxHealth { get; private set; }

    
        public PotionInventory Inventory { get; set; }

        public Elf(string name, int attackValue, int defenseValue, int health = 100)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
            this.Health = health;
            this.MaxHealth = health; 
            
        
            this.Inventory = new PotionInventory(); 
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
        }

        public void ThrowPotion(Potion potion, Elf target)
        {
           
            if (this.Inventory.Contains(potion))
            {
                target.ReceiveHealing(potion.HealingPower);
                this.Inventory.RemovePotion(potion);
                Console.WriteLine($"{this.Name} threw a potion at {target.Name}.");
            }
        }
    }
}
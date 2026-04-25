using System;
using System.Collections.Generic;
using Potions;
using PotionsInventory;
using Spears;

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


        public Elf(string name, int attackValue, int defenseValue, int health = 100)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
            this.Health = health;
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
            target.ReceiveAttack(spear.AttackValue);
        }

        public void ChangeSpear(Spear newSpear)
        {
            this.AttackValue = newSpear.AttackValue;
            this.DefenseValue = newSpear.DefenseValue;
        }
        
        public void HealCompletely() => this.Health = 100;

        public void ReceiveHealing(int points)
        {
            this.Health += points; // el setter ya se encarga de no pasar de 0
        }

        public void ThrowPotion(Potion potion, Elf target, PotionInventory inventory)
        {
            if (inventory.HasPotion(potion))
            {
                target.ReceiveHealing(potion.HealingPower);
                inventory.RemovePotion(potion);
            }
        }
    }
}
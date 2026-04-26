using System;
using System.Collections.Generic;
using Potions;
using PotionsInventory;
using Spears;

namespace Elfs
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

        private int maxHealth;
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
                else if (value > maxHealth)
                {
                    health = maxHealth;
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
            this.maxHealth = health;
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

        public void ChangeSpear(Spear newSpear)
        {
            this.AttackValue = newSpear.AttackValue;
        }
        
        public void HealCompletely() => this.Health = maxHealth;

        //Es el encargado de curar a alguien y que le quede su vida inicial
        public void ThrowPotion(Potion potion, Elf target, PotionInventory inventory)
        {
            if (inventory.HasPotion(potion))
            {
                target.HealCompletely();
                inventory.RemovePotion(potion);
            }
        }
    }
}
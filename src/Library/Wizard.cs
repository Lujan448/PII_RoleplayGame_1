using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Linq;
using Spells;
using SpellBooks;
using MagicStaffs;
using Tunics;

namespace Ucu.Poo.RolePlayGame
{
    public class Wizard
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

        //método constructor.
        public Wizard(string name, int attackValue, int defenseValue, int health = 100)
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

        //Es el encargado de poder aumentar su defensa con hechizos, es el único hechizo existente hasta ahora.
        public void DefendWithSpell(SpellBook book, Spell spell)
        {
            if(book.HasSpell(spell))
            {
                this.DefenseValue += spell.DefenseValue;
            } 
        }

        public void AttackWithMagicStaff(Wizard target, MagicStaff staff)
        {
            target.ReceiveAttack(staff.AttackValue);
        }

        public void ChangeStaff(MagicStaff newStaff)
        {
            this.AttackValue = newStaff.AttackValue;  
        }

        public void ChangeTunic(Tunic newTunic)
        {
            this.DefenseValue = newTunic.DefenseValue;
            
        }

        public void ProtectWithTunic(Tunic tunic)
        {
            this.DefenseValue += tunic.DefenseValue;
        }

        //Aunque no es el encargado de calcular el total de ataque,
        //nos parecía bueno calcularselo porque tiene bastantes acciones de ataque también.
        public int AttackTotal(MagicStaff staff)
        {
            int totalAttack = this.AttackValue + staff.AttackValue;
            return totalAttack;
        }

        //Es el encargado de calcular el total de valor de defensa que tiene el personaje.
        public int DefenseTotal(SpellBook book, Tunic tunic)
        {
            int totalSpellDefense = book.TotalSpellDefense();
            int totalDefense = this.DefenseValue + tunic.DefenseValue + totalSpellDefense;
            return totalDefense;
        }
    }
}
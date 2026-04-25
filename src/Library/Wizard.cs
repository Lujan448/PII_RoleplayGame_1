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

        //método constructor.
        public Wizard(string name, int attackValue, int defenseValue, int health)
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

        public void AttackOthers(Wizard target, SpellBook book, Spell spell)
        {
            if(book.HasSpell(spell))
            {
                target.ReceiveAttack(spell.AttackValue);
            } 
        }

        public void AttackWithMagicStaff(Wizard target, MagicStaff staff)
        {
            target.ReceiveAttack(staff.AttackValue);
        }

        public void ChangeStaff(MagicStaff oldStaff, MagicStaff newStaff)
        {
            this.AttackValue -= oldStaff.AttackValue;   //resta el viejo valor del bastón
            oldStaff.RemoveMagicStaff();
            this.AttackValue += newStaff.AttackValue;   //suma el nuevo valor del bastón
        }

        public void ProtectWithTunic(Tunic tunic)
        {
            this.DefenseValue += tunic.DefenseValue;
        }

        public int AttackTotal(MagicStaff staff, SpellBook book)
        {
            int totalSpellAttack = book.SpellList.Sum(spell => spell.AttackValue);
            int totalAttack = this.AttackValue + staff.AttackValue + totalSpellAttack;
            return totalAttack;
        }
    }
}
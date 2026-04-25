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
       
        public string Name { get; set; }
        public int AttackValue { get;set; }
        public int DefenseValue { get;set; }
        public int Health { get; set; }

        //método constructor.
        public Wizard(string Name, int AttackValue, int DefenseValue, int Health)
        {
            this.Name = Name;
            this.AttackValue = AttackValue;
            this.DefenseValue = DefenseValue;
            this.Health = Health;
        }
        public bool IsAlive()
        {
            if (this.Health < 0)        //En caso de que la vida sea negativa lo que hago es convertirla en 0;
            {                           //ya que nadie tiene vida en negativo.
                this.Health = 0;
            }
            return this.Health > 0;
        }
    
        public void ReceiveAttack(int attackValue)
        {
            int damage = attackValue - this.DefenseValue;
            if (damage > 0) 
            {
                this.Health -= damage;
            }
            else if (this.Health < 0) 
            {
                this.Health = 0;
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
            oldStaff.RemoveMagicStaff();
            this.AttackValue += newStaff.AttackValue;   
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
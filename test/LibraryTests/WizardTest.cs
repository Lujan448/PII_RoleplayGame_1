using System.Reflection;
using NUnit.Framework;
using SpellBooks;
using Spells;
using Ucu.Poo.RolePlayGame;
using MagicStaffs;
using Tunics;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class TestClass
    {
        [Test]
        public void IsNameCorrect()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            Assert.That(wizard.Name, Is.EqualTo("Nombre"));
        }

        [Test]
        public void IsAliveCorrect()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            Assert.That(wizard.IsAlive(), Is.True);
        }

        [Test]
        public void IsNotAliveCorrect()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 0);
            Assert.That(wizard.IsAlive(), Is.False);
        }

        [Test]
        public void IsReceiveAttackCorrect()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ReceiveAttack(30);
            Assert.That(wizard.Health, Is.EqualTo(80));
        }

        [Test]
        public void IsReceiveAttackInCorrect()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ReceiveAttack(5);
            Assert.That(wizard.Health, Is.EqualTo(100)); // al dar un número negativo la vida no cambia
        }

        [Test]
        public void IsAttackCorrect()
        {
            Wizard target = new Wizard("Nombre", 30, 5, 100);
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            SpellBook spellList = new SpellBook();
            Spell spell = new Spell(15,"Nombre");
            spellList.AddSpell(spell);
            wizard.AttackOthers(target, spellList, spell);
            Assert.That(target.Health, Is.EqualTo(90));
        }

        [Test]
        public void IsAttackIncorrect()
        {
            Wizard target = new Wizard("Nombre", 30, 5, 100);
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            SpellBook spellList = new SpellBook();
            Spell spell = new Spell(15, "Nombre");
            wizard.AttackOthers(target, spellList, spell);
            Assert.That(target.Health, Is.EqualTo(100));   //al no existir un spell en la lista, la vida queda igual
        }

        [Test]
        public void IsAttackWithStaffCorrect()
        {
            Wizard target = new Wizard("Nombre", 30, 5, 100);
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            MagicStaff staff = new MagicStaff(15);
            wizard.AttackWithMagicStaff(target, staff);
            Assert.That(target.Health, Is.EqualTo(90));
        }

        [Test]
        public void IsChangeStaffCorrect()
        {
            MagicStaff oldstaff = new MagicStaff(5);
            MagicStaff newstaff = new MagicStaff(25);
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ChangeStaff(oldstaff, newstaff);
            Assert.That(oldstaff.AttackValue, Is.EqualTo(0));
            Assert.That(wizard.AttackValue, Is.EqualTo(40));
        }

        [Test]
        public void IsProtectTunicCorrect()
        {
            Tunic tunic = new Tunic(10);
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ProtectWithTunic(tunic);
            Assert.That(wizard.DefenseValue, Is.EqualTo(20));
        }

        [Test]
        public void IsAttackTotalCorrect()
        {
            MagicStaff staff = new MagicStaff(15);
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            Spell spell = new Spell(15,"Nombre");
            spellBook.AddSpell(spell);
            int result = wizard.AttackTotal(staff, spellBook);
            Assert.That(result, Is.EqualTo(50));
        }

        [Test]
        public void IsAttackTotalIncorrect()              //En caso de no agregar spells solo uso el ataque del bastón mágico
        {
            MagicStaff staff = new MagicStaff(15);
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            int result = wizard.AttackTotal(staff, spellBook);
            Assert.That(result, Is.EqualTo(35));
        }
    }
}
    

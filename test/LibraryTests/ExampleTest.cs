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
            Assert.That(wizard.Health, Is.Not.EqualTo(100)); // al dar un número negativo la vida no cambia
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
    }
}
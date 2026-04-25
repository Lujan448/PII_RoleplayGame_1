using System.Reflection;
using NUnit.Framework;
using Archers;
using Bows;
using Daggers;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class ArcherTest
    {
        [Test]
        public void IsNameCorrect()
        {
            Archer archer = new Archer("Nombre", 20, 10, 100);
            Assert.That(archer.Name, Is.EqualTo("Nombre"));
        }

        [Test]
        public void IsAliveCorrect()
        {
            Archer archer = new Archer("Nombre", 20, 10, 100);
            Assert.That(archer.IsAlive(), Is.True);
        }

        [Test]
        public void IsNotAliveCorrect()
        {
            Archer archer = new Archer("Nombre", 20, 10, 0);
            Assert.That(archer.IsAlive(), Is.False);
        }

        [Test]
        public void IsReceiveAttackCorrect()
        {
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ReceiveAttack(30);
            Assert.That(archer.Health, Is.EqualTo(80));
        }

        [Test]
        public void IsReceiveAttackInCorrect()
        {
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ReceiveAttack(5);
            Assert.That(archer.Health, Is.EqualTo(100)); // al dar un número negativo la vida no cambia
        }

        [Test]
        public void IsAttackWithBowCorrect()
        {
            Archer target = new Archer("Nombre", 30, 5, 100);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            Bow bow = new Bow(15);
            archer.AttackWithBow(target, bow);
            Assert.That(target.Health, Is.EqualTo(90));
        }

        [Test]
        public void IsAttackWithDaggerCorrect()
        {
            Archer target = new Archer("Nombre", 30, 5, 100);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            Dagger dagger = new Dagger(5);
            archer.AttackWithDagger(target, dagger);
            Assert.That(target.Health, Is.EqualTo(100));
        }

        [Test]
        public void IsChangeBowCorrect()
        {
            Bow oldbow = new Bow(5);
            Bow newbow = new Bow(10);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ChangeBow(oldbow, newbow);
            Assert.That(oldbow.AttackValue, Is.EqualTo(0));
            Assert.That(archer.AttackValue, Is.EqualTo(25));
        }

        [Test]
        public void IsChangeDaggerCorrect()
        {
            Dagger olddagger = new Dagger(5);
            Dagger newdagger = new Dagger(10);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ChangeDagger(olddagger, newdagger);
            Assert.That(olddagger.AttackValue, Is.EqualTo(0));
            Assert.That(archer.AttackValue, Is.EqualTo(25));
        }

        [Test]
        public void IsAttackTotalCorrect()
        {
            Bow bow = new Bow(15);
            Dagger dagger = new Dagger(5);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            int result = archer.AttackTotal(dagger, bow);
            Assert.That(result, Is.EqualTo(40));
        }

        [Test]
        public void IsAttackTotalIncorrect()              
        {
            Bow bow = new Bow(15);
            Dagger dagger = new Dagger(5);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            int result = archer.AttackTotal(dagger, bow);
            Assert.That(result, Is.Not.EqualTo(99));    
        }
    }
}
    

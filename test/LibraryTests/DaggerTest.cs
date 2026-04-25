using Daggers;
using NUnit.Framework;

namespace DaggerTests
{
    [TestFixture]
    public class DaggerTest
    {
        // en esta parte se verifica que el constructor inicializa bien los valores
        [Test]
        public void SetsAttackValue()
        {
            Dagger dagger = new Dagger(10);
            Assert.That(dagger.AttackValue, Is.EqualTo(10));
        }

        [Test]
        public void DefenseValueStartsAtZero()
        {
            Dagger dagger = new Dagger(50);
            Assert.That(dagger.DefenseValue, Is.EqualTo(0));
        }

        // se remueve la daga en caso de que AttackValue > 0, lo pone en 0
        [Test]
        public void RemoveDaggerWhenAttackIsPositiveSetsAttackValueToZero()
        {
            Dagger dagger = new Dagger(10);
            dagger.AttackValue = 10; 
            dagger.RemoveDagger();
            Assert.That(dagger.AttackValue, Is.EqualTo(0));
        }

        [Test]
        public void RemoveDaggerWhenAttackIsZeroStayZero()
        {
            Dagger dagger = new Dagger(10);
            dagger.RemoveDagger(); 
            Assert.That(dagger.AttackValue, Is.EqualTo(0));
        }
    }
}
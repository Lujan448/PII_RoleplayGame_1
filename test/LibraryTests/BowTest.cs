using Bows;
using NUnit.Framework;

namespace BowTests
{
    [TestFixture]
    public class BowTest
    {
        // en esta parte se verifica que el constructor inicializa bien los valores
        [Test]
        public void SetsAttackValue()
        {
            Bow bow = new Bow(50);
            Assert.That(bow.AttackValue, Is.EqualTo(50));
        }

        [Test]
        public void DefenseValueStartsAtZero()
        {
            Bow bow = new Bow(50);
            Assert.That(bow.DefenseValue, Is.EqualTo(0));
        }

        // se remueve el arco en caso de que AttackValue > 0, lo pone en 0
        [Test]
        public void RemoveBowWhenAttackIsPositiveSetsAttackValueToZero()
        {
            Bow bow = new Bow(50);
            bow.AttackValue = 10; 
            bow.RemoveBow();
            Assert.That(bow.AttackValue, Is.EqualTo(0));
        }

        [Test]
        public void RemoveBowWhenAttackIsZeroStayZero()
        {
            Bow bow = new Bow(50);
            bow.RemoveBow(); 
            Assert.That(bow.AttackValue, Is.EqualTo(0));
        }
    }
}
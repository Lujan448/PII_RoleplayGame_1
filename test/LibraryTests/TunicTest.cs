using Tunics;
using NUnit.Framework;

namespace TunicTests
{
    [TestFixture]
    public class TunicTest
    {
        // en esta parte se verifica que el constructor inicializa bien los valores
        [Test]
        public void SetsDefenseValue()
        {
            Tunic tunic = new Tunic(50);
            Assert.That(tunic.DefenseValue, Is.EqualTo(50));
        }

        [Test]
        public void AttackValueStartsAtZero()
        {
            Tunic tunic = new Tunic(50);
            Assert.That(tunic.AttackValue, Is.EqualTo(0));
        }

        // se remueve la tunica en caso de que AttackValue > 0, lo pone en 0
        [Test]
        public void RemoveTunicWhenAttackIsPositiveSetsAttackValueToZero()
        {
            Tunic tunic = new Tunic(50);
            tunic.AttackValue = 10; 
            tunic.RemoveTunic();
            Assert.That(tunic.AttackValue, Is.EqualTo(0));
        }

        [Test]
        public void RemoveTunicWhenAttackIsZeroStayZero()
        {
            Tunic tunic = new Tunic(50);
            tunic.RemoveTunic(); 
            Assert.That(tunic.AttackValue, Is.EqualTo(0));
        }

        // Devuelve el valor total de la defensa
        [Test]
        public void DefenseTotalReturnsCorrectValue()
        {
            Tunic tunic = new Tunic(30);
            Assert.That(tunic.DefenseTotal(), Is.EqualTo(30));
        }
    }
}
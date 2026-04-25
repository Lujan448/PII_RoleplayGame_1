using Spells;
using NUnit.Framework;


namespace SpellTests
{
    [TestFixture]
    public class SpellTest
    {
        // en esta parte se verifica que el constructor inicializa bien los valores
        [Test]
        public void SetsAttackValue()
        {
            Spell spell = new Spell(50, "Nombre");
            Assert.That(spell.AttackValue, Is.EqualTo(50));
        }

        [Test]
        public void DefenseValueStartsAtZero()
        {
            Spell spell = new Spell(50, "Nombre");
            Assert.That(spell.DefenseValue, Is.EqualTo(0));
        }

        [Test]
        public void NameIsCorrect()
        {
            Spell spell = new Spell(50, "Nombre");
            Assert.That(spell.Name, Is.EqualTo("Nombre"));
        }
    }
}
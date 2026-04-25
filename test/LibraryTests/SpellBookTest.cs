using Spells;
using SpellBooks;
using NUnit.Framework;

namespace SpellBookTests
{
    [TestFixture]
    public class SpellBookTest
    {
        //HasSpell devuelve false si no se agregó el spell a la lista
        [Test]
        public void HasSpellReturnsFalseIfSpellNotAdded()
        {
            SpellBook book = new SpellBook();
            Spell spell = new Spell(50, "Nombre");
            Assert.That(book.HasSpell(spell), Is.False);
        }

        //AddSpell y HasSpell se verifican juntos, ya que los métodos depende del otro para que funcionen y de correcto
        [Test]
        public void HasSpellReturnsTrueAfterAddSpell()
        {
            SpellBook book = new SpellBook();
            Spell spell = new Spell(50, "Nombre");
            book.AddSpell(spell);
            Assert.That(book.HasSpell(spell), Is.True);
        }

        [Test]
        public void TotalSpellAttackReturnsCorrectSum()
        {
            SpellBook book = new SpellBook();
            Spell spell = new Spell(50, "Nombre");
            book.AddSpell(spell);
            Assert.That(book.TotalSpellAttack(), Is.EqualTo(50));
        }
    }
}
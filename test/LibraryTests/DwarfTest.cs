using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{

    [TestFixture]
    public class DwarfTest
    {

    [Test]
    public void Shield_IncreaseDefense()
        {

            Dwarf a = new Dwarf ("A", 20, 0);
            Dwarf b = new Dwarf ("B", 10, 0);

            Shield shield = new Shield(10);
            b.EquipShield(shield);

            a.Attack(b);

            Assert.That(b.Health, Is.EqualTo(90));
        }
        

    [Test]
    public void Axe_IncreaseAttack()
        {
            Dwarf a = new Dwarf ("A", 20, 0);
            Dwarf b = new Dwarf ("B", 10, 0);

            Axe axe = new Axe (10);
            a.EquipAxe(axe);

            a.Attack(b);

            Assert.That(b.Health, Is.EqualTo(70));
        }

    [Test]
    public void Attack_ReducesHealth()
        {
            Dwarf a = new Dwarf ("A", 20, 0);
            Dwarf b = new Dwarf ("B", 10, 0);
            
            a.Attack(b);

            Assert.That(b.Health, Is.EqualTo(80));
        }
    
    [Test]
    public void DrawfDies_WhenHealthIsZero()
        {
            Dwarf a = new Dwarf ("A", 200, 0);
            Dwarf b = new Dwarf ("B", 10, 0);
                
            a.Attack(b);
            
            Assert.That(b.IsAlive, Is.False);
        }
    }       
}

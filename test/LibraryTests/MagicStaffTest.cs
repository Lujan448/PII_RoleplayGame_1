using MagicStaffs;
using NUnit.Framework;

namespace MagicStaffTests
{
    [TestFixture]
    public class MagicStaffTest
    {
        // en esta parte se verifica que el constructor inicializa bien los valores
        [Test]
        public void SetsAttackValue()
        {
            MagicStaff staff = new MagicStaff(50);
            Assert.That(staff.AttackValue, Is.EqualTo(50));
        }

        [Test]
        public void DefenseValueStartsAtZero()
        {
            MagicStaff staff = new MagicStaff(50);
            Assert.That(staff.DefenseValue, Is.EqualTo(0));
        }

        // se remueve el bastón en caso de que AttackValue > 0, lo pone en 0
        [Test]
        public void RemoveMagicStaffWhenAttackIsPositiveSetsAttackValueToZero()
        {
            MagicStaff staff = new MagicStaff(50);
            staff.AttackValue = 10; 
            staff.RemoveMagicStaff();
            Assert.That(staff.AttackValue, Is.EqualTo(0));
        }

        [Test]
        public void RemoveMagicStaffWhenAttackIsZeroStayZero()
        {
            MagicStaff staff = new MagicStaff(50);
            staff.RemoveMagicStaff(); 
            Assert.That(staff.AttackValue, Is.EqualTo(0));
        }
    }
}
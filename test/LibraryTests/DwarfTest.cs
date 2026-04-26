using Dwarfs;
using Elfs;
using NUnit.Framework;

namespace DwarfsTests
{

    [TestFixture]
    public class DwarfTest
    {
        //Es el encargado de probar si el enano esta vivo, si lo esta devuelve true
        [Test]
        public void IsAlive_WhenHealthIsPositive_ReturnsTrue()
        {
            Dwarf dwarf = new Dwarf("Nombre", 20, 10, 100);
            Assert.That(dwarf.IsAlive(), Is.True);
        }

        //Es el encargado de probar si el enano esta vivo, si no lo esta devuleve false
        [Test]
        public void IsAlive_WhenHealthIsZero_ReturnsFalse()
        {
            Dwarf dwarf = new Dwarf("Nombre", 20, 10, 0);
            Assert.That(dwarf.IsAlive(), Is.False);
        }

        //Es el encargado de verificar si es correcto que al recibir ataques cuando daño excede a la defensa, se decrece asi su vida
        [Test]
        public void ReceiveAttack_WhenDamageExceedsDefense_DecreasesHealth()
        {
            Dwarf dwarf = new Dwarf("Nombre", 20, 10, 100);
            dwarf.ReceiveAttack(30);
            Assert.That(dwarf.Health, Is.EqualTo(80));
        }

        //Es el encargado de verificar si es incorrecto, ya que el daño es menor que la defensa no le va a hacer nada.
        [Test]
        public void ReceiveAttack_WhenDamageLessThanDefense_HealthUnchanged()
        {
            Dwarf dwarf = new Dwarf("Nombre", 20, 10, 100);
            dwarf.ReceiveAttack(5);
            Assert.That(dwarf.Health, Is.EqualTo(100)); // al dar un número negativo la vida no cambia
        }

        //Es el encargado de verificar que cuando se ataca a un elfo este pierde vida
        [Test]
        public void AttackElfs_WhenAxeEquipped_DecreasesElfHealth()
        {
            Dwarf dwarf = new Dwarf("Nombre", 30, 5, 100);
            Elf elf = new Elf("Nombre", 20, 10, 100);
            Axe axe = new Axe(15);
            dwarf.AttackElfs(elf, axe);
            Assert.That(elf.Health, Is.EqualTo(95));
        }

        //Verifica si se cambia correctamente el hacha
        [Test]
        public void ChangeAxe_WhenNewAxeEquipped_UpdatesAttackValue()
        {
            Axe newAxe = new Axe(10);
            Dwarf dwarf = new Dwarf("Nombre", 20, 10, 100);
            dwarf.ChangeAxe(newAxe);
            Assert.That(dwarf.AttackValue, Is.EqualTo(10));
        }

        //Verifica si se cambia correctamente el escudo
        [Test]
        public void ChangeShield_WhenNewShieldEquipped_UpdatesAttackValue()
        {
            Shield newShield = new Shield(5);
            Dwarf dwarf = new Dwarf("Nombre", 20, 10, 100);
            dwarf.ChangeShield(newShield);
            Assert.That(dwarf.DefenseValue, Is.EqualTo(5));
        }
    }
}
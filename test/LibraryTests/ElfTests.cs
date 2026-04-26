using NUnit.Framework;
using Elfs;

namespace ElfTests
{
    [TestFixture]
    public class ElfTests
    {
        //Es el encargado de probar si el elfo esta vivo, si lo esta devuelve true
        [Test]
        public void IsAlive_WhenHealthIsPositive_ReturnsTrue()
        {
            Elf elf = new Elf("Nombre", 20, 10, 100);
            Assert.That(elf.IsAlive(), Is.True);
        }

        //Es el encargado de probar si el elfo esta vivo, si no lo esta devuleve false
        [Test]
        public void IsAlive_WhenHealthIsZero_ReturnsFalse()
        {
            Elf elf = new Elf("Nombre", 20, 10, 0);
            Assert.That(elf.IsAlive(), Is.False);
        }

        //Es el encargado de verificar si es correcto que al recibir ataques cuando daño excede a la defensa, se decrece asi su vida
        [Test]
        public void ReceiveAttack_WhenDamageExceedsDefense_DecreasesHealth()
        {
            Elf elf = new Elf("Nombre", 20, 10, 100);
            elf.ReceiveAttack(30);
            Assert.That(elf.Health, Is.EqualTo(80));
        }

        //Es el encargado de verificar si es incorrecto, ya que el daño es menor que la defensa no le va a hacer nada.
        [Test]
        public void ReceiveAttack_WhenDamageLessThanDefense_HealthUnchanged()
        {
            Elf elf = new Elf("Nombre", 20, 10, 100);
            elf.ReceiveAttack(5);
            Assert.That(elf.Health, Is.EqualTo(100)); // al dar un número negativo la vida no cambia
        }

        //Verifica si se cambia correctamente la lanza
        [Test]
        public void ChangeSpear_WhenNewSpearEquipped_UpdatesAttackValue()
        {
            Spear newSpear = new Spear(10);
            Elf elf = new Elf("Nombre", 20, 10, 100);
            elf.ChangeSpear(newSpear);
            Assert.That(elf.AttackValue, Is.EqualTo(10));
        }
        
        //Esta perte se encarga de verificar que al tirarle una pocion a un target se le recupera la vida máxima establecida
        //la cual es 100.
        [Test]
        public void ThrowPotion_InjuredTarget_IncreasesTargetHealth()
        {
            Elf attacker = new Elf("Nombre1", 10, 5, 100);
            Potion potion = new Potion("Healing", 10);
            PotionInventory inventory = new PotionInventory();
            inventory.AddPotion(potion);
            Elf target = new Elf("Nombre2", 10, 0, 100);
            target.ReceiveAttack(50);
            attacker.ThrowPotion(potion, target, inventory);
            Assert.That(target.Health, Is.EqualTo(100)); // HealCompletely restaura vida máxima
        }
    }  
}
using NUnit.Framework;
using Archers;

namespace ArchersTests
{
    [TestFixture]
    public class ArcherTest
    {   
        //Es el encargado de probar si el arquero esta vivo, si lo esta devuelve true
        [Test]
        public void IsAlive_WhenHealthIsPositive_ReturnsTrue()
        {
            Archer archer = new Archer("Nombre", 20, 10, 100);
            Assert.That(archer.IsAlive(), Is.True);
        }

        //Es el encargado de probar si el arquero esta vivo, si no lo esta devuleve false
        [Test]
        public void IsAlive_WhenHealthIsZero_ReturnsFalse()
        {
            Archer archer = new Archer("Nombre", 20, 10, 0);
            Assert.That(archer.IsAlive(), Is.False);
        }

        //Es el encargado de verificar si es correcto que alrecibir ataques cuando daño excede a la defensa, se decrece asi su vida
        [Test]
        public void ReceiveAttack_WhenDamageExceedsDefense_DecreasesHealth()
        {
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ReceiveAttack(30);
            Assert.That(archer.Health, Is.EqualTo(80));
        }

        //Es el encargado de verificar si es incorrecto, ya que el daño es menor que la defensa no le va a hacer nada.
        [Test]
        public void ReceiveAttack_WhenDamageLessThanDefense_HealthUnchanged()
        {
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ReceiveAttack(5);
            Assert.That(archer.Health, Is.EqualTo(100)); // al dar un número negativo la vida no cambia
        }

        //Verifica si se cambia correctamente el arco
        [Test]
        public void ChangeBow_WhenNewBowEquipped_UpdatesAttackValue()
        {
            Bow oldbow = new Bow(5);
            Bow newbow = new Bow(10);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ChangeBow(newbow);
            Assert.That(archer.AttackValue, Is.EqualTo(25));
        }

        //Verifica si se cambia correctamente la daga
        [Test]
        public void ChangeDagger_WhenNewDaggerEquipped_UpdatesAttackValue()
        {
            Dagger olddagger = new Dagger(5);
            Dagger newdagger = new Dagger(10);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            archer.ChangeDagger(newdagger);
            Assert.That(archer.AttackValue, Is.EqualTo(25));
        }

        //Verifica si el ataque total retorna la suma correcta
        [Test]
        public void AttackTotal_WithBowAndDagger_ReturnsSumCorrectly()
        {
            Bow bow = new Bow(15);
            Dagger dagger = new Dagger(5);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            int result = archer.AttackTotal(dagger, bow);
            Assert.That(result, Is.EqualTo(40));
        }

        //Verifica en caso de que la suma no retorne la suma correcta
        [Test]
        public void AttackTotal_WithBowAndDagger_DoesNotReturnWrongValue()              
        {
            Bow bow = new Bow(15);
            Dagger dagger = new Dagger(5);
            Archer archer = new Archer("Nombre", 20, 10, 100);
            int result = archer.AttackTotal(dagger, bow);
            Assert.That(result, Is.Not.EqualTo(99));    
        }
    }
}
    

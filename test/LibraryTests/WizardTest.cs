using NUnit.Framework;
using Spells;
using Wizards;


namespace WizardsTests
{
    [TestFixture]
    public class WizardTest
    {
        //Es el encargado de probar si el hechicero esta vivo, si lo esta devuelve true
        [Test]
        public void IsAlive_WhenHealthIsPositive_ReturnsTrue()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            Assert.That(wizard.IsAlive(), Is.True);
        }

        //Es el encargado de probar si el hechicero esta vivo, si no lo esta devuleve false
        [Test]
        public void IsAlive_WhenHealthIsZero_ReturnsFalse()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 0);
            Assert.That(wizard.IsAlive(), Is.False);
        }

        //Es el encargado de verificar si es correcto que alrecibir ataques cuando daño excede a la defensa, se decrece asi su vida
        [Test]
        public void ReceiveAttack_WhenDamageExceedsDefense_DecreasesHealth()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ReceiveAttack(30);
            Assert.That(wizard.Health, Is.EqualTo(80));
        }

        //Es el encargado de verificar si es incorrecto, ya que el daño es menor que la defensa no le va a hacer nada.
        [Test]
        public void ReceiveAttack_WhenDamageLessThanDefense_HealthUnchanged()
        {
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ReceiveAttack(5);
            Assert.That(wizard.Health, Is.EqualTo(100)); // al dar un número negativo la vida no cambia
        }

        //Verifica si se cambia correctamente el bastón mágico
        [Test]
        public void ChangeStaff_WhenNewStaffEquipped_UpdatesAttackValue()
        {
            MagicStaff oldstaff = new MagicStaff(5);
            MagicStaff newstaff = new MagicStaff(25);
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ChangeStaff(newstaff);
            Assert.That(wizard.AttackValue, Is.EqualTo(40));
        }

        //Verifica si el valor de la protección de la tunica es el correcto
        [Test]
        public void ProtectWithTunic_WhenTunicEquipped_IncreasesDefenseValue()
        {
            Tunic tunic = new Tunic(10);
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            wizard.ProtectWithTunic(tunic);
            Assert.That(wizard.DefenseValue, Is.EqualTo(20));
        }

        //Verifica si la defensa total retorna la suma correcta
        [Test]
        public void DefenseTotal_WithSpells_ReturnsCorrectValue()
        {
            Tunic tunic = new Tunic(15);
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Nombre", 10, 20, 100);
            Spell spell = new Spell("Nombre", 5);
            spellBook.AddSpell(spell);
            int result = wizard.DefenseTotal(spellBook, tunic);
            Assert.That(result, Is.EqualTo(40));
        }

        //Verifica en caso de que la suma no retorne la suma correcta
        [Test]
        public void DefenseTotal_WithoutSpells_ReturnsWrongValue()     //En caso de no agregar spells solo uso la defensa de la tunica
        {
            Tunic tunic = new Tunic(15);
            SpellBook spellBook = new SpellBook();
            Wizard wizard = new Wizard("Nombre", 20, 10, 100);
            int result = wizard.DefenseTotal(spellBook, tunic);
            Assert.That(result, Is.EqualTo(40));
        }
    }
}
    

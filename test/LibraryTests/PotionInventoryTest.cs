using Elfs;
using NUnit.Framework;

namespace PotionInventoryTests
{
    [TestFixture]
    public class PotionInventoryTest
    {
        //Es el encargado de verificar si la lista de pociones tiene una pocion, si es asi devuelve true
        [Test]
        public void HasPotion_WhenPotionAdded_ReturnsTrue()
        {
            PotionInventory inventory = new PotionInventory();
            Potion potion = new Potion("healing", 50);
            inventory.AddPotion(potion);
            Assert.That(inventory.HasPotion(potion), Is.True);
        }

        //Es el encargado de verificar si la lista de pociones tiene una pocion, si no es asi devuelve false
        [Test]
        public void HasPotion_WhenPotionNotAdded_ReturnsFalse()
        {
            PotionInventory inventory = new PotionInventory();
            Potion potion = new Potion("healing", 50);
            Assert.That(inventory.HasPotion(potion), Is.False);
        }

        //Es el encargado de verificar que la pocion ha sido removida 
        [Test]
        public void RemovePotion_WhenPotionRemoved_ReturnsFalse()
        {
            PotionInventory inventory = new PotionInventory();
            Potion potion = new Potion("healing", 50);
            inventory.AddPotion(potion);
            inventory.RemovePotion(potion);
            Assert.That(inventory.HasPotion(potion), Is.False);
        }
    } 
}
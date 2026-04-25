using System.Collections.Generic;

namespace ucudal
{
    public class PotionInventory
    {
        // Esta es la lista real, pero ahora es privada. 
        // Nadie de afuera puede tocarla directamente.
        private List<Potion> potions;

        // Constructor
        public PotionInventory()
        {
            this.potions = new List<Potion>();
        }

        // Método para agregar una poción
        public void AddPotion(Potion potion)
        {
            this.potions.Add(potion);
        }

        // Método para quitar una poción
        public void RemovePotion(Potion potion)
        {
            this.potions.Remove(potion);
        }

        // Método para saber si tenemos una poción específica
        public bool Contains(Potion potion)
        {
            return this.potions.Contains(potion);
        }
    }
}
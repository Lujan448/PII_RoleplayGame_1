using System.Collections.Generic;
using Potions;

namespace PotionsInventory
{
    public class PotionInventory
    {
        // Esta es la lista real, pero ahora es privada. 
        // Nadie de afuera puede tocarla directamente.
        private List<Potion> potions = new List<Potion>();

        // Método para agregar una poción
        public void AddPotion(Potion potion)
        {
            potions.Add(potion);
        }

        // Método para quitar una poción
        public void RemovePotion(Potion potion)
        {
            potions.Remove(potion);
        }

        // Método para saber si tenemos una poción específica
        public bool HasPotion(Potion potion)
        {
            return potions.Contains(potion);
        }
    }
}
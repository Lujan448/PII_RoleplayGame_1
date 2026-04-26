using System.Collections.Generic;
using Spells;

//Es la clase experta de la información que corresponde a el libro de hechizos.
namespace Wizards
{
    public class SpellBook
    {
        //Esta es la lista real, pero ahora es privada. 
        //Nadie de afuera puede tocarla directamente.
        private List<Spell> spellList = new List<Spell>();

        //Método para agregar un hechizo
        public void AddSpell(Spell spell)
        {
            this.spellList.Add(spell);
        }

        //Método para ver si hay un hechizo
        public bool HasSpell(Spell spell)
        {
            return spellList.Contains(spell);
        }

        //Método para calcular el valor total del hechizo de defensa.
        //Lo colocamos aca porque creemos que para realizarlo se tiene aquella información que
        //es necesaria, porque nosotros interactuamos en esta clase directamente con la clase spell, no necesitamos nada más.
        public int TotalSpellDefense()
        {
            int total = 0;
            foreach (Spell spell in spellList)
            {
                total += spell.DefenseValue;
            }
            return total;
        }
    }
}
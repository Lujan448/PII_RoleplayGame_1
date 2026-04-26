using System.Collections.Generic;
using Spells;

namespace SpellBooks
{
    public class SpellBook
    {
        private List<Spell> spellList = new List<Spell>();

        public void AddSpell(Spell spell)
        {
            this.spellList.Add(spell);
        }

        public bool HasSpell(Spell spell)
        {
            return spellList.Contains(spell);
        }

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
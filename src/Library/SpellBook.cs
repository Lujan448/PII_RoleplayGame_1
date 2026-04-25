using System.Collections.Generic;
using Spells;

namespace SpellBooks
{
    public class SpellBook
    {
        public List<Spell> SpellList = new List<Spell>();
        public void AddSpell(Spell spell)
        {
            this.SpellList.Add(spell);
        }

        public bool HasSpell(Spell spell)
        {
            return SpellList.Contains(spell);
        }
    }
}
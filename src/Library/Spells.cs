namespace Spells
{
    public class Spell
    {
        public int AttackValue {get ; set; }
        public int DefenseValue {get; set; }
        public string Name { get; set;}

        public Spell(int AttackValue, string Name)
        {
            this.AttackValue = AttackValue;
            this.DefenseValue = 0;
            this.Name = Name;
        }
    }
}
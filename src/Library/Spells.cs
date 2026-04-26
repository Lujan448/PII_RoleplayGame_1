namespace Spells
{
    public class Spell
    {
        private int attackValue;
        public int AttackValue 
        {
            get {return attackValue; }
            set {attackValue = value;} 
        }

        private int defenseValue;
        public int DefenseValue 
        {
            get {return defenseValue; } set {defenseValue = value; } 
        }

        private string name;
        public string Name 
        { 
            get {return name; } set {name = value;}
        }

        public Spell(string Name, int DefenseValue)
        {
            this.AttackValue = 0;
            this.DefenseValue = DefenseValue;
            this.Name = Name;
        }
    }
}
namespace Potions
{
    public class Potion
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

        private int healingPower;
        public int HealingPower
        {
            get {return healingPower; } set {healingPower = value;}
        }
        public Potion(int AttackValue, string Name, int HealingPower = 40)
        {
            this.AttackValue = AttackValue;
            this.DefenseValue = 0;
            this.Name = Name;
            this.HealingPower = HealingPower;
        }
    }
}
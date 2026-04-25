namespace Tunics
{
    public class Tunic
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

        public Tunic(int DefenseValue)
        {
            this.AttackValue = 0;
            this.DefenseValue = DefenseValue;
        }

         public void RemoveTunic()
        {
            if(this.AttackValue > 0)
            {
                this.AttackValue = 0;
            }
        }

        public int DefenseTotal()
        {
            int totalDefense = this.DefenseValue;
            return totalDefense;
        }
    }
}
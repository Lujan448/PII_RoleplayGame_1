namespace Tunics
{
    public class Tunic
    {
        public int AttackValue {get ; set; }
        public int DefenseValue {get; set; }

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
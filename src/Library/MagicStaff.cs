namespace MagicStaffs
{
    public class MagicStaff
    {
        public int AttackValue {get ; set; }
        public int DefenseValue {get; set; }

        public MagicStaff(int AttackValue)
        {
            this.AttackValue = AttackValue;
            this.DefenseValue = 0;
        }

         public void RemoveMagicStaff()
        {
            if(this.AttackValue > 0)
            {
                this.AttackValue = 0;
            }
        }
    }
}
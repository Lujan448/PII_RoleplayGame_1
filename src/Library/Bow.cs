namespace Library
{
    public class Bow
    {
        private int attackValue;
         public int AttackValue 
        { 
            get {return attackValue; } set {attackValue = value;} 
        }

        private int defenseValue;
        public int DefenseValue 
        { 
            get {return defenseValue; } set { defenseValue = value;}
        }


        public Bow(int AttackValue)
        {
            this.AttackValue = AttackValue;
            this.DefenseValue = 0;
        }

         public void RemoveBow()
        {
            if(this.AttackValue > 0)
            {
                this.AttackValue = 0;
            }
        }
        
    }
    
}



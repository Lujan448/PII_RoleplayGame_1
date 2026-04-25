using System.Data;

namespace Spears
{
    public class Spear
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

        public Spear(int attackValue)
        {
            this.AttackValue = attackValue;
            this.DefenseValue = 0;
        }

        //se quita la lanza dejando todos sus valores en 0
        public void RemoveSpear()
        {
            this.AttackValue = 0;
            this.DefenseValue = 0;
        }
    }     
}
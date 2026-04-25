using Bows;
using Daggers;

namespace Archers
{
    public class Archer
    {
        private string name;
        public string Name 
        { 
            get {return name; } set {name = value; } 
        }

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

        private int health;
        public int Health 
        { 
            get {return health; } 
            set 
            {
                if (value < 0)
                {
                    health = 0;
                }
                else
                {
                    health = value;
                }
            } 
        }

        public Archer(string name, int attackValue, int defenseValue, int health = 100)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
            this.Health = health;
        }


        public bool IsAlive()
        {
            return this.Health > 0;
        }
    
        public void ReceiveAttack(int attackValue)
        {
            int damage = attackValue - this.DefenseValue;
            if (damage > 0) 
            {
                this.Health -= damage;
            }
        }

        public void AttackWithBow(Archer target, Bow bow)
        {
                target.ReceiveAttack(bow.AttackValue);
        }

        public void AttackWithDagger(Archer target, Dagger dagger)
        {
            target.ReceiveAttack(dagger.AttackValue);
        }

        public void ChangeBow(Bow oldBow, Bow newBow)
        {
            this.AttackValue -= oldBow.AttackValue;   //resta el viejo valor del arco
            oldBow.RemoveBow();
            this.AttackValue += newBow.AttackValue;   //suma el nuevo valor del arco
        }

        public void ChangeDagger(Dagger oldDagger, Dagger newDagger)
        {
            this.AttackValue -= oldDagger.AttackValue;   //resta el viejo valor de la daga
            oldDagger.RemoveDagger();
            this.AttackValue += newDagger.AttackValue;   //suma el nuevo valor del arco
        }

        public int AttackTotal(Dagger dagger, Bow bow)
        {
            int totalAttack = this.AttackValue + dagger.AttackValue + bow.AttackValue;
            return totalAttack;
        }
    }  
}

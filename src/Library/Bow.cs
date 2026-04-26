//Es la clase experta de la información que corresponde a el arco.

namespace Archers
{
    public class Bow
    {
        //Se inicializan aquellas responsabilidades de conocer de la clase Bow
        //Valor de ataque y de defensa.
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

        //Ceamos al constructor 
        //En este caso como es un arma, su valor de defensa va a ser 0.
        public Bow(int AttackValue)
        {
            this.AttackValue = AttackValue;
            this.DefenseValue = 0;
        }
    } 
}



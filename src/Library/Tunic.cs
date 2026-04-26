//Es la clase experta de la información que corresponde a la tunica

namespace Wizards
{
    public class Tunic
    {
        //Se inicializan aquellas responsabilidades de conocer de la clase Shield
        //Valor de ataque y de defensa.
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

        //Ceamos al constructor 
        //En este caso como es parte de la armadura en si, su valor de ataque va a ser 0.
        public Tunic(int DefenseValue)
        {
            this.AttackValue = 0;
            this.DefenseValue = DefenseValue;
        }
    }
}
using System;
using Archers;
using Elfs;
using Dwarfs;
using Wizards;
using Spells;


//Es el Main, es el que se va a encargar de crear los objetos y probar los comportamientos de cada clase.
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elf
            Elf legolas = new Elf("Legolas", 15, 5);
            Potion potion = new Potion("Healing", 10);
            PotionInventory inventory = new PotionInventory();
            inventory.AddPotion(potion);
            Spear spear = new Spear(10);
            legolas.ChangeSpear(spear);


            //Dwarf
            Dwarf gimli = new Dwarf("Gimli", 20, 10);
            Axe axe = new Axe(17);
            Shield shield = new Shield(12);
            gimli.ChangeAxe(axe);
            gimli.ChangeShield(shield);


            //Archer
            Archer robin = new Archer("Robin", 18, 4);
            Bow bow = new Bow(16);
            Dagger dagger = new Dagger(5);
            robin.ChangeBow(bow);
            robin.ChangeDagger(dagger); 

            
            //Wizard
            Wizard snape = new Wizard("Snape", 5, 2);
            Spell spell = new Spell("Defense", 15);
            SpellBook book = new SpellBook();
            book.AddSpell(spell);
            MagicStaff staff = new MagicStaff(20);
            snape.ChangeStaff(staff);
            Tunic tunic = new Tunic(15);
            snape.ChangeTunic(tunic);
            

            Console.WriteLine("--- ESTADO INICIAL ---");
            Console.WriteLine($"{legolas.Name} tiene {legolas.Health} de vida");
            

            Console.WriteLine($"{gimli.Name} tiene {gimli.Health} de vida");
            Console.WriteLine($"{robin.Name} tiene {robin.Health} de vida");
            Console.WriteLine($"{snape.Name} tiene {snape.Health} de vida\n");

        
            //Nosotros queríamos que se pelearan unos entre otros, por ejemplo que el dwarf se pelee con el archer, pero
            //teníamos que crear un método para cada uno y hasta capaz la sobrecarga del método y no nos parecía lo mejor, solo agregamos aquellos métodos 
            //y las pruebas correspondientes para ellos para que se viera el funcionamiento y cumplimiento de la letra.

            Console.WriteLine("--- SIMULACIÓN DE COMBATE ---");
            Elf dobby = new Elf("Dobby", 2, 5);
            //El duende se va a encargar de atacar al elfo
            gimli.AttackElfs(dobby, axe);
            Console.WriteLine($"La vida de {dobby.Name} bajó a: {dobby.Health} de vida\n");

            Console.WriteLine("--- SIMULACIÓN DE CURACIÓN ---");
            //El elfo Legolas se va a encargar de curar al elfo Dobby
            legolas.ThrowPotion(potion, dobby, inventory);
            Console.WriteLine($"La vida de {dobby.Name} vuelve a ser: {dobby.Health} de vida\n");

            //Lo que va a mostrar es el resultado total del ataque
            Console.WriteLine("--- TOTAL DE VALOR DE ATAQUE ---");
            int totalAttack = robin.AttackTotal(dagger, bow);
            Console.WriteLine($"El valor de ataque total que tiene {robin.Name} es: {totalAttack}\n");

            //Lo que va a mostrar es el resultado total de la defensa
            Console.WriteLine("--- TOTAL DE VALOR DE DEFENSA ---");
            int totalDefense = snape.DefenseTotal(book, tunic);
            Console.WriteLine($"El valor de defensa total que tiene {snape.Name} es: {totalDefense}");
        }
    }
} 
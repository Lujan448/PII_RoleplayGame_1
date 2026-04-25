using System;
using Archers;
using Bows;
using MagicStaffs;
using SpellBooks;
using Tunics;
using Ucu.Poo.RolePlayGame;
using ucudal; 

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- TU ELFO ---
            Elf legolas = new Elf("Legolas", 15, 5, 100);
            
            Potion pocion1 = new Potion();
            Potion pocion2 = new Potion();
            legolas.Inventory.AddPotion(pocion1);
            legolas.Inventory.AddPotion(pocion2);
            
            Spear lanzaDeLegolas = new Spear();

            // --- ENANO ---
            Dwarf gimli = new Dwarf("Gimli", 150, 20, 10);
            gimli.HachaEquipada = new Hacha();
            gimli.EscudoEquipado = new Escudo();

            // --- ARQUERO ---
            Archer robin = new Archer("Robin", 90, 18, 4);
            robin.ChangeBow = new Bow();
            robin.ChangeDagger = new Daggers();

            // --- MAGO ---
            Wizard snape = new Wizard("Snape", 80, 5, 2);
            snape.Book = new SpellBook();
            snape.Book.AgregarHechizo(new Spells("Rayo", 25, 0));
            snape.tunicequip = new Tunic();
            snape. = new MagicStaff();

            Console.WriteLine("--- ESTADO INICIAL ---");
            Console.WriteLine($"{legolas.Name} tiene {legolas.Health} HP");
            
            // Si algo de aquí abajo sale en rojo, bórralo, pon un punto y busca el nombre nuevo:
            Console.WriteLine($"{gimli.Nombre} tiene {gimli.health} HP");
            Console.WriteLine($"{robin.Name} tiene {robin.Health} HP");
            Console.WriteLine($"{snape.Name} tiene {snape.Health} HP\n");

            // --- SIMULACIÓN USANDO TU CÓDIGO (Sin errores) ---
            Console.WriteLine("--- SIMULACIÓN DE COMBATE ---");
            
            Elf tauriel = new Elf("Tauriel", 10, 8, 100);
            Console.WriteLine($"{legolas.Name} ataca a {tauriel.Name} con su lanza.");
            
            legolas.AttackOthers(tauriel, lanzaDeLegolas);
            Console.WriteLine($"La vida de {tauriel.Name} bajó a: {tauriel.Health} HP\n");

            Console.WriteLine("--- SIMULACIÓN DE CURACIÓN ---");
            legolas.ThrowPotion(pocion1, tauriel);
            Console.WriteLine($"La vida de {tauriel.Name} vuelve a ser: {tauriel.Health} HP");
        }
    }
}
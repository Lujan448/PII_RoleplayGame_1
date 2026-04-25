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
            Elf legolas = new Elf("Legolas", 15, 5, 100);
            Potion pocion = new Potion();
            legolas.Inventory.AddPotion(pocion);
            Spear lanzaDeLegolas = new Spear();

            Dwarf gimli = new Dwarf("Gimli", 150, 20, 10);
            gimli.HachaEquipada = new Hacha();
            gimli.EscudoEquipado = new Escudo();

            Archer robin = new Archer("Robin", 90, 18, 4);
            robin.BowEquipado = new Bow();
            robin.DaggersEquipado = new Daggers();

            Wizard snape = new Wizard("Snape", 80, 5, 2);
            snape.Book = new SpellBook();
            snape.Book.AgregarHechizo(new Spells("Rayo", 25, 0));
            snape.tunicequip = new Tunic();
            snape.StaffEquipado = new MagicStaff();

            Console.WriteLine("--- ESTADO INICIAL ---");
            Console.WriteLine($"{legolas.Name} tiene {legolas.Health} HP");
            Console.WriteLine($"{gimli.Nombre} tiene {gimli.VidaActual} HP");
            Console.WriteLine($"{robin.Name} tiene {robin.Actuallfe} HP");
            Console.WriteLine($"{snape.Name} tiene {snape.VidaActual} HP\n");

            Console.WriteLine("--- SIMULACIÓN DE COMBATE ---");
            
            int dañoTotalLegolas = legolas.AttackValue + lanzaDeLegolas.AttackValue;
            Console.WriteLine($"{legolas.Name} ataca a {gimli.Nombre} con {dañoTotalLegolas} de daño.");
            gimli.RecibirDaño(dañoTotalLegolas);
            Console.WriteLine($"La vida de {gimli.Nombre} bajó a: {gimli.VidaActual} HP\n");

            int dañoSnape = snape.ObtenerAtaqueTotal();
            Console.WriteLine($"{snape.Name} ataca a {robin.Name} con {dañoSnape} de daño.");
            robin.RecibirDaño(dañoSnape);
            Console.WriteLine($"La vida de {robin.Name} bajó a: {robin.Actuallfe} HP\n");

            Console.WriteLine("--- SIMULACIÓN DE CURACIÓN ---");
            
            gimli.CurarTotalmente();
            Console.WriteLine($"{gimli.Nombre} usó curación total. Su vida vuelve a ser: {gimli.VidaActual} HP");
        }
    }
}
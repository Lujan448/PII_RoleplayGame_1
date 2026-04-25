using System;
using ucudal; 

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Elfo legolas = new Elfo("Legolas", 100, 15, 5);
            legolas.LanzaEquipada = new Lanza();
            legolas.InventarioPociones.Add(new Pocion()); 
            legolas.InventarioPociones.Add(new Pocion()); 

            Enano gimli = new Enano("Gimli", 150, 20, 10);
            gimli.HachaEquipada = new Hacha();
            gimli.EscudoEquipado = new Escudo();

            Arquero robin = new Arquero("Robin", 90, 18, 4);
            robin.ArcoEquipado = new Arco();
            robin.CascoEquipado = new Casco();

            Mago snape = new Mago("Snape", 80, 5, 2);
            snape.Libro = new LibroHechizos();
            snape.Libro.AgregarHechizo(new Hechizo("Rayo", 25, 0));
            snape.TunicaEquipada = new Tunica();
            snape.BastonEquipado = new BastonMagico();

            Console.WriteLine("--- ESTADO INICIAL ---");
            Console.WriteLine($"{legolas.Nombre} tiene {legolas.VidaActual} HP");
            Console.WriteLine($"{gimli.Nombre} tiene {gimli.VidaActual} HP");
            Console.WriteLine($"{robin.Nombre} tiene {robin.VidaActual} HP");
            Console.WriteLine($"{snape.Nombre} tiene {snape.VidaActual} HP\n");

            Console.WriteLine("--- SIMULACIÓN DE COMBATE ---");
            
            int dañoLegolas = legolas.ObtenerAtaqueTotal();
            Console.WriteLine($"{legolas.Nombre} ataca a {gimli.Nombre} con {dañoLegolas} de daño.");
            gimli.RecibirDaño(dañoLegolas);
            Console.WriteLine($"La vida de {gimli.Nombre} bajó a: {gimli.VidaActual} HP\n");

            int dañoSnape = snape.ObtenerAtaqueTotal();
            Console.WriteLine($"{snape.Nombre} ataca a {robin.Nombre} con {dañoSnape} de daño.");
            robin.RecibirDaño(dañoSnape);
            Console.WriteLine($"La vida de {robin.Nombre} bajó a: {robin.VidaActual} HP\n");

            Console.WriteLine("--- SIMULACIÓN DE CURACIÓN ---");
            
            gimli.CurarTotalmente();
            Console.WriteLine($"{gimli.Nombre} usó curación total. Su vida vuelve a ser: {gimli.VidaActual} HP");
        }
    }
}
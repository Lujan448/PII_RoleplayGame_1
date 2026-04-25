using System;
using System.Collections.Generic;

namespace ucudal
{
    public class Elfo
    {
        public string Nombre { get; private set; }
        public int VidaMaxima { get; private set; }
        public int VidaActual { get; private set; }
        public int AtaqueBase { get; private set; }
        public int DefensaBase { get; private set; }

        // Propiedades específicas en lugar de interfaz
        public Lanza LanzaEquipada { get; set; }
        public List<Pocion> InventarioPociones { get; set; } = new List<Pocion>();

        public Elfo(string nombre, int vidaMaxima = 100, int ataqueBase = 10, int defensaBase = 5)
        {
            Nombre = nombre;
            VidaMaxima = vidaMaxima;
            VidaActual = vidaMaxima;
            AtaqueBase = ataqueBase;
            DefensaBase = defensaBase;
        }

        public int ObtenerAtaqueTotal()
        {
            int ataqueTotal = AtaqueBase;
            if (LanzaEquipada != null)
            {
                ataqueTotal += LanzaEquipada.ValorAtaque;
            }
            return ataqueTotal;
        }
        
        public int ObtenerDefensaTotal()
        {
            int defensaTotal = DefensaBase;
            if (LanzaEquipada != null)
            {
                defensaTotal += LanzaEquipada.ValorDefensa;
            }
            return defensaTotal;
        }

        public void RecibirDaño(int dañoRecibido)
        {
            int dañoReal = dañoRecibido - ObtenerDefensaTotal();
            if (dañoReal < 0) dañoReal = 0;
            
            VidaActual -= dañoReal;
            if (VidaActual < 0) VidaActual = 0;
        }

        public void CurarTotalmente() => VidaActual = VidaMaxima;

        public void RecibirCuracion(int puntos)
        {
            VidaActual += puntos;
            if (VidaActual > VidaMaxima) VidaActual = VidaMaxima;
        }

        public void LanzarPocion(Pocion pocion, Elfo objetivo)
        {
            if (InventarioPociones.Contains(pocion))
            {
                objetivo.RecibirCuracion(pocion.PoderCurativo);
                InventarioPociones.Remove(pocion);
                Console.WriteLine($"{Nombre} lanzó una poción a {objetivo.Nombre}.");
            }
        }
    }
}
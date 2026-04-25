using NUnit.Framework;
using ucudal; 

namespace Tests
{
    public class ElfoTests
    {
        [Test]
        public void ObtenerAtaqueTotal_ConLanzaEquipada_RetornaSumaDeAtaqueBaseYArma()
        {
            Elfo elfo = new Elfo("Legolas", 100, 10, 5);
            Lanza lanza = new Lanza(); 
            
            // Cambio aquí: Asignación directa
            elfo.LanzaEquipada = lanza;

            int ataqueTotal = elfo.ObtenerAtaqueTotal();

            Assert.That(ataqueTotal, Is.EqualTo(35));
        }

        [Test]
        public void RecibirDaño_DanioMayorQueDefensa_DisminuyeVidaCorrectamente()
        {
            Elfo elfo = new Elfo("Legolas", 100, 10, 5);
            
            elfo.RecibirDaño(25);

            Assert.That(elfo.VidaActual, Is.EqualTo(80));
        }

        [Test]
        public void RecibirDaño_DanioLetal_VidaNoBajaDeCero()
        {
            Elfo elfo = new Elfo("Legolas", 100, 10, 5);
            
            elfo.RecibirDaño(1000);

            Assert.That(elfo.VidaActual, Is.EqualTo(0));
        }

        [Test]
        public void LanzarPocion_ObjetivoHerido_AumentaVidaDelObjetivo()
        {
            Elfo atacante = new Elfo("Elfo A");
            Pocion pocion = new Pocion(); 
            
            // Cambio aquí: Agregamos a la lista directa
            atacante.InventarioPociones.Add(pocion);

            Elfo objetivo = new Elfo("Elfo B", 100, 10, 0); 
            objetivo.RecibirDaño(50);

            atacante.LanzarPocion(pocion, objetivo);

            Assert.That(objetivo.VidaActual, Is.EqualTo(90));
        }
    }
}
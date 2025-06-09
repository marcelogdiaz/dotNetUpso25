using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    internal class JugadorFutbol : Deportista
    {
        //campos propios de un jugador
        #region PROPERTIES
        private int infracciones;
        private string posicion;

        public int Infracciones { get => infracciones; set => infracciones = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        #endregion

        public JugadorFutbol(string apellido, string nombre, int edad,  string posicion, int infracciones = 0):base(apellido, nombre, edad)
        {
            Infracciones = infracciones;
            Posicion = posicion;
        }

        public override void Correr() {
            base.Correr();
            Console.WriteLine($"El JUGADOR {Apellido} esta corriendo hacia la pelota.");
        }

        public new void Precalentar()
        {
            //base.Precalentar(); 
            Console.WriteLine($"El JUGADOR {Apellido} esta precalentando con la pelota de futbol.");
        }

        public void TarjetaRoja()
        {
            Console.WriteLine($"El JUGADOR {Apellido} recibió tarjeta ROJA.");
        }

        public void TarjetaAmarilla()
        {
            Console.WriteLine($"El JUGADOR {Apellido} recibió tarjeta AMARILLA.");
        }

        public override void MiActividad()
        {
            Console.WriteLine("Mi actividad es el Futbol. ");
        }
    }
}

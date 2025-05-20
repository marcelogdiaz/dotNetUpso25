using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    internal class Jugador : Persona
    {
        //campos propios de un jugador
        #region PROPERTIES
        private int infracciones;
        private string posicion;

        public int Infracciones { get => infracciones; set => infracciones = value; }
        public string Posicion { get => posicion; set => posicion = value; }
        #endregion

        //public Jugador(stringint infracciones, string posicion)
        //{
        //    this.infracciones = infracciones;
        //    this.posicion = posicion;
        //}
    }
}

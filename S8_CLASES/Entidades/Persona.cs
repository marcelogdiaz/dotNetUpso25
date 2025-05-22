using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8_CLASES.Entidades
{
    internal class Persona
    {
        #region ATRIBUTOS
        private string nombre;
        private string apellido;
        private int edad;
        #endregion

        #region CONSTRUCTORES
        /// <summary>
        /// Constructor de la clase Persona
        /// </summary>
        /// <param name="nombre">Permite especificar el Nombre de una Persona</param>
        /// <param name="apellido">Permite especificar el Apellido de una Persona</param>
        /// <param name="edad">Permite especificar la Edad de una Persona</param>
        public Persona( string apellido, string nombre, int edad)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
        }

        /// <summary>
        /// Constructor de la clase Persona para crearla solo con Apellido
        /// </summary>
        /// <param name="apellido">Permite especificar el Apellido de una Persona</param>
        public Persona(string apellido) {
            this.apellido = apellido;    
        }
        #endregion

        #region PROPERTIES
        public string Nombre { 
            get => nombre; 
            set => nombre = value; }    //version "normal" de property
        public string Apellido { get => apellido; set => apellido = value.ToUpper(); }  //version personalizada de property

        public int Edad { get; set; }   //version reducida de property
        #endregion


        public int CumplirAnios() {
            Edad++;
            return Edad;
        }

        public virtual void MiActividad() {
            Console.WriteLine("No tengo una actividad especifica. ");
        }
    }
}

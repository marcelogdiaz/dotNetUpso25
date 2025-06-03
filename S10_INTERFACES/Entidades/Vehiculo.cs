using S10_INTERFACES.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_INTERFACES.Entidades
{
    internal class Vehiculo:IService
    {
        #region PROPERTIES
        private string marca;
        private int cantidadRuedas;

        public string Marca { get => marca; set => marca = value; }
        public int CantidadRuedas { get => cantidadRuedas; set => cantidadRuedas = value; }
        #endregion

        public Vehiculo(string marca, int cantidadRuedas)
        {
            Marca = marca;
            CantidadRuedas = cantidadRuedas;
        }

        public virtual void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} ruedas {1}",CantidadRuedas, Marca);
        }

        public virtual void alinearRueda()
        {
            Console.WriteLine("Alineamos {0}", marca);
        }

        public void medirPresionAceite()
        {
            Console.WriteLine("Medimos el aceite del vehiculo {0}", marca);
        }
    }
}

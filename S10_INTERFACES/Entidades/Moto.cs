using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace S10_INTERFACES.Entidades
{
    internal class Moto:Vehiculo
    {
        string color;

        public Moto(string marca, int cantidadRuedas, string c) : base(marca, cantidadRuedas)
        {
            this.color = c;
        }

        public override void cambiarRueda()
        {
            Console.WriteLine("Cambiamos {0} ruedas en la MOTO {1}", CantidadRuedas, Marca);
        }

        public override void alinearRueda()
        {
            Console.WriteLine("Alineamos MOTO {0}", Marca);
        }
    }
}

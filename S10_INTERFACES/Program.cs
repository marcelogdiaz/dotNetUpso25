using S10_INTERFACES.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S10_INTERFACES
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vehiculo miVehiculo;
            //miVehiculo= new Vehiculo("Audi", 4);

            miVehiculo = new Moto("Honda", 2, "negro");

            miVehiculo.alinearRueda();
            miVehiculo.cambiarRueda();
            miVehiculo.medirPresionAceite();

            Console.ReadLine();
        }
    }
}

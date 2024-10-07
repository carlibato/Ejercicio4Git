using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos_Ibanez_DAM2
{
    internal class Ejercicio2 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce un pin valido de 4 0 6 digitos");
            String pin = Console.ReadLine();
            int longitud = pin.Length;
            if (longitud == 4 || longitud == 6)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos_Ibanez_DAM2
{
    internal class Utils
    {
        /// <summary>
        /// Devuelve una linea de strings por consola
        /// </summary>
        /// <returns></returns>
        public static String GetStringPorConsola()
        {
            Console.WriteLine("Escribe una cadena solo de letras");
            string? linea = Console.ReadLine().ToLower();
            
            return linea;
        }
        /// <summary>
        /// Devuelve un numero obtenido por consola
        /// </summary>
        /// <returns></returns>
        public static int GetNumeroPorConsola()
        {
            Console.WriteLine("Escribe un número por consola");
            string? numero = Console.ReadLine();
            if (!int.TryParse(numero, out int val))
            {
                Console.WriteLine("No has introducido un número");
                return 0;
            }
            return val;
        }
    }
}

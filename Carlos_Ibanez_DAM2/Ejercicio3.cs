using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos_Ibanez_DAM2
{
    internal class Ejercicio3 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            Console.WriteLine("Introduce numeros separados por comas");
            String numerosString = Console.ReadLine();
            String[] numerosSeparados = numerosString.Split(',');
            for(int i = 0; i < numerosSeparados.Length; i++)
            {
                
            }
            
        }
    }
}

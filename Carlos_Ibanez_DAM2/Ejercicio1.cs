using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlos_Ibanez_DAM2
{
    internal class Ejercicio1 : IEjecutarEjercicio
    {
        public void Ejecutar()
        {
            String linea = Utils.GetStringPorConsola();
            char[] letras = linea.ToCharArray();
            int contador = 0;
            for (int i = 0; i < linea.Length; i++)
            {
                if (letras[i] == ('a') ||
                    letras[i] == ('e') ||
                    letras[i] == ('i') ||
                    letras[i] == ('o') ||
                    letras[i] == ('u'))
                {
                    contador++;
                }
            }
            Console.WriteLine(contador);

        } 
    }
}

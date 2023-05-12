using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace EdadesPL
{
    public class Palabra
    {
        public void Longitud()
        {
            string palabra;

            Console.WriteLine("Ingresa la Palabra quue deseas Agregar al array");
            palabra = Console.ReadLine();

            string[] CadenaPalabras = palabra.Split(',');
            int[] letras;
            //int[] letras = new int[CadenaPalabras.Length];

            int indice = 0;
            int countLetras;
            List<int> list = new List<int>();

            for (indice = 0; indice < CadenaPalabras.Length; indice++)
            {
                Console.WriteLine("Hola" + CadenaPalabras[indice].Length);
                list.Add(CadenaPalabras[indice].Length);
                letras = list.ToArray();
                Console.WriteLine("Hola" + letras);
            }

            Console.ReadKey();
        }
    }
}

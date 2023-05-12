using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadesPL
{
    public class Cadena
    {
        public void Descomponercadena()
        {
            //char[] alphabet = { 'a', 'b', 'c', 'd','e','f','g','h','i','j','k','l','m','n','ñ','o','p','q','r','s'
            //,'t','u','v','w','x','y','z'};
            //int length = 0;
            //int suma = 0 ;
            //int a=0;
            //int b = 1;
            //string cadena;
            //char[] descomponerCadena;
            //char[] nuevaCadena = new char[length] ; 
            //List<char> list = new List<char>(nuevaCadena.ToList());
            //char intento ;
            //int indice = 0;


            //Console.WriteLine("Por favor digite una cadena de texto");
            //cadena = Console.ReadLine();

            //if (cadena != "")
            //{
            //    descomponerCadena = cadena.ToCharArray();
            //    length = descomponerCadena.Length;

            //    foreach (var elemento in descomponerCadena)
            //    {
            //        suma = a + 1;

            //        if (alphabet.Contains(elemento))
            //        {
            //            for (indice = 0; indice < 1; indice++)
            //            {
            //                 intento = alphabet[suma];
            //               list.Add(intento);
            //                nuevaCadena = list.ToArray();
            //                a++;
            //            }



            //        }

            //    }

            //    Console.WriteLine(string.Join(", ", nuevaCadena));
            //    //for (int ctr = 0; ctr < descomponerCadena.Length; ctr++)
            //    //{
            //    //    Console.WriteLine("   {0}: {1}", ctr, descomponerCadena[ctr]);
            //    //}
            //}
            //else
            //{
            //    Console.WriteLine("la cadena no puede estar vacia");
            //}
            //Console.ReadKey();

            Console.WriteLine("Escriba una palabra");
            string Arreglo = Console.ReadLine();
            char[] NuevoArreglo;

            NuevoArreglo = Arreglo.ToCharArray();
            for (int i = 0; i < NuevoArreglo.Length; i++)
            {
                char Cadena = NuevoArreglo[i];

                Console.Write( ++Cadena);
            }
            Console.ReadKey();
        }
        


    }
}

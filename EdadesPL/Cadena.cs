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
            char[] alphabet = { 'a', 'b', 'c', 'd' };
            int length = 0;
            int a=0;
            int b = 1;
            string cadena;
            char[] descomponerCadena;
            char[] nuevaCadena = new char[length] ; 
            List<char> list = new List<char>(nuevaCadena.ToList());
            char intento = alphabet[a+b];


            Console.WriteLine("Por favor digite una cadena de texto");
            cadena = Console.ReadLine();

            if (cadena != "")
            {
                descomponerCadena = cadena.ToCharArray();
                length = descomponerCadena.Length;

                foreach (var elemento in descomponerCadena)
                {
                     

                    if (alphabet.Contains(elemento))
                    {
                        
                        list.Add(intento);
                        nuevaCadena = list.ToArray();

                    }
                    a++;
                   
                }

                Console.WriteLine(string.Join(", ", nuevaCadena));
                //for (int ctr = 0; ctr < descomponerCadena.Length; ctr++)
                //{
                //    Console.WriteLine("   {0}: {1}", ctr, descomponerCadena[ctr]);
                //}
            }
            else
            {
                Console.WriteLine("la cadena no puede estar vacia");
            }
            Console.ReadKey();
        }
        


    }
}

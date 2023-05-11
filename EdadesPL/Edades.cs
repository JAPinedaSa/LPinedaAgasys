using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadesPL
{
    public class Edades
    {
        //public static void Edades()
        //{
        //    int[] Edad = new int[10];
        //    int indice = 0;
        //    int countmenoredad = 0;
        //    int countmayoredad = 0;

        //    for (indice = 0; indice < 14; indice++)
        //    {
        //        Console.WriteLine("Digite su edad");
        //        Edad[indice] = int.Parse(Console.ReadLine());
        //    }

        //    for (indice = 0; indice < 14; indice++)
        //    {
        //        if (Edad[indice] < 18)
        //        {
        //            countmenoredad++;

        //        }
        //        else
        //        {
        //            countmayoredad++;
        //        }


        //    }
        //    Console.WriteLine("el numero de personas menores de edad son: " + " " + countmenoredad);
        //    Console.WriteLine("el numero de personas Mayores de edad son: " + " " + countmayoredad);
        //}

        public void Edad()
        {
            int[] Edad = new int[15];
            int indice = 0;
            int countmenoredad = 0;
            int countmayoredad = 0;

            for (indice = 0; indice < 15; indice++)
            {
                Console.WriteLine("Digite su edad");
                Edad[indice] = int.Parse(Console.ReadLine());
            }

            for (indice = 0; indice < 14; indice++)
            {
                if (Edad[indice] < 18)
                {
                    countmenoredad++;

                }
                else
                {
                    countmayoredad++;
                }


            }
            Console.WriteLine("el numero de personas menores de edad son: " + " " + countmenoredad);
            Console.WriteLine("el numero de personas Mayores de edad son: " + " " + countmayoredad);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApesaJAPS
{
    public class AñoBisiesto
    {
        public void ValidarAñobisiesto()
        {
            int año;

            Console.Write("Introduce un año: ");

            año = Convert.ToInt32(Console.ReadLine());

            if (año % 400 == 0 || (año % 4 == 0 && año % 100 != 0))

                Console.WriteLine("{0} es un año bisiesto", año);

            else

                Console.WriteLine("{0} no es un año bisiesto", año);

          Console.ReadKey();

        }
    }
}

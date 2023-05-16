using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApesaJAPS
{
    public class ParOImpar
    {
        public void parOimpar()
        {
            Console.WriteLine("Ingresa el primer numero");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresa el segundo numero \n");
            int numero2 = int.Parse(Console.ReadLine());

            if((numero1 % 2 ) == 0 && (numero2 % 2) == 0)
            {
                Console.WriteLine("Ambos Numeros Son pares");
            }
            else if ((numero1 % 2) == 0)
            {
                Console.WriteLine( "el numero {0} es par", numero1);
            }
            else
            {
                Console.WriteLine("el numero {0} es par", numero2);
            }

            Console.ReadKey();
        }
    }
}

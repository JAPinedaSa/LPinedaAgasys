using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadesPL
{
    public class SopadeLetras
    {
        public void Sopa()
        {
            string Cadena;

            string Ordenamiento;
            Console.WriteLine("Digita una palabra");
            Cadena = Console.ReadLine();

            Ordenamiento = new string(Cadena.OrderBy(x => x).ToArray());
            Console.WriteLine(Ordenamiento);
            Console.ReadKey();
            
        }
    }
}

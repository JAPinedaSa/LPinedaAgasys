using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadesPL
{
    public class Empleado
    {
        int sueldoDiario, diasTrabajados,sueldoTotal;

        string Nombre, Apellido;

        public void CalcularSueldo()
        {
            Console.WriteLine("Digite Su Nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("Digite Su Apeliido");
            Apellido = Console.ReadLine();
            Console.WriteLine("Digite Su Sueldo Diario");
            sueldoDiario = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite Los Días Laborados");
            diasTrabajados = int.Parse(Console.ReadLine());
            sueldoTotal = diasTrabajados * sueldoDiario;

            Console.WriteLine("El Sueldo Total del empleado:" + Nombre + " " + Apellido +" "+ "es de: "+" "+ sueldoTotal);
            Console.ReadKey();
        }
        public void CalcularSueldo(string Nombre, string Apellido, int sueldoDiario, int diasTrabajados)
        {
          
            sueldoTotal = diasTrabajados * sueldoDiario;

            Console.WriteLine("El Sueldo Total del empleado:" + Nombre + " " + Apellido + " " + "es de " + " $" + sueldoTotal);
            Console.ReadKey();
        }

    }
}

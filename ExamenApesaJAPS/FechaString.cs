using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenApesaJAPS
{
    public class FechaString
    {
        public  void OrdenarFechaString()
        {
            string  Fecha;
            try
            {
                Console.WriteLine("Por favor digite la fecha en el siguiente formato *yyyy/mm/dd*");
                Fecha = Console.ReadLine();

                string fecha1  = Convert.ToDateTime(Fecha).ToString("dd/MMMM/yyyy");
                DateTime fecha = DateTime.Parse(fecha1);
                string mes = fecha.ToString("MMMM");
                int año = fecha.Year;
                int dia = fecha.Day;
                //Console.WriteLine("La fecha es "+ Fecha);
                Console.WriteLine("La fecha es " + dia + " /" + mes + "/" + año);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hubo un error" + ex.Message);
            }

            Console.ReadKey();
            
        }
    }
}

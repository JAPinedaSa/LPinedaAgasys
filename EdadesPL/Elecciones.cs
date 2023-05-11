using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdadesPL
{
    public class Elecciones
    {

        public void Eleccion()
        {
            string CandidatoA = "Juan";
            string CandidatoB = "Jose";
            string CandidatoC = "Erik";
            int[] Votos = new int[15];
            int indice = 0;
            int countCandidatoA = 0;
            int countCandidatoB = 0;
            int countCandidatoC = 0;



            Console.WriteLine("Los Candidatos a Elegir son: \n" +
               "1.-" + CandidatoA + "\n" +
               "2.-" + CandidatoB + "\n" +
               "3.-" + CandidatoC + "\n");

            for (indice = 0; indice < 15; indice++)
            {

                Console.WriteLine("Digite el Numero que Represente al Candidato que Desea Elegir");
                Votos[indice] = int.Parse(Console.ReadLine());
            }
            for (indice = 0; indice < Votos.Length; indice++)
            {
                if (Votos[indice] == 1)
                {
                    countCandidatoA++;

                }
                else
                if (Votos[indice] == 2)
                {
                    countCandidatoB++;
                }
                else
                {

                    countCandidatoC++;
                }

            }
            Console.WriteLine("Los votos del candidato:" + " " + CandidatoA + " " + "Son:" + " " + countCandidatoA);
            Console.WriteLine("Los votos del candidato:" + " " + CandidatoB + " " + "Son:" + " " + countCandidatoB);
            Console.WriteLine("Los votos del candidato:" + " " + CandidatoC + " " + "Son:" + " " + countCandidatoC);

            if (countCandidatoA > countCandidatoB && countCandidatoA > countCandidatoC)
            {
                Console.WriteLine("el ganador es el Candidato:" + " " + CandidatoA + " " + "Con:" + " " + countCandidatoA + " " + "Votos:" );
            }
            else if (countCandidatoB > countCandidatoA && countCandidatoB > countCandidatoC)
            {
                Console.WriteLine("el ganador es el Candidato:" + " " + CandidatoB + " " + "Con:" + " " + countCandidatoB + " " + "Votos:");
            }
            else
            {
                Console.WriteLine("el ganador es el Candidato:" + " " + CandidatoC + " " + "Con:" + " " + countCandidatoC + " " + "Votos:");
            }
            Console.ReadKey();
        }
    }




}


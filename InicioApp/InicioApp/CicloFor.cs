using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class CicloFor
    {

        public void VContar(int Ab)
        {

            for (int i = 0; i < Ab; i++)
            {
                Console.WriteLine("A qui va {0}:", i);
            }

        }


        public void V2Contar(int Ab)
        {

            for (int i = 0; i < Ab; i++)
            {
                Console.WriteLine("A qui va {0}:", i);
            }

        }

        public void OpeIncremento(int Inum)
        {
            int contador = 0, acumulador = 0;

            for (int i = 0; i < Inum; i++)
            {
                contador++;
                acumulador = acumulador + contador;
                Console.WriteLine("Contador : {0}, acumulador : {1}", contador, contador);
            }



        }

        public void CasFor()
        {

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteración número: {i}");
            }

        }




    }
}

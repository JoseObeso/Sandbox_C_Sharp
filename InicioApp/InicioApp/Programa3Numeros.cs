using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class Programa3Numeros
    {


        public string Validar3Numeros(int x1, int x2, int x3)
        {
            bool Primeros2;
            if (x1>x2)
            {
                Primeros2 = true;

            }
            else
            {
                Primeros2 = false;

            }

            if (Primeros2)
            {

                if (x1>x3)
                {
                    Primeros2 = true;
                }
                else
                {
                    Primeros2 = false;
                }
            }

            return x1.ToString();








        }
       









    }
}

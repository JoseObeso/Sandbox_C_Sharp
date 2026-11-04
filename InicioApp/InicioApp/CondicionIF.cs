using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class CondicionIF
    {

        public void TestIf(int n1, int n2)
        {

            bool Confirmar;
            if (n1 > n2)
            {
                Confirmar = true;
                Console.WriteLine("N1 {0} es mayor que N2 {1}, es correcto {2}", n1, n2, Confirmar);
            }
            else
            {
                Confirmar = false;
                Console.WriteLine("N1 {0} es mayor que N2 {1}, es correcto {2}", n1, n2, Confirmar);

            }





        }






    }
}

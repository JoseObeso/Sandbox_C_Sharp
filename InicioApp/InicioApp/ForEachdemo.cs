using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class ForEachdemo
    {
        public void ForEachEjemplo(string Vnombre)
        {
            foreach (char item in Vnombre.ToUpper())
            {
               Console.WriteLine(" Es la Letra : {0}", item);

            }
            Console.ReadKey();

        }

        public void OtroForEach()
        {
            string[] frutas = { "Manzana", "Banana", "Naranja" };

            foreach (var fruta in frutas)
            {
                Console.WriteLine(fruta);
            }


        }








    }
}
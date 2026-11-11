using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class Aprender_WriteLine
    {


        public void PrimerWriteLine()
        {
            // Console.Write("Escribe pero no corta la linea ");
            // Console.Write("---- Siguiente Linea");


            Console.Write("Siempre va en una sola Linea");
            Console.Write("---  continuacion  segunda Linea");

            Console.WriteLine("\nPrimera Linea");
            Console.WriteLine("Segunda Linea");


        }


        public  void SegundoWriteLine()
        {
            string firstName = "Jose";
            string lastName = " Obeso";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 6;
            Console.WriteLine(x + y); // Print the value of x + y



        }


        public void TercerWriteLine()
        {
            int x, y, z;
            x = y = z = 50;
            Console.WriteLine(x + y + z);
        }


        public void MostrarCW()
        {
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);


        }





    }
}

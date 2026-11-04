using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class AprenderCSharp_Console
    {

        public void Ejecutar_Eliminacion()
        {
            string greeting = "      Jose Obeso       ";
            Console.WriteLine(greeting);

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine(trimmedGreeting);

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine(trimmedGreeting);

            trimmedGreeting = greeting.Trim();
            Console.WriteLine(trimmedGreeting);
        }


        public void Numero_2_Cifras()

        {
            int NUM, AUX, DEC, UNI;
            string linea;
            Console.WriteLine("INGRESE NÚMERO DE DOS CIFRAS :");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 10) + DEC;
            Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);
            Console.WriteLine("Pulse una Tecla:");

        }


        public void Numero_3_Cifras()
        {
            int NUM, AUX, DEC, UNI, CEN;
            string linea;
            Console.WriteLine("INGRESE NÚMERO DE TRES CIFRAS :");
            linea = Console.ReadLine();
            NUM = int.Parse(linea);
            CEN = NUM / 100;
            NUM = NUM % 100;

            DEC = NUM / 10;
            UNI = NUM % 10;
            AUX = (UNI * 100) + (DEC * 10) + CEN;
            Console.WriteLine("NÚMERO INVERTIDO ES: " + AUX);
            Console.WriteLine("Pulse una Tecla:"); Console.ReadLine();
        }


        public void Sonarbeep(int s)
        {
            int x = s;
            if ((s >= 1) && (s <= 9))
            {
                for (int i = 1; i <= x; i++)
                {
                    Console.WriteLine("Beep number {0}.", i);
                    Console.Beep();
                }
            }
            else
            {
                Console.WriteLine("Usage: Enter the number of times (between 1 and 9) to beep.");
            }
        }

        /*
        This example produces the following results:

        >beep
        Usage: Enter the number of times (between 1 and 9) to beep

        >beep 9
        Beep number 1.
        Beep number 2.
        Beep number 3.
        Beep number 4.
        Beep number 5.
        Beep number 6.
        Beep number 7.
        Beep number 8.
        Beep number 9.

        */




    }
}

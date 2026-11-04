using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class Sonidosconsolebeep
    {

        /** inicio del sonido **/


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





    /** fin del sonido **/












}



























}

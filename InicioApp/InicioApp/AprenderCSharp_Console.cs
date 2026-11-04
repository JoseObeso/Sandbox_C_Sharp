using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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




        public int OperadorSuma(int x1, int x2)
        {

            return x1 + x2;
        }

        public int OperadorResta(int x1, int x2)
        {
            return x1 - x2;
        }



        /* metodo clear */



        public void MetodoClear()
        {
            // Save colors so they can be restored when use finishes input.
            ConsoleColor dftForeColor = Console.ForegroundColor;
            ConsoleColor dftBackColor = Console.BackgroundColor;
            bool continueFlag = true;
            Console.Clear();

            do
            {
                ConsoleColor newForeColor = ConsoleColor.White;
                ConsoleColor newBackColor = ConsoleColor.Black;

                Char foreColorSelection = GetKeyPress("Select Text Color (B for Blue, R for Red, Y for Yellow): ",
                                                     new Char[] { 'B', 'R', 'Y' });
                switch (foreColorSelection)
                {
                    case 'B':
                    case 'b':
                        newForeColor = ConsoleColor.DarkBlue;
                        break;
                    case 'R':
                    case 'r':
                        newForeColor = ConsoleColor.DarkRed;
                        break;
                    case 'Y':
                    case 'y':
                        newForeColor = ConsoleColor.DarkYellow;
                        break;
                }
                Char backColorSelection = GetKeyPress("Select Background Color (W for White, G for Green, M for Magenta): ",
                                                     new Char[] { 'W', 'G', 'M' });
                switch (backColorSelection)
                {
                    case 'W':
                    case 'w':
                        newBackColor = ConsoleColor.White;
                        break;
                    case 'G':
                    case 'g':
                        newBackColor = ConsoleColor.Green;
                        break;
                    case 'M':
                    case 'm':
                        newBackColor = ConsoleColor.Magenta;
                        break;
                }

                Console.WriteLine();
                Console.Write("Enter a message to display: ");
                String textToDisplay = Console.ReadLine();
                Console.WriteLine();
                Console.ForegroundColor = newForeColor;
                Console.BackgroundColor = newBackColor;
                Console.WriteLine(textToDisplay);
                Console.WriteLine();
                if (Char.ToUpper(GetKeyPress("Display another message (Y/N): ", new Char[] { 'Y', 'N' })) == 'N')
                    continueFlag = false;

                // Restore the default settings and clear the screen.
                Console.ForegroundColor = dftForeColor;
                Console.BackgroundColor = dftBackColor;
                Console.Clear();
            } while (continueFlag);
        }

        private static Char GetKeyPress(String msg, Char[] validChars)
        {
            ConsoleKeyInfo keyPressed;
            bool valid = false;

            Console.WriteLine();
            do
            {
                Console.Write(msg);
                keyPressed = Console.ReadKey();
                Console.WriteLine();
                if (Array.Exists(validChars, ch => ch.Equals(Char.ToUpper(keyPressed.KeyChar))))
                    valid = true;
            } while (!valid);
            return keyPressed.KeyChar;
        }




        /* fin de metodo clear */


        public void Reemplazar_Texto()
        {
            string sayHello = "Hola Mundo a todos";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("todos", "Jose");
            Console.WriteLine(sayHello);
        }


        /* sonidos del mundo */


        public void Sonidos_Mundo()
        {
            // Declare the first few notes of the song, "Mary Had A Little Lamb".
            Note[] Mary =
                {
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.GbelowC, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.B, Duration.HALF),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.QUARTER),
        new Note(Tone.A, Duration.HALF),
        new Note(Tone.B, Duration.QUARTER),
        new Note(Tone.D, Duration.QUARTER),
        new Note(Tone.D, Duration.HALF)
        };
            // Play the song
            Play(Mary);
        }

        // Play the notes in a song.
        protected static void Play(Note[] tune)
        {
            foreach (Note n in tune)
            {
                if (n.NoteTone == Tone.REST)
                    Thread.Sleep((int)n.NoteDuration);
                else
                    Console.Beep((int)n.NoteTone, (int)n.NoteDuration);
            }
        }

        // Define the frequencies of notes in an octave, as well as
        // silence (rest).
        protected enum Tone
        {
            REST = 0,
            GbelowC = 196,
            A = 220,
            Asharp = 233,
            B = 247,
            C = 262,
            Csharp = 277,
            D = 294,
            Dsharp = 311,
            E = 330,
            F = 349,
            Fsharp = 370,
            G = 392,
            Gsharp = 415,
        }

        // Define the duration of a note in units of milliseconds.
        protected enum Duration
        {
            WHOLE = 1600,
            HALF = WHOLE / 2,
            QUARTER = HALF / 2,
            EIGHTH = QUARTER / 2,
            SIXTEENTH = EIGHTH / 2,
        }

        // Define a note as a frequency (tone) and the amount of
        // time (duration) the note plays.
        protected struct Note
        {
            Tone toneVal;
            Duration durVal;

            // Define a constructor to create a specific note.
            public Note(Tone frequency, Duration time)
            {
                toneVal = frequency;
                durVal = time;
            }

            // Define properties to return the note's tone and duration.
            public Tone NoteTone { get { return toneVal; } }
            public Duration NoteDuration { get { return durVal; } }
        }
    }
    /*
    This example produces the following results:

    This example plays the first few notes of "Mary Had A Little Lamb"
    through the console speaker.
    */



    /* fin de sonidos del mundo */





}

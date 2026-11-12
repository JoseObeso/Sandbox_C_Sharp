using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class SintaxysBasicaCSharp
    {

        public void BoolEjemplo()
        {
            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False

        }


        public void CharEjemplo()
        {
            char myGrade = 'B';
            Console.WriteLine(myGrade);
        }

        public void Convertira_Cadena()
        {

            int myInt = 10;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string
        }


        public void InputEjemplo()
        {


            // Type your username and press enter
            Console.WriteLine("Ingrese Nombre Usuario:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Usuario es: " + userName);


        }



        public void InputEdad()
        {
            Console.WriteLine("Tu Edad:");
            int age = Convert.ToInt32(Console.ReadLine());
            int age_add_3 = age + 3;
            Console.WriteLine("Tu edad es : " + age);
            Console.WriteLine("Tu edad en 3 años es : " + age_add_3);
        }

        public void ContarString()
        {
            string txt = "Jose";
            Console.WriteLine("Cadena : " + txt);
            Console.WriteLine("Longitud de Cadena : " + txt.Length);
        }

        public void MayusculaMinuscula()
        {
            string txt = "Hola MuNdo";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"
        }



        public void ConcatenarCadenaTexto()
        {

            string firstName = "Jose";
            string lastName = " Obeso";
            string name = string.Concat(firstName, lastName);
            Console.WriteLine(name);

        }


        public void Add_demo()
        {
            string x = "10";
            string y = "20";
            string z = x + y;
            Console.WriteLine(z);
        }



        public void Interpolacion_demo()
        {

            string firstName = "Jose Obeso";
            string lastName = " Camones";
            string name = $"Nombre Completo: {firstName} {lastName}";
            Console.WriteLine(name);
        }

        public void Cadena_Array()
        {
            string myString = "Jose Obeso";
            Console.WriteLine(myString[3]);  // Outputs "J"


        }
        public void Cadena_posision()
        {

            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));  // Outputs "1"
        }

        public void Cadena_busqueda()
        {

            // Full name
            string name = "John Doe";

            // Location of the letter D
            int charPos = name.IndexOf("D");

            // Get last name
            string lastName = name.Substring(charPos);

            // Print the result
            Console.WriteLine(lastName);

        }

        public void Cadena_mostrar()
        {
            // string txt = "te llamamos por apodo \"Vikingos\" from the north.";
            // string txt = "It\'s alright.";
            // string txt = "The character \\ is called backslash.";
            // string txt = "Primera Linea \nSegunda Linea";
            // string txt = "Este es un tab \t despues del TAB";
            string txt = "Este es un back\b despues del bak";


            Console.WriteLine(txt);


        }

        public void CondicionIF()
        {
            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening.

        }
        public void CondicionIFelseIF()
        {

            int time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }
            // Outputs "Good evening."

        }



    }
}

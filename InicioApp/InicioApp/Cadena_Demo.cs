using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class Cadena_Demo
    {


        public void Msj_Cadena()
        {
            String Msj = "Bienvenidos al Sistema";
            string Vnombre = "Jose Obeso";
            int Ivalor = 56;
            String VformatoFechaTotal = "", VSoloFecha = "";
            VformatoFechaTotal = String.Format("Esta es le Fecha actual : {0: dddd d MMMM yyyy h:m s tt}", DateTime.Now);
            VSoloFecha = String.Format("Fecha Actual : {0: dddd d MMMM yyyy}", DateTime.Now);

            // Console.WriteLine("El valor es {0}, La Primera cadena es : {1}, la segunda cadena es : {2}", Ivalor, Msj, Vnombre);

            Console.WriteLine("Solo Fecha : {0}", VSoloFecha);




        }



        public void AddTexto_En_Cadena()
        {
            // Ejemplo 1: Usando el operador +
            string texto1 = "Hola";
            texto1 = texto1 + " mundo"; // Concatenación simple
            Console.WriteLine("Ejemplo 1: " + texto1);

            // Ejemplo 2: Usando interpolación de cadenas
            string nombre = "Carlos";
            string texto2 = $"Hola {nombre}, bienvenido.";
            Console.WriteLine("Ejemplo 2: " + texto2);

            // Ejemplo 3: Usando string.Concat
            string texto3 = string.Concat("Hola", " ", "C#");
            Console.WriteLine("Ejemplo 3: " + texto3);

            // Ejemplo 4: Usando StringBuilder (eficiente para muchas concatenaciones)
            StringBuilder sb = new StringBuilder("Hola");
            sb.Append(" mundo");
            sb.Append(" desde StringBuilder");
            Console.WriteLine("Ejemplo 4: " + sb.ToString());

            // Ejemplo 5: Usando string.Join (para unir varios elementos)
            string[] palabras = { "Hola", "a", "todos" };
            string texto5 = string.Join(" ", palabras);
            Console.WriteLine("Ejemplo 5: " + texto5);
        }




        public void Insertar_texto_Cadena()
        {
            try
            {
                // Cadena original
                string original = "Hola mundo";

                // Texto a insertar
                string textoAInsertar = " hermoso";

                // Posición donde insertar (después de "Hola")
                int posicion = 4;

                // Validar que la posición sea correcta
                if (posicion < 0 || posicion > original.Length)
                {
                    Console.WriteLine("Error: la posición está fuera del rango de la cadena.");
                    return;
                }

                // Insertar el texto
                string resultado = original.Insert(posicion, textoAInsertar);

                // Mostrar resultado
                Console.WriteLine("Cadena original: " + original);
                Console.WriteLine("Cadena modificada: " + resultado);
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Error: la cadena original o el texto a insertar es nulo.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error: " + ex.Message);
            }
        }


        public void Insertar_Texto_De_En_fecha()
        {
            String VfechaActual = String.Format("{0: dddd d x MMMM yyyy}", DateTime.Now);
            String VFechaActualAgregadodias = String.Format("{0: dddd d x MMMM yyyy}", DateTime.Now.AddDays(2));
            string VfechaActualConFormatoPresentacion = VfechaActual.Replace("x", "de");
            Console.WriteLine(VfechaActualConFormatoPresentacion.TrimStart().TrimEnd());
        }

        public void Todo_Cadena()
        {

            //declaración de la cadena 
            String miCadena = "Hola a todos";
            String dato = "y bienvenidos";
            int valor = 10000;

            //metodo ToString
            String cadena = valor.ToString();

            //fechas y horas 
            String formato;
            formato = String.Format("La fecha es: {0:dddd d MMMM yyyy h:m s tt}", DateTime.Now);
            Console.WriteLine(formato);


            //formato numérico 
            Console.WriteLine(String.Format("{0:$#,####0.00}", valor));

            //concatenación 
            String nombrecompleto = String.Concat(miCadena, dato);
            String mensaje = String.Format("Imprimir mensaje: {0}", nombrecompleto);
            Console.WriteLine(mensaje);

            string nombre = "Pedro";
            string apellido = "Gomez";

            String NombreCompleto = String.Concat(nombre, String.Concat("", apellido));
            Console.WriteLine(NombreCompleto);

            //Comparacion de cadenas 
            int comparacion;
            comparacion = String.Compare(nombre, apellido);
            if (comparacion == 0)
            {
                Console.WriteLine("Las cadenas son iguales");
            }
            else
            {
                Console.WriteLine("Las cadenas no son iguales");
            }

            //Encontrar cadena
            String Nombrecompleto1 = "Jose alameda villa";
            String NombreBuscar = "alameda";

            if (Nombrecompleto1.Contains(NombreBuscar) == true)
            {
                Console.WriteLine("el nombre existe");
            }
            else
            {
                Console.WriteLine("el nombre no existe");
            }

            //obtener una subcadena 
            String resultado = "";
            resultado = miCadena.Substring(7, 5);
            Console.WriteLine(resultado);

            //determinar si la cadena finaliza en subcadena 
            String cadena1 = "Juan Alberto Tabarez";
            String cadena2 = "Tabarez";

            if (cadena1.EndsWith(cadena2) == true)
            {
                Console.WriteLine("La cadena finaliza en Tabarez");
            }
            else
            {
                Console.WriteLine("La cadena no finaliza");
            }

            //Copiar informacion de la cadena 

            char[] destino = new char[20];
            String saludo = "Hola a todos los estudiantes";
            saludo.CopyTo(17, destino, 0, 11);
            Console.WriteLine(destino);

            //Insertar cadena 
            String cadena3 = "Hola como ";
            String cadena4 = "están";
            String resultado2 = "";
            resultado2 = cadena3.Insert(9, cadena4);
            Console.WriteLine(resultado2);

            //Encontrar Subcadena 
            int indice = 0;
            String cadena5 = "Bienvenidos a este curso";
            Console.WriteLine(cadena5);
            indice = cadena5.LastIndexOf("Bienvenidos");
            Console.WriteLine(indice);

            //Justificación de de cadena 
            String cadena6 = "Hola";
            String resultado3 = "";
            resultado3 = cadena6.PadLeft(10);
            Console.WriteLine(resultado3);

            //Eliminar caracteres

            String resultado4 = "";
            resultado4 = cadena5.Remove(19, 5);
            Console.WriteLine(resultado4);

            //Reemplazar una subcadena
            String cadena7 = "Adios";
            String resultado5 = "";
            resultado5 = cadena5.Replace("Bienvenidos", cadena7);
            Console.WriteLine(resultado5);

            //Convertir mayúsculas y minúsculas 
            String resultado6 = "";
            resultado6 = cadena7.ToUpper();
            Console.WriteLine(resultado6);

            //Podar la cadena
            String cadena8 = "      Hola a todos     ";
            String resultado7 = "";
            resultado7 = cadena8.TrimEnd();
            Console.WriteLine(resultado7);

            Console.ReadKey();

        }











    }




}

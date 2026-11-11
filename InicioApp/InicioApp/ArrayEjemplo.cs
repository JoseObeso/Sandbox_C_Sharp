using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class ArrayEjemplo
    {

        public void ArrayBasico()
        {

            // Declarar un array de enteros con 5 elementos
            int[] numeros = new int[5];

            // Inicializar un array con valores específicos
            int[] diasSemana = { 1, 2, 3, 4, 5, 6, 7 };

            string[] Vnombrediasemana = { "Lunes", "Martes", "Miercoles" };

            // Acceder a un elemento del array
            Console.WriteLine(diasSemana[5]); // Salida: 1


            Console.WriteLine(Vnombrediasemana[0]); // Salida: Lunes

            Console.WriteLine(Vnombrediasemana[1]); // Salida: Lunes

            // Modificar un elemento del array
            diasSemana[1] = 10;
            Console.WriteLine(diasSemana[1]); // Salida: 10

        }



        public void OrdenArray()
        {

            int[] numeros = { 5, 3, 8, 1, 2, 4, 7, 6 };
            // Ordenar el array
            Array.Sort(numeros);
            // Console.WriteLine(string.Join(", ", numeros));


            // ordenar una cadena

            string[] Vlista = { "Maria", "Zaira", "Juan", "Jose", "Luis", };
            Console.WriteLine(Vlista);


            //  primero : ordenar
            Array.Sort(Vlista);
            Console.WriteLine(string.Join(", ", Vlista));

            // Reverse
            Array.Reverse(Vlista);
            Console.WriteLine(Vlista);



            // Console.WriteLine(string.Join(", ", Vlista));



            // Salida: 1, 2, 3, 5, 8
            // Invertir el array

            //Array.Reverse(numeros);
            // Console.WriteLine(string.Join(", ", numeros)); 
            // Salida: 8, 5, 3, 2, 1

        }


        public  void Crear_Array()
        {

            string[] frutas = new string[4];

            frutas[0] = "Manzana";
            frutas[1] = "Banana";
            frutas[2] = "Naranja";
            frutas[3] = "Platano";


            // Console.WriteLine(frutas[0]); // Imprime Manzana

            Console.WriteLine(frutas); // Imprime Array


            //foreach (var fruta in frutas)
            //{
            //    Console.WriteLine("Esta es la fruta seleccionada : {0}", fruta);
            //}



        }


    }
}

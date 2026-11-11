using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class Stack_Demo
    {

        public void PrimeraPila()
        {

            int opcion = 0;
            int numero = 0;
            bool encontrado = false;

            Stack miPila = new Stack();

            do
            {
                //menu de opciones 
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Clear");
                Console.WriteLine("4. Contains");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Escoge un opción");
                opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    //Pedimos el valor a introducir
                    Console.WriteLine("Ingresa un valor");
                    numero = Convert.ToInt32(Console.ReadLine());

                    //Adicionamos el valor al stack
                    miPila.Push(numero);
                }
                if (opcion == 2)
                {
                    //obtener elemento
                    numero = (int)miPila.Pop();

                    //mostramos el elemento tomado
                    Console.WriteLine("El valor obtenido es: {0}", numero);

                }
                if (opcion == 3)
                {
                    //Limpiamos todos los elementos
                    miPila.Clear();


                }
                if (opcion == 4)
                {
                    //Pedimos el valor a mostrar 
                    Console.WriteLine("Ingresa el valor a encontrar");
                    numero = Convert.ToInt32(Console.ReadLine());

                    //miramos si el elemento se encuentra
                    encontrado = miPila.Contains(numero);

                    Console.WriteLine("Encontrado: {0}", encontrado);


                }
                // mostrar la información del Stack 
                Console.WriteLine("El Stack tiene {0} elementos", miPila.Count);

            } while (opcion != 5);

            Console.ReadKey();

        }

    }


}
 
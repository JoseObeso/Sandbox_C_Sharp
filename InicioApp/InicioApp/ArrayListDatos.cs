using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class ArrayListDatos
    {


        public void PrimerArrayList()
        {
            int indice, cantidad;

            ArrayList datos = new ArrayList();

            datos.Add(7);
            datos.Add(5);
            datos.Add(1);
            datos.Add(100);

            Console.WriteLine("Estos son los datos");
            Imprime(datos);


            ////Añadimos más datos
            //datos.Add(4);
            //datos.Add(5);
            ////obtenemos el indice
            //indice = datos.Add(10);

            //Console.WriteLine("Después de hacer crecer el array");
            //Imprime(datos);
            //Console.WriteLine("el ultimo elemento tiene el indice: {0}", indice);
            //Console.WriteLine("\n_______________");

            ////imprimir un elemnto en particular
            //Console.WriteLine("El valor en el indice 2 es: {0}", datos[2]);
            //Console.WriteLine("\n_______________");

            ////modificar dato 
            //datos[3] = 20;
            //Console.WriteLine("Dato ya modificado");
            //Imprime(datos);

            ////obtener elementos
            //cantidad = datos.Count;
            //Console.WriteLine("La cantidad de elemntos es: {0}", cantidad);
            //Console.WriteLine("\n_______________");

            ////insertar elemento 
            //datos.Insert(2, 50);
            //Console.WriteLine("Despues de insertar el dato nuevo");
            //Imprime(datos);

            ////obtener elementos
            //cantidad = datos.Count;
            //Console.WriteLine("La cantidad nueva de elementos  es: {0}", cantidad);
            //Console.WriteLine("\n_______________");

            ////eliminar un elemento
            //datos.RemoveAt(6);
            //Console.WriteLine("Despues de la eliminación");
            //Imprime(datos);


            ////obtener elementos
            //cantidad = datos.Count;
            //Console.WriteLine("La cantidad nueva de elementos  es: {0}", cantidad);
            //Console.WriteLine("\n_______________");

            ////encontrar el indice donde se encuentra el 5 

            //indice = datos.IndexOf(5);
            //Console.WriteLine("El primer 5 se encuentra en : {0}", indice);
            //Console.WriteLine("\n_______________");

            Console.ReadKey();



        }


        static void Imprime(ArrayList arreglo)
        {
            foreach (int n in arreglo)
            {
                Console.Write(" {0},", n);
                Console.WriteLine("\n-----------");


            }

        }



    }




}

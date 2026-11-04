using System;


namespace InicioApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // seccion variables

            /*

            string Vnombre = "Jose Obeso";
            int INumero = 56;
            Decimal Dec_sueldo = 1535.32m;
            Boolean Bvive_en_Lima = false;

            es recomendable la presentacion de datos de esta forma, porque permite ahorrar memoria 
           Console.WriteLine("Mi nombre es : {0} Mi edad es {1} años, Mi sueldo es : {2} dolares, Vive en Lima {3}", Vnombre, INumero, Dec_sueldo, Bvive_en_Lima);

            byte num1 = 200, num2 = 30;
            int suma = num1 - num2;
            Console.WriteLine("El numero {0}, mas el numero {1}, tenemos como la resta {2}", num1, num2, suma);

            */


            // seccion pedirle datos al usuario 
            // convertir a entero y double

            //string VpedirNombre;
            //int Iedad;
            //double Dou_Estatura;

            //Console.WriteLine("-- Ingrese su Nombre : ");
            //VpedirNombre = Console.ReadLine();
            //Console.WriteLine("Su nombre es : {0}", VpedirNombre);

            //Console.WriteLine("-- Ingrese su Edad : ");

            //Iedad = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Su nombre es : {0} y su edad es {1}", VpedirNombre, Iedad);


            //Console.WriteLine("-- Ingrese su Estatura : ");
            //Dou_Estatura = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Su nombre es : {0} y su edad es {1}, y su estatura es: {2}", VpedirNombre, Iedad, Dou_Estatura);


            // sumar numeros

            // uso de Convert.toInt32 y demas categorias



            //string VnombreAutor;
            //int num1, num2, total;
            //Console.WriteLine("Ingrese su nombre : ");
            //VnombreAutor = Console.ReadLine();
            //Console.WriteLine("Ingrese primer Numero : ");
            //num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingrese segundo Numero : ");
            //num2 = Convert.ToInt32(Console.ReadLine());
            //total = num1 + num2;
            //Console.WriteLine("Bienvenido : {0}, el primer numero {1}, \n el segundo numero es : {2}, y la suma total {3}", VnombreAutor, num1, num2, total);


            // uso de clases y metodos
            // 
            //Operadores verTodos = new Operadores();
            //int Total = verTodos.Suma(300, 100);
            //Console.WriteLine(" uso de la funcion  Vertodo.suma {0} ", Total );

            //int Totalresta = verTodos.Resta(500, 10);
            //Console.WriteLine(" uso de la funcion  resta {0} ", Totalresta);



            //Console.WriteLine("-- Ingrese la frecuencia del sonido del 1 al 9 ");
            //int Isonido = Convert.ToInt32(Console.ReadLine());

            //if (Isonido > 9)
            //{
            //    Console.WriteLine("-- Debe ingresar un sonido menor que {0}", Isonido);
            //    Console.ReadKey();
            //}
            //else
            //{
            //    Console.WriteLine("-- usted selecciono {0}", Isonido);

            //    Console.WriteLine("-- Solo escuche --- ");

            //    Sonidosconsolebeep Ver_sonido = new Sonidosconsolebeep();
            //    Ver_sonido.Sonarbeep(5);
            //    Console.ReadKey();
            //}





            //Console.WriteLine("-- Nombres en Balnco para Eliminar ");

            //Elimina_espacio_blanco ver_eliminado = new Elimina_espacio_blanco();

            //ver_eliminado.Ejecutar_Eliminacion();

            //Console.ReadKey();


            // Console.WriteLine("Hola Mundo");
            //Console.Beep();
            //Console.Beep(400, 10);
            //Console.ReadKey();





            //Console.WriteLine("-- Numero de 2 cifras ");
            Elimina_espacio_blanco ver_eliminado = new Elimina_espacio_blanco();
            //ver_eliminado.Numero_2_Cifras();

            Console.WriteLine("-- Numero de 3 cifras ");
            ver_eliminado.Numero_3_Cifras();

            Console.ReadKey();

        }
    }
}

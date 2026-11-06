using System;


namespace InicioApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Ahorros Ver_Todo_Ahorros = new Ahorros();

            Console.WriteLine("Banco de la Esperanza");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Ahorros");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Ingrese Cantidad a depositar");
            int Ideposito = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saldo Disponible : {0} ", Ver_Todo_Ahorros.IverSaldo(Ideposito));

            Console.WriteLine("Ingrese Cantidad a Retirar");

            int Iretiro = Convert.ToInt32(Console.ReadLine());




            Console.ReadKey();





        }
    }
}

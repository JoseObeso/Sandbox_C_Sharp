using System;


namespace InicioApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ahorros Ver_Todo_Ahorros = new Ahorros();

            //Console.WriteLine("Banco de la Esperanza");
            //Console.WriteLine("-------------------------");

            //Console.WriteLine("Ahorros");
            //Console.WriteLine("-------------------------");

            //Console.WriteLine("Ingrese Cantidad a depositar");
            //int Ideposito = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Saldo Disponible : {0} ", Ver_Todo_Ahorros.IverSaldo(Ideposito));

            //Console.WriteLine("Ingrese Cantidad a Retirar");

            //int Iretiro = Convert.ToInt32(Console.ReadLine());


            //Programa3Numeros Evaluar = new Programa3Numeros();
            //Console.WriteLine(Evaluar.Validar3Numeros(5,8,9));



            ExpresionesLogicasv1 Verificar = new ExpresionesLogicasv1();

            // Verificar.VerificarcapacidadTanque(100, 10300);
            //   Verificar.VerificarClima(false, false);

            // Inicio de Switch

            EstructuraSwitch Ver_Switch = new EstructuraSwitch();
            //Ver_Switch.Verificar(50);


            // VContar

            //CicloFor Ver_For = new CicloFor();
            //Ver_For.OpeIncremento(10);



            //ForEachdemo Ver_Letras = new ForEachdemo();
            //Ver_Letras.ForEachEjemplo("Edelmira Facundo Santos");


            ArrayEjemplo Ver_Array = new ArrayEjemplo();
            // Ver_Array.ArrayBasico();

            //  Ver_Array.Crear_Array();


            //ForEachdemo Ver_Letras = new ForEachdemo();
            //Ver_Letras.OtroForEach();



            //  CicloFor Ver_For = new CicloFor();
            // Ver_For.CasFor();


            // ver WriteLinea
            //Aprender_WriteLine Ver_WriteLine = new Aprender_WriteLine();
            //Ver_WriteLine.PrimerWriteLine();


            //if (args.Length==0)
            //{
            //    Console.WriteLine(" Bienvenido, No Ingreso ningun dato");
            //}
            //else if (args.Length==1)
            //{
            //    Console.WriteLine(" Hola :{0} ", args[0]);
            //}
            //else
            //{
            //    Console.WriteLine(" Hola :{0}, hola tambien a {1}", args[0], args[1]);
            //}




            // ArrayListDatos ver_Arraylist = new ArrayListDatos();

            // ver_Arraylist.PrimerArrayList();


            // ver WriteLinea
            //Aprender_WriteLine Ver_WriteLine = new Aprender_WriteLine();
            //Ver_WriteLine.MostrarCW();



            SintaxysBasicaCSharp Ver_Syntaxis = new SintaxysBasicaCSharp();

            // Ver_Syntaxis.BoolEjemplo();

            // Ver_Syntaxis.Convertira_Cadena();

            // Ver_Syntaxis.InputEjemplo();

            // Ver_Syntaxis.InputEdad();
            // Ver_Syntaxis.ConcatenarCadenaTexto();
            // Ver_Syntaxis.Add_demo();

            // Ver_Syntaxis.CondicionIFelseIF();


            //CicloFor Ver_For = new CicloFor();
            //Ver_For.CasForSuma();


            ArrayEjemplo ver_Array = new ArrayEjemplo();

            //  ver_Array.Tipos_array();

            //MyMethod();
            //MostrarNombres("Jose");
            //MostrarNombres("Mery Edel");
            //MostrarNombres("Maria Edelmira");

            Paises("Chile");

            Paises("Colombia");
            Paises();




        }
        static void MyMethod()
        {
            Console.WriteLine("Desde un Metodo");
        }

        static void MostrarNombres(string fname)
        {
            Console.WriteLine(fname + " Fue llamado");
        }

        static void Paises(string country = "Peru")
        {
            Console.WriteLine(country);
        }


    }

   
}

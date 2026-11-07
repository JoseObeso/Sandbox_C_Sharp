using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class ExpresionesLogicasv1
    {

        public void VerificarcapacidadTanque(int Tanque, int Recorrido)
        {
            if (Tanque < 50 && Recorrido > 240)
            {
                Console.WriteLine("Vehiculo en Buen estado");
            }
            else
            {
                Console.WriteLine("vehiculo en Mal Estado");
            }
        }

        public void VerificarClima(bool Lluvia, bool Sol)
        {
            if (Lluvia == true ||  Sol == true)
            {
                Console.WriteLine("clima loco");
            }
            else
            {
                Console.WriteLine("clima  super loco");
            }

        }





    }
}

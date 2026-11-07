using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class EstructuraSwitch
    {

        public void Verificar(int Iedad)
        {
            switch (Iedad)
            {
                case 10:
                    Console.WriteLine("Menor de Edad");
                    break;
                case 15:
                    Console.WriteLine("Joven");
                    break;
                case 20:
                    Console.WriteLine("Ventiañero");
                    break;
                default:
                    Console.WriteLine("No definido");
                    break;
            }

        }


    }
}

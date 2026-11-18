using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioApp
{
    public class Clase1_Figuras
    {


        public class Cubo
        {
            // Declaramos los datos
            public int lado;
            public int area;
            public int volumen;

            // Método para calcular el área
            public void CalculaArea()
            {
                area = (lado * lado) * 6;
            }
            // Método para calcular el volumen
            public void CalculaVolumen()
            {
                volumen = lado * lado * lado;
            }
        }







    }





}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operacion
    {
        //Contiene 3 metodos sobre calculo de operaciones area de un cuadrado, perimetro de un cuadrado y volumen de un cubo

        public double AreaCuadrado(double lado)
        {
            return lado * lado;
        }

        public double PerimentroCuadrado(double lado) 
        { 
            return lado * 4;
        }

        public double VolumenCubo(double lado)
        {
            return lado * lado * lado;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    //Herencia de la clase padre Operacion

    public class Calculo: Operacion
    {
        public double Lado { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public double Volumen { get; set; }

      public Calculo(double lado)
       {
            Area=AreaCuadrado(lado);
            Perimetro=PerimentroCuadrado(lado);
            Volumen=VolumenCubo(lado);
           
       }

        public void Imprimir()
        {
            Console.WriteLine("-----------Resultado de Operaciones-----------");
            Console.WriteLine($"Área del cuadrado: {Area}");
            Console.WriteLine($"Perímetro del cuadrado: {Perimetro}");
            Console.WriteLine($"Volumen del cubo: {Volumen}");
        }


    }
}

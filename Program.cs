using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Program
    {
        static void Main(string[] args)
        {
          
          
           Console.Write("Ingrese el numero para desarrollar las operaciones:");
           double lado = Convert.ToDouble(Console.ReadLine());
           
            //Instanciando y enviando parametro
            Calculo calculo = new Calculo(lado);
            //llamando al metodo imprimir
            calculo.Imprimir();




        }
    }
}

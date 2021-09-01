using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        
        //Declarar las variables necesarias para mostrar 
        //en pantalla el calculo del perímetro del triangulo que se encuentra a la derecha.
        //Debera imprimir el siguiente mensaje: “El perímetro del triangulo es: “ <perímetro“>
        //p=a+b+c //variables a=10 b=10 c=7

        static void Main(string[] args)
        {
            int a = 10;
            int b = 10;
            int c = 7;
            int p = a + b + c;
            Console.WriteLine("El perímetro del triangulo es:" + p);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();

        }
    }
}

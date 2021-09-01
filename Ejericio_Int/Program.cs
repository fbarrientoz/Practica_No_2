using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio_Int
{
    class Program
    {
        //Ctrk + k + C
        //CTRL + k + U
        //Crear tres variables de tipo INT y asignarles valores estáticos.
        //Crear una variable de tipo INT la cual guardará la SUMA de las tres variables anteriores.
        //Mostrar en pantalla el valor de SUMA, con el siguiente mensaje “El valor de SUMA es:” <suma>
        static void Main(string[] args)
        {
            int numero_1 = 5;
            int numero_2 = 10;
            int numero_3 = 20;
            int suma = numero_1 + numero_2 + numero_3;
            Console.WriteLine("El valor de Suma es:" + suma);
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}

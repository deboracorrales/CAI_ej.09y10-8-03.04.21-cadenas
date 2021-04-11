using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_ej._09y10_8_03._04._21_cadenas
/*Ej     
9. Solicite un ingreso al usuario y lo presente en mayúsculas.
10. Solicite un ingreso al usuario y lo presente en minúsculas.		*/
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto;

            Console.WriteLine("Ingrese una palabra.");
            texto = Console.ReadLine();

            Console.WriteLine("Usted ingreso: " + texto.ToUpper());
            Console.WriteLine("Usted ingreso: " + texto.ToLower());

            Console.ReadKey();
        }
    }
}

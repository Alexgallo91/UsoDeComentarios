using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comentarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");

            /* Console.WriteLine("Hola");
            Console.WriteLine("Bonjour");*/

            ClaseSimple n = new ClaseSimple();
            string city = "London";

            if (city == "London")
            {
                Console.WriteLine("khe?");
            }
        }
    }

    /// <summary>
    /// Este es solo una clase de ejemplo con documentacion en XML
    /// gracias a las tres diagonales
    /// </summary>
    public class ClaseSimple
    {

    }
}

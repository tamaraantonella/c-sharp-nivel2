using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Telefono jesus = new Telefono("S8", "Samsung");
            Console.WriteLine("El modelo del telefono es: " + jesus.Modelo);
            Console.WriteLine(jesus.Llamar());

            Telefono tamara = new Telefono("A53", "Motorola");
            //setter
            tamara.CodigoOperador = 1;
            //getter
            int value= tamara.CodigoOperador;
            Console.WriteLine(value);
        }
    }
}

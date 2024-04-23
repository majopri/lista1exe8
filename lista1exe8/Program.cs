using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exe8
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("conversor de temperatura de Celsius para Fahrenheit");
            Console.WriteLine("Digite a temperatura em graus Celsius:");

            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine($" A temperatura em Fahrenheit é: {fahrenheit:F2} °F");
        }
    }
}

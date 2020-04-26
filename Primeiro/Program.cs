using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite as medidas do triângulo X :");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite as medidas do triângulo Y :");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaA = x.calculaArea();
            double areaB = y.calculaArea();

            Console.WriteLine("A área do Triangulo X é : " + areaA.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("A área do Triangulo Y é : " + areaB.ToString("F4", CultureInfo.InvariantCulture));

            if (areaA > areaB)
            {
                Console.WriteLine("O triângulo X é maior!");
            }
            else
            {
                Console.WriteLine("O triângulo Y é maior!");
            }

        }

        
    }
}

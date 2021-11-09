using System;
using System.Diagnostics;

namespace Calculadora
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine(args.Length);

            Console.WriteLine("¿Qué operación quiere realizar?");
            Console.Write("(Suma - s / Resta - r / Multiplicacion - m / Divison - d): ");
            String operacion = Console.ReadLine();

            decimal num1 = 0;
            decimal num2 = 0;
            string argumentoOperacion = "";


            switch (operacion)
            {
                case "s":

                    Console.Write("Introduce valor para numero1 : ");
                    num1 = Decimal.Parse(Console.ReadLine());
                    Console.Write("Introduce valor para numero2 : ");
                    num2 = Decimal.Parse(Console.ReadLine());
                    argumentoOperacion = "--add";


                    ProcessStartInfo startInfo = new ProcessStartInfo(@"F:\DAM2A\Programacion de Servicios y Procesos\PracticaCalculadora\Calculadora\Calculadora\bin\Debug\net5.0\Calculadora.exe");
                    startInfo.Arguments = $"{argumentoOperacion} {num1} {num2}";
                    Process.Start(startInfo);


                    break;

                case "r":

                    break;

                default:
                    //ProcessStartInfo startInfo = new ProcessStartInfo(@"F:\DAM2A\Programacion de Servicios y Procesos\PracticaCalculadora\Calculadora\Calculadora\bin\Debug\net5.0\Calculadora.exe");
                    //startInfo.Arguments = $"{argumentoOperacion} {num1} {num2}";
                    //Process.Start(startInfo);
                    break;

            }

            return 0;
        }
    }
}

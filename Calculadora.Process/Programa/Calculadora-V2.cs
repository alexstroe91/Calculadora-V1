using System;
using System.Diagnostics;

namespace Calculadora
{
    class Program
    {

        public static void llamarProceso(decimal num1, decimal num2, string operacion)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@".\Vinculos\Calculadora.exe");
            startInfo.Arguments = $"{operacion} {num1} {num2}";
            startInfo.UseShellExecute = false;
            Process.Start(startInfo);
        }

        static int Main(string[] args)
        {
            try
            {
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

                        llamarProceso(num1, num2, argumentoOperacion);

                        return 0;
                        break;

                    case "r":
                        Console.Write("Introduce valor para numero1 : ");
                        num1 = Decimal.Parse(Console.ReadLine());
                        Console.Write("Introduce valor para numero2 : ");
                        num2 = Decimal.Parse(Console.ReadLine());
                        argumentoOperacion = "--sub";

                        llamarProceso(num1, num2, argumentoOperacion);

                        return 0;
                        break;

                    case "m":

                        Console.Write("Introduce valor para numero1 : ");
                        num1 = Decimal.Parse(Console.ReadLine());
                        Console.Write("Introduce valor para numero2 : ");
                        num2 = Decimal.Parse(Console.ReadLine());
                        argumentoOperacion = "--mul";

                        llamarProceso(num1, num2, argumentoOperacion);

                        return 0;
                        break;

                    case "d":

                        Console.Write("Introduce valor para numero1 : ");
                        num1 = Decimal.Parse(Console.ReadLine());
                        Console.Write("Introduce valor para numero2 : ");
                        num2 = Decimal.Parse(Console.ReadLine());
                        argumentoOperacion = "--div";

                        llamarProceso(num1, num2, argumentoOperacion);

                        return 0;
                        break;

                    default:

                        throw new Exception("Opcion incorrecta");
                        break;

                }

                Console.WriteLine();
                return 0;

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}

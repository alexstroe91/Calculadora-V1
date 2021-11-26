using System;
using System.Diagnostics;

namespace Calculadora
{
    class Program
    {

        //este metodo no se utiliza
        public static void llamarProceso(decimal num1, decimal num2, string operacion)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@".\Vinculos\Calculadora.exe");
            startInfo.Arguments = $"{operacion} {num1} {num2}";
            startInfo.UseShellExecute = false;
            Process.Start(startInfo);
        }

        private static void CallChildProcess (String commandLine)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = @".\Vinculos\Calculadora.exe",
                Arguments = commandLine,
                //el hijo no puede escribir en consola
                UseShellExecute = false,
                //capturar los errores que genere el hijo
                RedirectStandardError = true,
                //todos los mensajes que haga el hijo, los captura el padre
                RedirectStandardOutput = true
                
            };

            //arrancar el proceso
            using Process process = Process.Start(startInfo);

            //captura las entradas de errores y la entrada de los mensajes del hijo
            var errorReader = process.StandardError;
            var outputWriter = process.StandardOutput;

            //espera a que termine el proceso hijo
            process.WaitForExit();

            if (process.ExitCode == 0)
            {
                //captura el mensjae del hijo y lo muestra en pantalla
                Console.WriteLine("El proceso finalizo con exito");
                var resultado = outputWriter.ReadToEnd();
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine($"Se produjo un error con codigo: {process.ExitCode} ");
            }

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

                        Console.Write("Introduce valor para numero 1 : ");
                        num1 = Decimal.Parse(Console.ReadLine());
                        Console.Write("Introduce valor para numero 2 : ");
                        num2 = Decimal.Parse(Console.ReadLine());
                        argumentoOperacion = "--add";

                        //llamarProceso(num1, num2, argumentoOperacion);
                        CallChildProcess($"{argumentoOperacion} {num1} {num2} ");

                        return 0;

                    case "r":
                        Console.Write("Introduce valor para numero 1 : ");
                        num1 = Decimal.Parse(Console.ReadLine());
                        Console.Write("Introduce valor para numero 2 : ");
                        num2 = Decimal.Parse(Console.ReadLine());
                        argumentoOperacion = "--sub";

                        //llamarProceso(num1, num2, argumentoOperacion);
                        CallChildProcess($"{argumentoOperacion} {num1} {num2} ");

                        return 0;

                    case "m":

                        Console.Write("Introduce valor para numero 1 : ");
                        num1 = Decimal.Parse(Console.ReadLine());
                        Console.Write("Introduce valor para numero 2 : ");
                        num2 = Decimal.Parse(Console.ReadLine());
                        argumentoOperacion = "--mul";

                        //llamarProceso(num1, num2, argumentoOperacion);
                        CallChildProcess($"{argumentoOperacion} {num1} {num2} ");

                        return 0;

                    case "d":

                        Console.Write("Introduce valor para numero 1 : ");
                        num1 = Decimal.Parse(Console.ReadLine());
                        Console.Write("Introduce valor para numero 2 : ");
                        num2 = Decimal.Parse(Console.ReadLine());
                        argumentoOperacion = "--div";

                        //llamarProceso(num1, num2, argumentoOperacion);
                        CallChildProcess($"{argumentoOperacion} {num1} {num2} ");

                        return 0;

                    default:

                        throw new Exception("Opcion incorrecta");

                }


            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}

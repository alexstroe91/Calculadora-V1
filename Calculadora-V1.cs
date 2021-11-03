using System;

namespace Calculadora
{
    class calculadora1
    {
        static int Main(string[] args)
        {

            String operacion = args[0];

            try
            {
                if (args.Length < 3)
                {
                    throw new Exception($"--Error-- : No has introducido todos los parametros requeridos (3) . Parametros introducidos: ({args.Length})");
                }
                else if (args.Length > 3)
                {
                    throw new Exception($"--Error-- : Has introducido más argumentos que los necesarios (3). Parametros introducidos: ({args.Length})");
                }
                else
                {
                    switch (operacion)
                    {
                        case "--add":
                            Console.WriteLine($"{args[1]} + {args[2]} = {decimal.Parse(args[1]) + decimal.Parse(args[2])}");
                            break;
                        case "--sub":
                            Console.WriteLine($"{args[1]} - {args[2]} = {decimal.Parse(args[1]) - decimal.Parse(args[2])}");
                            break;
                        case "--div":

                            if (decimal.Parse(args[2]) == 0)
                            {
                                throw new Exception("--Error-- : El divisor no puede ser 0");
                            }
                            else
                            {
                                Console.WriteLine($"{args[1]} / {args[2]} = {decimal.Parse(args[1]) / decimal.Parse(args[2])}");
                            }

                            break;
                        case "--mul":
                            Console.WriteLine($"{args[1]} x {args[2]} = {decimal.Parse(args[1]) * decimal.Parse(args[2])}");
                            break;
                        default:
                            throw new Exception($"--Error-- : Ninguna de los argumentos indicados es correcto: {args[1]} ");
                            break;

                    }
                    return 0;
                }
            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}

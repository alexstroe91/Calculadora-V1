using System;

namespace Calculadora
{
    class calculadora1
    {
        static int Main(string[] args)
        {
            //Comienzo del bloque try catch
            try
            {
                //compruebo la cantidad de argumentos que se introducen
                if (args.Length < 3)
                {
                    //en el caso de que introduzca menos arugmentos de los necesarios lanzo la excepcion siguiente.
                    throw new Exception($"--Error-- : No has introducido todos los parametros requeridos (3) . Parametros introducidos: ({args.Length})");
                }
                else if (args.Length > 3)
                {
                    //en el caso de que introduzca mas arugmentos de los necesarios lanzo la excepcion siguiente.
                    throw new Exception($"--Error-- : Has introducido más argumentos que los necesarios (3). Parametros introducidos: ({args.Length})");
                }
                else
                {
                    //en el caso de que los argumentos sean los que necesito, comienza el bloque de ejecución.
                    switch (args[0])
                    {
                        //realizo las operaciones necesarias dependiendo de que operación elige el usuario
                        case "--add":
                            Console.WriteLine($"{args[1]} + {args[2]} = {decimal.Parse(args[1]) + decimal.Parse(args[2])}");
                            break;
                        case "--sub":
                            Console.WriteLine($"{args[1]} - {args[2]} = {decimal.Parse(args[1]) - decimal.Parse(args[2])}");
                            break;
                        case "--div":
                            //en el caso en el que el divisor es 0, como esa operacion no puede realizarse, lanzo la excepcion necesaria
                            if (decimal.Parse(args[2]) == 0)
                            {
                                throw new Exception("--Error-- : El divisor no puede ser 0");
                            }
                            else
                            {
                                //en el caso de que no, realizo la operacion
                                Console.WriteLine($"{args[1]} / {args[2]} = {decimal.Parse(args[1]) / decimal.Parse(args[2])}");
                            }

                            break;
                        case "--mul":
                            Console.WriteLine($"{args[1]} x {args[2]} = {decimal.Parse(args[1]) * decimal.Parse(args[2])}");
                            break;
                        default:
                            //en el caso que el usuario no introduzca los argumentos correctamente, se lanza otra excepcion
                            throw new Exception($"--Error-- : Ninguna de los argumentos indicados es correcto: {args[1]} ");
                            break;

                    }
                    // después de realizar las operaciones, se retorna 0, por que el código se ha realizado correctamente.
                    return 0;
                }
            } catch (Exception ex)
            {
                //se capturan las excepciones que se han lanzado durante la ejecución del código
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}

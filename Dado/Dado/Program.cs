using System;

namespace Dado
{
    class Dado
    {
        static void Main(string[] args)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);
            Console.WriteLine("Presionar Enter para una nueva visualizacion o Escape para salir del programa.");
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                while (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Nueva visualizacion");
                    var superior = random.Next(1, 6);
                    var izquierda = random.Next(1, 6);
                    while(izquierda == superior || izquierda == 7 - superior)
                    {
                        izquierda = random.Next(1, 6);
                    }
                    var frontal = random.Next(1, 6);
                    while ((frontal == superior && frontal != izquierda) || (frontal != superior && frontal == izquierda) || frontal == 7 - superior || frontal == 7 -izquierda)
                    {
                        frontal = random.Next(1, 6);
                    }
                    Console.WriteLine("{0} {1} {2}", superior, izquierda, frontal);
                    DibujarDado(superior, izquierda, frontal);
                    Console.WriteLine("");
                }
            }
        }
        static void DibujarDado(int caraSuperior, int caraFrontal, int caraIzquierda)
        {
            Console.WriteLine("        *****");
            Console.WriteLine("        *   *");
            Console.WriteLine("        * {0} *",caraSuperior);
            Console.WriteLine("        *   *");
            Console.WriteLine("*****************");
            Console.WriteLine("*   *   *   *   *");
            Console.WriteLine("* {0} * {1} * {2} * {3} *", 7 - caraFrontal, 7 - caraIzquierda, caraFrontal, caraIzquierda);
            Console.WriteLine("*   *   *   *   *");
            Console.WriteLine("*****************");
            Console.WriteLine("        *   *");
            Console.WriteLine("        * {0} *", 7 - caraSuperior);
            Console.WriteLine("        *   *");
            Console.WriteLine("        *****");
        }
    }
}

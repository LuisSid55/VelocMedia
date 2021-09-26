using System;

namespace VelocMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            double v, d, t;

            Console.WriteLine("\n--Velocidade média--\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Para calcular a velocidade média, digite a ");
            Console.WriteLine("distância (metros) e tempo(segundos).\n");
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Distancia percorrida (m): ");
            d = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tempo gasto (s): ");
            t = Convert.ToDouble(Console.ReadLine());

            v = d / t;

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"\nA velocidade média é: {v:N2} m/s\n");
            Console.ResetColor();
        }
    }
}

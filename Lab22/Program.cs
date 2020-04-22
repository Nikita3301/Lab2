using System;

namespace Lab22
{
    public static class Program
    {
        public static double Calc(double x)
        {
            double y = Math.Log10(x) / (4 * x + 13);
            return y;
        }

        private static void Main()
        {
            double x = 0, dx = 1;
            Console.Write("Iнтервал змiни значень x\nвiд(a): ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("До(b): ");
            double b = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.Write("Крок(dx)(додатнє значення): ");
                dx = Convert.ToDouble(Console.ReadLine());
            } while (dx <= 0);
            Console.Write("  x\t\t y \t\n");
            for (x = a; x <= b; x += dx)
            {
                double y = Calc(x); 
                if (x <= 0 || 4 * x + 13 == 0)
                {
                    Console.WriteLine("  {0}\t\t Виключення ", Math.Round(x, 3));
                }
                else
                    Console.WriteLine("  {0}\t\t {1}", Math.Round(x, 3), Math.Round(y, 3));

            }
        }
    }
}
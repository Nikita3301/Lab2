using System;

namespace Lab23._2
{
    static class Program
    {
        private static int Five(int []number,uint length, int k)
        {
            for (int l = 0; l < length; l++)
            {
                if (number[l] > 5)
                {
                    k++;
                }
            }
            return k;
        }

        private static int Sum(int []number, int sum, int m, uint length )
        {
            for (int j=m+1; j < length; j++)
            {
                sum += number[j];
            }
            return sum;
        }
        public static void Main()
        {
            int k = 0, m = 1, j = 1, sum = 0;
            uint length;
            Console.WriteLine("Кiлькiсть чисел:");
            string length1= Console.ReadLine();
            while (!uint.TryParse(length1,out length))
            {
                Console.WriteLine("Кiлькiсть чисел:");
                length1= Console.ReadLine();
            }
            length = Convert.ToUInt32(length1);
            int[] number = new int[length];
            Random rnd = new Random();
            int max = -100;
            for (int i = 0; i < length; i++)
            { 
                number[i] = rnd.Next(-100, 100);
                Console.WriteLine((i+1) + ":" + number[i]);
                if (number[i] > max)
                {
                    m = i;
                    max = number[i];
                }
            }
            k = Five(number, length, k);
            Console.WriteLine("Кiлькiсть елементiв бiльше п'яти:" + k);
            sum = Sum(number, sum, m, length);
            Console.WriteLine("Сумма елементiв (пiсля найбiльшого):" + sum);
        }
    }
}

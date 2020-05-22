using System;

namespace Lab23._1
{
    public class Program
    {
        public static int Five(int []number,uint length, int k)
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

        public static int Sum(int []number, int sum, int m, uint length )
        {
            for (int j = m+1; j < length; j++)
            {
                sum += number[j];
                Console.WriteLine(number[j]+"   "+sum);
            }
            return sum;
        }
        
        public static void Main()
        {
            int k = 0, m = 1, j = 1, sum = 0;
            uint length=1; 
            Console.WriteLine("Кiлькiсть чисел:");
            string length1= Console.ReadLine();
            while (!uint.TryParse(length1,out length))
            {
                Console.WriteLine("Кiлькiсть чисел:");
                length1= Console.ReadLine();
            }
            length = Convert.ToUInt32(length1);
        
            int[] number= new int[length];
            int max = number[0];
            for (int i = 0; i < length ; i++)
            {
                Console.Write((i + 1) + ":");
                number[i] = Convert.ToInt32(Console.ReadLine());
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

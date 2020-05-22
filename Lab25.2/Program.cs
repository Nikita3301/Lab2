using System;

namespace Lab25._2
{
    public static class Program
    {
        public static void Main()
        {
            int total = 0, h = 0, q = 0;
            Console.WriteLine("Розмiрнiсть матрицi:");
            uint n, m;
            Console.Write("Кiлькiсть рядкiв:");
            
            // захист від введення некоректних даних з клавіатури
            string n1 = Console.ReadLine();
            while (!uint.TryParse(n1, out n))
            {
                Console.WriteLine("Невiрне значення");
                Console.Write("Кiлькiсть рядкiв:");
                n1 = Console.ReadLine();
            }
            n = Convert.ToUInt32(n1);
            Console.Write("Кiлькiсть стовпцiв:");
            string m1 = Console.ReadLine();
            while (!uint.TryParse(m1, out m))
            {
                Console.WriteLine("Невiрне значення");
                Console.Write("Кiлькiсть стовпцiв:");
                m1 = Console.ReadLine();
            }
            m = Convert.ToUInt32(m1);
            //генератор псевдовипадкових чисел з відрізка [-100; 100]
            Random rnd = new Random();
            
            //цілочислова матриця А розмірності nxm
            Console.WriteLine("Показ матрицi:");
            int[,]A = new int[n,m];
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    A[i,j] = rnd.Next(-100, 100);
                    Console.Write(A[i, j] + "\t");
                }
                Console.Write("\n");
            }
            // перетворення в одновимірний масив
            int[] arr2 = new int[m * n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr2[q++] = A[i, j];
                }
            }
            Console.WriteLine("Кiлькiсть повторень:"); 
            int[] findNum = new int[m*n];
            for (q=0; q < m * n; q++)
            {
                findNum[q] = arr2[h];
                for (int i = 0; i < m * n; i++)
                {
                    if (arr2[i] == findNum[q]) total++;
                }
                Console.WriteLine("Число " + findNum[q] + " повторюється " + total + " раз(и)");
                total = 0;
                h++;
            }
        }
    }
}

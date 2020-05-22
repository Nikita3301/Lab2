using System;

namespace Lab25
{
    public static class Program
    {
        static void Main()
        {
            int total = 0, r = 0, h = 0, str = 0;
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
            // введення значень
            int[,]A = new int[n , m];
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write( "A ["+i+";"+j+"]"+":" );
                    string str1 = Console.ReadLine();
                    while (!int.TryParse(str1, out str))
                    {
                        Console.WriteLine("Невiрне значення");
                        Console.Write( "A["+i+";"+j+"]"+":" );
                        str1 = Console.ReadLine();
                    }
                    str = Convert.ToInt32(str1);
                    A[i, j] = str;
                   
                }
            }
            Console.WriteLine("Показ матрицi:");
            for (int i = 0; i < n ; i++)
            {
                for (int j = 0; j < m; j++)
                {
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
                    arr2[r++] = A[i, j];
                }
            }
            int[] findNum = new int[n*m];
            Console.WriteLine("Кiлькiсть повторень:");
            for (r=0; r < m * n; r++)
            {
                findNum[r] = arr2[h];
                for (int i = 0; i < m * n; i++)
                {
                    if (arr2[i] == findNum[r]) total++;
                }
                Console.WriteLine("Число " + findNum[r] + " повторюється " + total + " раз(и)");
                total = 0;
                h++;
            }
        }
    }
}

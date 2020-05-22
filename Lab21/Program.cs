using System;

namespace Lab21
{
    public class Program
    {
        public static string Number(int number)
        {
            string c;
            switch (number)
            {
                case 1:
                    c = "початкова: Залiзничний вокзал\nкiнцева:  вул.Пасiчна";
                    break;
                case 2:
                    c = "початкова: вул.Пасiчна\nкiнцева: вул.Коновальця";
                    break;
                case 3:
                    c = "початкова: пл.Соборна\nкiнцева: Аквапарк";
                    break;
                case 4:
                    c = "початкова: Залiзничний вокзал\nкiнцева: вул.Вернадського";
                    break;
                case 5:
                    c = "початкова: вул.Миколайчука\nкiнцева: вул.Коновальця";
                    break;
                case 6:
                    c = "початкова: вул.Миколайчука\nкiнцева: ТРЦ 'Скриня'";
                    break;
                case 7:
                    c = "початкова: Погулянка\nкiнцева: церква святої Анни";
                    break;
                case 8:
                    c = "початкова: пл.Соборна\nкiнцева: вул.Вернадського";
                    break;
                case 9:
                    c = "початкова: Залiзничний вокзал\nкiнцева: вул.Торфяна";
                    break;
                default:
                    c = "Невiрне значення";
                    break;
            }
            return c;
        }
        static void Main()
        {
            string c;
            Console.Write("Введiть номер трамваю (вiд 1 до 9): ");
            int number = Convert.ToInt32(Console.ReadLine());
            c = Number(number);
            Console.WriteLine(c);
        }
    }
}

using Tyuiu.SafarovTA.Sprint1.Task0.V26.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task0.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #0                                                                     *");
            Console.WriteLine("* Вариант #26                                                                    *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 4*5/2-18/2/3                   *");
            Console.WriteLine("* и печатает результат на экране.                                                *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* 4*5/2-18/2/3                                                                   *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine(ds.Calculate());

            int i = 5;

            double f = 7.5;

            double dbl = 10.01;

            Console.WriteLine("i=" + i + "\\f=" + f + "\\dbl=" + dbl);

            Console.ReadLine();
        }
    }
}

using Tyuiu.SafarovTA.Sprint1.Task3.V17.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task3.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #3                                                                     *");
            Console.WriteLine("* Вариант #17                                                                    *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых трех              *");
            Console.WriteLine("* цифр из дробной части заданного вещественного числа цифра 0.                   *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Введите вещественное число: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine(ds.ZeroCheck(x));

            Console.ReadLine();
        }
    }
}

using Tyuiu.SafarovTA.Sprint1.Task4.V6.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task4.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #4                                                                     *");
            Console.WriteLine("* Вариант #6                                                                     *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,        *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране. Ответ округлите до    *");
            Console.WriteLine("* 3 знаков после запятой.                                                        *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Введите вещественное число: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите вещественное число: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}

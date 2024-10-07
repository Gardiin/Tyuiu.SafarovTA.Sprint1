using Tyuiu.SafarovTA.Sprint1.Task7.V3.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task7.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #7                                                                     *");
            Console.WriteLine("* Вариант #3                                                                     *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным     *");
            Console.WriteLine("* значениям данных, вводимых пользователем. Ответ округлите до 3 знаков          *");
            Console.WriteLine("* после запятой.                                                                 *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Сложное для ввода в юникод уравнение, посмотрите в датасервисе                 *");

            Console.WriteLine("Введите а: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine(ds.Calculate(a, b));

            Console.ReadLine();
        }
    }
}

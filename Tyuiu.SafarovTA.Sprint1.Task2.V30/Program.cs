using Tyuiu.SafarovTA.Sprint1.Task2.V30.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task2.V30
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
            Console.WriteLine("* Задание #2                                                                     *");
            Console.WriteLine("* Вариант #30                                                                    *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,        *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.                    *");
            Console.WriteLine("* Формулировка задания: Известно расстояние в километрах. Перевести расстояние   *");
            Console.WriteLine("* в метры. Ответ округлите до 3 знаков после запятой.                            *");
            Console.WriteLine("* Что пользователь вводит? Расстояние в километрах (вещественное число)          *");
            Console.WriteLine("* Что программа печатает на экране? Расстояние в метрах (вещественное число)     *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Введите количество километров: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine(ds.ConvertKmToMetre(x));

            Console.ReadLine();
        }
    }
}

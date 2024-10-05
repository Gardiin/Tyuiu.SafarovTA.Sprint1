using Tyuiu.SafarovTA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k;
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #5                                                                     *");
            Console.WriteLine("* Вариант #6                                                                     *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                           *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n значение 1,2,...,7 в *");
            Console.WriteLine("* зависимости от того, на какой день недели (понедельник, вторник,...,           *");
            Console.WriteLine("* восересенье), в котором 1 января – понедельник.                                *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Введите число от 1 до 365: ");
            k = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine(ds.Calculate(k));

            Console.ReadLine();
        }
    }
}

﻿using Tyuiu.SafarovTA.Sprint1.Task1.V16.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task1.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* Спринт #1                                                                      *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
            Console.WriteLine("* Задание #1                                                                     *");
            Console.WriteLine("* Вариант #16                                                                    *");
            Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                       *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,        *");
            Console.WriteLine("* вычисляет результат по формуле x*5*y+2*a и печатает его на экране.             *");
            Console.WriteLine("*                                                                                *");
            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
            Console.WriteLine("**********************************************************************************");

            double x, y, a;

            Console.WriteLine("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение A: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**********************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
            Console.WriteLine("**********************************************************************************");

            Console.WriteLine("Введите значение X: ");
            Console.WriteLine(ds.Calculate(x, y, a));

            Console.ReadLine();
        }
    }
}

using Tyuiu.SafarovTA.Sprint1.Task0.V26.Lib;

Console.WriteLine("**********************************************************************************");
Console.WriteLine("* Спринт #1                                                                      *");
Console.WriteLine("* Тема: Базовые навыки работы в C#                                               *");
Console.WriteLine("* Задание #0                                                                     *");
Console.WriteLine("* Вариант #0                                                                     *");
Console.WriteLine("* Выполнил: Сафаров Тимур Андреевич | РППБ-24-1                                  *");
Console.WriteLine("**********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                       *");
Console.WriteLine("* Написать программу, которая вычисляет выражение 10 / (2 + 3)                   *");
Console.WriteLine("* и печатает результат на экране.                                                *");
Console.WriteLine("*                                                                                *");
Console.WriteLine("**********************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                               *");
Console.WriteLine("**********************************************************************************");
Console.WriteLine("* 10 / (2 + 3)                                                                   *");
Console.WriteLine("**********************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                     *");
Console.WriteLine("**********************************************************************************");

  < ItemGroup >
    < Reference Include = "tyuiu.cources.programming.interfaces" >
      < HintPath > ..\..\Tyuiu.SafarovTA.Sprint1\tyuiu.cources.programming.interfaces.dll </ HintPath >
    </ Reference >
  </ ItemGroup >


using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SafarovTA.Sprint1.Task0.V26.Lib
{
    public class DataService : ISprint1Task0V26
    {
        public double Calculate()
        {
            return (4 * 5 / 2 - 18 / 2 / 3);
        }
    }
}


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

            Console.ReadLine();
        }
    }
}


using Tyuiu.SafarovTA.Sprint1.Task0.V26.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(7, res);
        }
    }
}

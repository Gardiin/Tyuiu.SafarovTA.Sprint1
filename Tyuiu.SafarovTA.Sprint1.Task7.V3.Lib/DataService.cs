using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SafarovTA.Sprint1.Task7.V3.Lib
{
    public class DataService : ISprint1Task7V3
    {
        public double Calculate(double x, double y)
        {
            return Math.Round((3 + Math.Pow(Math.Exp(1), y - 1)) / (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x))), 3);
        }
    }
}

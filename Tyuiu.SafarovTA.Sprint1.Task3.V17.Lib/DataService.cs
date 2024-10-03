using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SafarovTA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            bool flag = false;
            string str = Convert.ToString(number);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '0')
                {
                    flag = true;
                }
            }
            return flag;
        }
    }
}

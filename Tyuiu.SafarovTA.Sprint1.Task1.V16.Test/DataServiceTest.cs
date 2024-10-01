using Tyuiu.SafarovTA.Sprint1.Task1.V16.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task1.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            double a = 1.0;
            var res = ds.Calculate(x, y, a);
            Assert.AreEqual(7, res);
        }
    }
}
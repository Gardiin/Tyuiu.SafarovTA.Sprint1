using Tyuiu.SafarovTA.Sprint1.Task4.V6.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task4.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.167, res);
        }
    }
}
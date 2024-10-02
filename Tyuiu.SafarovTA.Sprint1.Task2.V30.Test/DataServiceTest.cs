using Tyuiu.SafarovTA.Sprint1.Task2.V30.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task2.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2;
            var res = ds.ConvertKmToMetre(a);
            Assert.AreEqual(2000.0, res);
        }
    }
}
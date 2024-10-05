using Tyuiu.SafarovTA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 8;
            var res = ds.Calculate(k);
            Assert.AreEqual(1, res);
        }
    }
}
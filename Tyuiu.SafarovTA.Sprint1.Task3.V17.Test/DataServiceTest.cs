using Tyuiu.SafarovTA.Sprint1.Task3.V17.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task3.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 2.1002;
            var res = ds.ZeroCheck(a);
            Assert.AreEqual(true, res);
        }
    }
}
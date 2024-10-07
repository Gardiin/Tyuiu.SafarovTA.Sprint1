using Tyuiu.SafarovTA.Sprint1.Task7.V3.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task7.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2; int b = 3;
            var res = ds.Calculate(a, b);
            Assert.AreEqual(0.478, res);
        }
    }
}

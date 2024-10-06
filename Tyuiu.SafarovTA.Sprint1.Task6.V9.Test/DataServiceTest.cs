using Tyuiu.SafarovTA.Sprint1.Task6.V9.Lib;
namespace Tyuiu.SafarovTA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string k = "привет мир";
            var res = ds.MoveLetterToStart(k);
            Assert.AreEqual("тприве рми", res);
        }
    }
}
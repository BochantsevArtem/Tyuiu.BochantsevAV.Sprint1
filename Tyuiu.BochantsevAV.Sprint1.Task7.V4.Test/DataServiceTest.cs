using Tyuiu.BochantsevAV.Sprint1.Task7.V4.Lib;
namespace Tyuiu.BochantsevAV.Sprint1.Task7.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(2, 4);

            Assert.AreEqual(0.545, result, 0.001);
        }
    }
}

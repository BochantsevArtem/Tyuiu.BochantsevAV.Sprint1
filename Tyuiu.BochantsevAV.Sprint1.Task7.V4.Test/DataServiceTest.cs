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

            double result = ds.Calculate(4, 5);

            Assert.AreEqual(2.315, result, 0.001);
        }
    }
}

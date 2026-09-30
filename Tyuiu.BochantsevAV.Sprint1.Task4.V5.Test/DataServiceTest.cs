using Tyuiu.BochantsevAV.Sprint1.Task4.V5.Lib;
namespace Tyuiu.BochantsevAV.Sprint1.Task4.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double result = ds.Calculate(2, 4);

            Assert.AreEqual(0.25, result, 0.001);

        }
    }
}

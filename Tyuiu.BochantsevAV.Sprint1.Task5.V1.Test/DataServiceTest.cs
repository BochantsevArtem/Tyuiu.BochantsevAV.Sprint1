using Tyuiu.BochantsevAV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.BochantsevAV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()

        {
            DataService ds = new DataService();

            int result = ds.DistanceBetweenDots(0, 0, 3, 4);

            Assert.AreEqual(5, result);
        }
    }
}

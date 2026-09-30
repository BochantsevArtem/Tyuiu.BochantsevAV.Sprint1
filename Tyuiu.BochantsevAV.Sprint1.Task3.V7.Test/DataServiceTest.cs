using Tyuiu.BochantsevAV.Sprint1.Task3.V7.Lib;
namespace Tyuiu.BochantsevAV.Sprint1.Task3.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExprssion()
        {
            DataService ds = new DataService();
            
            double result = ds.VerstsToKilometers(100);

            Assert.AreEqual(106.68, result, 0.001);
        }
    }
}

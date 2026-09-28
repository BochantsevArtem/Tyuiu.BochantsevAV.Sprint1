using Newtonsoft.Json.Linq;
using Tyuiu.BochantsevAV.Sprint1.Task2.V1.Lib;
namespace Tyuiu.BochantsevAV.Sprint1.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            
            double result = ds.ConvertKmToM(100);

            Assert.AreEqual(62.1504, result, 0.001);
        }
    }
}

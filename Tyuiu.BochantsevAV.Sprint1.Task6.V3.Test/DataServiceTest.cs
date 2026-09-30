using Tyuiu.BochantsevAV.Sprint1.Task6.V3.Lib;
namespace Tyuiu.BochantsevAV.Sprint1.Task6.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string result = ds.LastLetterWord("Привет мир как дела");

            Assert.AreEqual("трка", result);
        }
    }
}

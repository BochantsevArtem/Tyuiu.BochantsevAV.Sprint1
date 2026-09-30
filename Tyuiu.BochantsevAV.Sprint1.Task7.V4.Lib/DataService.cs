    using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BochantsevAV.Sprint1.Task7.V4.Lib
{
    public class DataService : ISprint1Task7V4
    {
        public double Calculate(double x, double y)
        {
            double result = Math.Log(
               Math.Abs(
                   (y - Math.Sqrt(Math.Abs(x))) *
                   (x - y / (x + x * x / 4))
               )
           );
            result = Math.Round(result, 3);
            return result;
        }
    }
}


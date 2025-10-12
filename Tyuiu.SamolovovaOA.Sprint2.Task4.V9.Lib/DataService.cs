using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SamolovovaOA.Sprint2.Task4.V9.Lib
{
    public class DataService : ISprint2Task4V9
    {
        public double Calculate(double x, double y)
        {
            double z = (x + 5 < y / 2.0) ? Math.Pow(7 + 1.0 / Math.Pow(x, 2), y) : Math.Pow(x, 4) - (3.0 / y);
            return Math.Round(z, 3);
            
        }
    }
}

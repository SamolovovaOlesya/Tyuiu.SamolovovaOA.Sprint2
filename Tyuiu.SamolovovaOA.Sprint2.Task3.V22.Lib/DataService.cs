using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.SamolovovaOA.Sprint2.Task3.V22.Lib
{
    public class DataService : ISprint2Task3V22
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 1)
            {
                y = x + Math.Pow((x + 3) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            }
            else if (x > -26 && x < 2)
            {
                y = Math.Pow(3 + (2 / Math.Pow(x, 2)), x);
            }
            else if (x < -26)
            {
                y = x + 10 * x - (1 / x);
            }

            return Math.Round(y, 3);
        }
    }
}

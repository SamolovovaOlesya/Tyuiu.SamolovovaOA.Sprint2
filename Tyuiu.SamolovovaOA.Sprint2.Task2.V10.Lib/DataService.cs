using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SamolovovaOA.Sprint2.Task2.V10.Lib
{
    public class DataService : ISprint2Task2V10
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ( ((x >= 3 && x <= 5) && (y >= 3 && y <= 5))
               | ((x >= 8 && x <= 12) && (y >= 3 && y <= 5))
               | ((x >= 3 && x <= 12) && (y >= 6 && y <= 8))
               | ((x >= 3 && x <= 5) && (y >= 9 && y <= 13))
               | ((x >= 6 && x <= 8) && (y >= 11 && y <= 13))
               | ((x >= 11 && x <= 13) && (y >= 9 && y <= 11))
               ) 
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}

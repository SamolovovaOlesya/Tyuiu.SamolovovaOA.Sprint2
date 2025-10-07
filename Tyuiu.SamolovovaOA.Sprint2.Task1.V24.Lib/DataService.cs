using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SamolovovaOA.Sprint2.Task1.V24.Lib
{
    public class DataService : ISprint2Task1V24
    {

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) || (c > a);
            res[1] = (a != b) && (c < d);
            res[2] = !(a < c);
            res[3] = (a > b) & (c <= d);
            res[4] = (a >= b) ^ (b < c); 
            res[5] = (a <= c) && !(d < c);

            return res;
        }
    }
}

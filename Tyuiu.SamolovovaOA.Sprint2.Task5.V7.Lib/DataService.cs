using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SamolovovaOA.Sprint2.Task5.V7.Lib
{
    public class DataService : ISprint2Task5V7
    {
        public string FindMonthName(int startYear, int n)
        {
            int caseIndex = (n % 12) + 1;
            string res = string.Empty;
            switch (caseIndex)
            {
                case 1:
                    res = "январь"; 
                    break;

                case 2: 
                    res = "февраль"; 
                    break;

                case 3: 
                    res = "март"; 
                    break;

                case 4: 
                    res = "апрель"; 
                    break;

                case 5:
                    res = "май";
                    break;

                case 6: 
                    res = "июнь"; 
                    break;

                case 7: 
                    res = "июль"; 
                    break;

                case 8: 
                    res = "август"; 
                    break;

                case 9: 
                    res = "сентябрь"; 
                    break;

                case 10: 
                    res = "октябрь"; 
                    break;

                case 11: 
                    res = "ноябрь"; 
                    break;

                case 12: 
                    res = "декабрь"; 
                    break;

                default:
                    throw new ArgumentException("n должно быть в диапазоне от 0 до 12.");
            }

            return res;

        }
    }
}

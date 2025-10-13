using tyuiu.cources.programming.interfaces;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.SamolovovaOA.Sprint2.Task6.V14.Lib
{
    public class DataService : ISprint2Task6V14
    {
        public string FindDayName(int k, int d)
        {
            if (k < 1 || k > 365)
                throw new ArgumentException("День года должен быть в диапазоне 1..365");
            if (d < 1 || d > 7)
                throw new ArgumentException("День недели должен быть в диапазоне 1..7");

            int dayIndex = ((d - 1) + (k - 1)) % 7 + 1;

            return dayIndex switch
            {
                1 => "понедельник",
                2 => "вторник",
                3 => "среда",
                4 => "четверг",
                5 => "пятница",
                6 => "суббота",
                7 => "воскресенье",
                _ => throw new InvalidOperationException("Ошибка вычисления дня недели")
            };

        }
    }
}

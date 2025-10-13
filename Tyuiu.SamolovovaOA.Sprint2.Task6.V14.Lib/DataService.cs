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
                1 => "Понедельник",
                2 => "Вторник",
                3 => "Среда",
                4 => "Четверг",
                5 => "Пятница",
                6 => "Суббота",
                7 => "Воскресенье",
                _ => throw new InvalidOperationException("Ошибка вычисления дня недели")
            };

        }
    }
}

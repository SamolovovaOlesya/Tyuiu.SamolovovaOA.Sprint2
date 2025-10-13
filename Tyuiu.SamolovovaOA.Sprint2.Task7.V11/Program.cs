using Tyuiu.SamolovovaOA.Sprint2.Task7.V11.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task7.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("****************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ *");
            Console.WriteLine("****************************************");
            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите значение Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            bool res;

            if ((x * x + y * y > 1))
            {
                Console.WriteLine("Точка находится вне круга");
                res = false;
            }
            else
            {
                res = ds.CheckDotInShadedArea(x, y);
            }

            Console.WriteLine("****************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ *");
            Console.WriteLine("****************************************");
            Console.WriteLine("Точка принадлежит заштрихованной области: " + res);
            Console.ReadKey();
        }
    }
}

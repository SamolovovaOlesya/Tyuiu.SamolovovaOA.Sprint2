using Tyuiu.SamolovovaOA.Sprint2.Task4.V9.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task4.V9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            Console.WriteLine("**********************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ *");
            Console.WriteLine("**********************************************");

            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            double res = ds.Calculate(x, y);

            Console.WriteLine("**********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ *");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();
        }
    }
}

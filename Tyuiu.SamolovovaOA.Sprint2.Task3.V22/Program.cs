using Tyuiu.SamolovovaOA.Sprint2.Task3.V22.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task3.V22
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

            double res = ds.Calculate(x);

            Console.WriteLine("**********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ *");
            Console.WriteLine("**********************************************");
            Console.WriteLine("Значение функции Y: " + res);

            
            Console.ReadKey();
        }
    }
}


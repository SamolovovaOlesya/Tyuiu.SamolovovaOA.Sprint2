using Tyuiu.SamolovovaOA.Sprint2.Task6.V14.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task6.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ds = new DataService();

            Console.WriteLine("****************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ *");
            Console.Write("Введите номер дня года: ");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день недели 1 января: ");
            int d = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((k < 1) || (k > 365) || (d < 1) || (d > 7))
                res = "Введено неверное значение!";
            else
                res = ds.FindDayName(k, d);

            Console.WriteLine("****************************");
            Console.WriteLine("* РЕЗУЛЬТАТ *");
            Console.WriteLine(res);
            Console.WriteLine("****************************");
            Console.ReadKey();
        }
    }
}
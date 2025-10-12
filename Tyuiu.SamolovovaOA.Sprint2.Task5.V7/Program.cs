using Tyuiu.SamolovovaOA.Sprint2.Task5.V7.Lib;

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
            Console.Write("Введите номер месяца: ");
            int n= Convert.ToInt32(Console.ReadLine());

            string res;

            if ((n < 1) || (n > 12)) 
            {
                res = "Введено неверное значение!!!";
            }
            else 
            {
                res = "Это месяц: " + ds.FindMonthName(1990, n);
            }

            Console.WriteLine("**********************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ *");
            Console.WriteLine("**********************************************");
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}


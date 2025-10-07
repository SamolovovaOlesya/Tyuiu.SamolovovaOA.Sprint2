using Tyuiu.SamolovovaOA.Sprint2.Task1.V24.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task1.V24;
class Programm
{
    static void Main(string[] args)
    {
        var ds = new DataService();

        int a = 325;
        int b = 325;
        int c = 242;
        int d = 324;
        
        bool[] res = ds.GetLogicOperations(a, b, c, d);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadLine();
    }
}
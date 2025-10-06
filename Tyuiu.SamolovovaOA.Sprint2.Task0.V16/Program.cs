using Tyuiu.SamolovovaOA.Sprint2.Task0.V16.Lib;

namespace Tyuiu.SamolovovaOA.Sprint2.Task0.V16;

class Programm
{
    static void Main(string[] args) 
    {
        var ds = new DataService();

        int x = 1025;
        int y = 275;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("x = " + x);
        Console.WriteLine("y = " + y);
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < 6; i++) 
        {
            Console.WriteLine(res[i]);
        }
        
        Console.ReadLine();



    }
}

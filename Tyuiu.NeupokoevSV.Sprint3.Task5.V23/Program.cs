using Tyuiu.NeupokoevSV.Sprint3.Task5.V23.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x = 2;
        int startvalue1 = 1;
        int startvalue2 = 1;
        int stopValue1 = 3;
        int stopvalue2 = 10;
        double res = ds.GetSumSumSeries(x, startvalue1, stopValue1, startvalue2, stopvalue2);
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
    }
}
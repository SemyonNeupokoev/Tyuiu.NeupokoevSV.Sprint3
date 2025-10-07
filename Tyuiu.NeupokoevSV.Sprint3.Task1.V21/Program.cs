using Tyuiu.NeupokoevSV.Sprint3.Task1.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        double res = ds.GetMultiplySeries(x, y, z);
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
    }
}
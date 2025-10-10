using Tyuiu.NeupokoevSV.Sprint3.Task7.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int startvalue1 = -5;
        int stopValue1 = 5;
        int len = ds.GetMassFunction(startvalue1, stopValue1).Length;
        double[] valueArray;
        valueArray = new double[len];
        valueArray = ds.GetMassFunction(startvalue1, stopValue1);
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("+--------+--------+");
        Console.WriteLine("|    X   |    F(x)|");
        Console.WriteLine("+--------+--------+");

        for (int i = 0; i <= len - 1; i++)
        {
            Console.WriteLine("|{0, 5:d}          | {1, 5:f2}", startvalue1, valueArray[i]);
            startvalue1++;
        }
        Console.WriteLine("");
    }
}
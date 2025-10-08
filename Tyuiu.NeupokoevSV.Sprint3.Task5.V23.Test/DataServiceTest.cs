using Tyuiu.NeupokoevSV.Sprint3.Task5.V23.Lib;
namespace Tyuiu.NeupokoevSV.Sprint3.Task5.V23.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int x = 2;
        int startvalue1 = 1;
        int startvalue2 = 1;
        int stopValue1 = 3;
        int stopvalue2 = 10;
        double res = ds.GetSumSumSeries(x, startvalue1, stopValue1, startvalue2, stopvalue2);
        double wait = -1217.39;
        Assert.AreEqual(wait, res);
    }
}
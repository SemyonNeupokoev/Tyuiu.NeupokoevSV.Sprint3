using Tyuiu.NeupokoevSV.Sprint3.Task4.V19.Lib;
namespace Tyuiu.NeupokoevSV.Sprint3.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            double res = ds.Calculate(start, end);
            double wait = 8.175;
            Assert.AreEqual(wait, res);

        }
    }
}

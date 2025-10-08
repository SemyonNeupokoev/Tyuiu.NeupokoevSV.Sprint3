using Tyuiu.NeupokoevSV.Sprint3.Task6.V5.Lib;
namespace Tyuiu.NeupokoevSV.Sprint3.Task6.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 15;
            int stopValue = 22;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 242;
            Assert.AreEqual(wait, res);
        }
    }
}

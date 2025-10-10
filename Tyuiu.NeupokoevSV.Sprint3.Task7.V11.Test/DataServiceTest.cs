using Tyuiu.NeupokoevSV.Sprint3.Task7.V11.Lib;
namespace Tyuiu.NeupokoevSV.Sprint3.Task7.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;
            double[] valuewaitArray = new double[len];
            valuewaitArray[0] = 20.36;
            valuewaitArray[1] = 15.42;
            valuewaitArray[2] = 10.99;
            valuewaitArray[3] = 7.43;
            valuewaitArray[4] = 4.33;
            valuewaitArray[5] = 1.00;
            valuewaitArray[6] = 0.00;
            valuewaitArray[7] = -8.87;
            valuewaitArray[8] = -13.03;
            valuewaitArray[9] = -16.53;
            valuewaitArray[10] = -19.60;
            double[] res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valuewaitArray, res);
        }
    }
}

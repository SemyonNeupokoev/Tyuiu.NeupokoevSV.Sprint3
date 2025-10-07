using Tyuiu.NeupokoevSV.Sprint3.Task3.V9.Lib;
namespace Tyuiu.NeupokoevSV.Sprint3.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "56hy vfe4r4 vf45b";
            char item = 'w';
            string wait = "wwhy vfewrw vfwwb";
            string res = ds.ReplaceNumOnChar(value, item);
            Assert.AreEqual(wait, res);
        }
    }
}

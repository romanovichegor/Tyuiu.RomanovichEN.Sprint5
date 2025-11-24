using System.IO;
using Tyuiu.RomanovichEN.Sprint5.Task0.V27.Lib;
namespace Tyuiu.RomanovichEN.Sprint5.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            FileInfo fileinfo = new FileInfo(path);
            bool fileExsists = fileinfo.Exists;
            Assert.AreEqual(true, fileExsists);
        }
    }
}

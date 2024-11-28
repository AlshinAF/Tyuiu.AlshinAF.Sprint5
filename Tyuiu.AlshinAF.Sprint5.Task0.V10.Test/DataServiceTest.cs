using Tyuiu.AlshinAF.Sprint5.Task0.V10.Lib;
namespace Tyuiu.AlshinAF.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);   
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
            
        }
    }
}